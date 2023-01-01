using System.Diagnostics;
using System.Text.Json;

namespace Simple_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stopwatch stopWatch;
        private string timeFormat = "{0:00}h {1:00}m {2:00}s";
        private DateTime lastStartTimeStamp;
        private List<string> openPrograms;
        private string activeProgram;
        private string selectedProgram;
        private string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private string saveFileName = "\\times.json";

        private void Form1_Load(object sender, EventArgs e)
        {
            // make folder browser invisible
            openFolderBrowser.FlatStyle = FlatStyle.Flat;
            openFolderBrowser.FlatAppearance.BorderColor = BackColor;
            openFolderBrowser.FlatAppearance.MouseOverBackColor = BackColor;
            openFolderBrowser.FlatAppearance.MouseDownBackColor = BackColor;
            openFolderBrowser.Text = string.Empty;

            this.Text = "Task Time Tracker";
            savePath.Text = saveFilePath + saveFileName;
            stopWatch = new Stopwatch();

            this.openPrograms = loadOpenPrograms();
            setOpenPrograms();
            loadEntries();
        }

        /*
         * function declarations
         * saveEntries() : void
         * loadEntries() : void
         * loadOpenPrograms() : List<string>
         * setOpenPrograms() : void
         */
        private void saveEntries()
        {
            List<Dictionary<string, string>> lines = new List<Dictionary<string, string>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var time = String.Format("{0}", row.Cells["time"].Value);
                var program = String.Format("{0}", row.Cells["program"].Value);
                var start = String.Format("{0}", row.Cells["startTimeStamp"].Value);
                var end = String.Format("{0}", row.Cells["endTimeStamp"].Value);

                Dictionary<string, string> line = new Dictionary<string, string>();

                line.Add("time", time);
                line.Add("program", program);
                line.Add("start", start);
                line.Add("end", end);

                lines.Add(line);
            }

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(lines, jsonOptions);
            File.WriteAllText(savePath.Text, jsonData);
        }

        private void loadEntries()
        {
            /*
             * since were using the desktop as our standart path for now
             * we don't need this
             *
            if (!Directory.Exists(saveFilePath))
            {
                Directory.CreateDirectory(saveFilePath);
                return;
            }
            */

            if (!File.Exists(savePath.Text))
            {
                File.WriteAllText(savePath.Text, "");
                return;
            }

            string? jsonData = File.ReadAllText(savePath.Text);

            if (String.IsNullOrEmpty(jsonData)) { return; }

            List<Dictionary<string, string>>? lines = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(jsonData);
            foreach (var line in lines)
            {
                dataGridView1.Rows.Add(line["time"], line["program"], line["start"], line["end"]);
            }
        }

        private List<string> loadOpenPrograms()
        {
            Process[] processList = Process.GetProcesses();

            string[] programElements;
            List<string> programs = new List<string>();
            foreach (Process process in processList)
            {
                programElements = process.MainWindowTitle.Split("-");
                int lastElement = programElements.Length - 1;
                string programTitle = programElements[lastElement].Trim();
                if (!String.IsNullOrEmpty(programTitle))
                {
                    programs.Add(programTitle);
                }
            }

            return programs;
        }

        private void setOpenPrograms()
        {
            programList.Items.Clear();
            foreach (var program in openPrograms)
            {
                programList.Items.Add(program);
            }
        }

        /*
         * Events
         * button1_Click()
         * button2_Click()
         * timer1_Tick()
         * programList_SelectedIndexChanged
         * button1_Click_1
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (stopWatch.ElapsedMilliseconds > 0)
            {
                stopWatch.Restart();
            } else
            {
                stopWatch.Start();
            }
            this.selectedProgram = this.activeProgram;
            lastStartTimeStamp = DateTime.Now;
            btnStartTimer.Enabled = false;
            btnEndTimer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            DateTime now = DateTime.Now;
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format(timeFormat, ts.Hours, ts.Minutes, ts.Seconds);
            dataGridView1.Rows.Insert(0, elapsedTime, selectedProgram, lastStartTimeStamp, now);
            btnStartTimer.Enabled = true;
            btnEndTimer.Enabled = false;
            saveEntries();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format(timeFormat, ts.Hours, ts.Minutes, ts.Seconds);
            label1.Text = elapsedTime;
            milliseconds.Text = String.Format("{0:00}ms", ts.Milliseconds);
        }

        private void programList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (programList.SelectedItem != null)
            {
                var selectedItem = programList.SelectedItem;
                this.activeProgram = programList.GetItemText(selectedItem);
            }
        }

        // currently disabled because of write permission issues
        private void openFolderBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> newOpenPrograms = loadOpenPrograms();
            if (newOpenPrograms.Count > this.openPrograms.Count || newOpenPrograms.Count < this.openPrograms.Count)
            {
                this.openPrograms = newOpenPrograms;
                setOpenPrograms();
            }
        }
    }
}