namespace Simple_Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.milliseconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.savePath = new System.Windows.Forms.Label();
            this.openFolderBrowser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartTimer.Location = new System.Drawing.Point(76, 45);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(177, 75);
            this.btnStartTimer.TabIndex = 0;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "00h 00m 00s";
            // 
            // btnEndTimer
            // 
            this.btnEndTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEndTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndTimer.Enabled = false;
            this.btnEndTimer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEndTimer.Location = new System.Drawing.Point(610, 45);
            this.btnEndTimer.Name = "btnEndTimer";
            this.btnEndTimer.Size = new System.Drawing.Size(177, 75);
            this.btnEndTimer.TabIndex = 2;
            this.btnEndTimer.Text = "Stop";
            this.btnEndTimer.UseVisualStyleBackColor = true;
            this.btnEndTimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.program,
            this.startTimeStamp,
            this.endTimeStamp});
            this.dataGridView1.Location = new System.Drawing.Point(76, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(703, 219);
            this.dataGridView1.TabIndex = 4;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.time.Width = 150;
            // 
            // program
            // 
            this.program.HeaderText = "Program";
            this.program.MinimumWidth = 8;
            this.program.Name = "program";
            this.program.ReadOnly = true;
            this.program.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.program.Width = 150;
            // 
            // startTimeStamp
            // 
            this.startTimeStamp.HeaderText = "Start";
            this.startTimeStamp.MinimumWidth = 8;
            this.startTimeStamp.Name = "startTimeStamp";
            this.startTimeStamp.ReadOnly = true;
            this.startTimeStamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startTimeStamp.Width = 200;
            // 
            // endTimeStamp
            // 
            this.endTimeStamp.HeaderText = "End";
            this.endTimeStamp.MinimumWidth = 8;
            this.endTimeStamp.Name = "endTimeStamp";
            this.endTimeStamp.ReadOnly = true;
            this.endTimeStamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endTimeStamp.Width = 200;
            // 
            // programList
            // 
            this.programList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.programList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programList.FormattingEnabled = true;
            this.programList.Location = new System.Drawing.Point(210, 152);
            this.programList.Name = "programList";
            this.programList.Size = new System.Drawing.Size(517, 33);
            this.programList.TabIndex = 5;
            this.programList.SelectedIndexChanged += new System.EventHandler(this.programList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program:";
            // 
            // milliseconds
            // 
            this.milliseconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.milliseconds.AutoSize = true;
            this.milliseconds.Location = new System.Drawing.Point(511, 74);
            this.milliseconds.Name = "milliseconds";
            this.milliseconds.Size = new System.Drawing.Size(66, 25);
            this.milliseconds.TabIndex = 7;
            this.milliseconds.Text = "000ms";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Save File Path:";
            // 
            // savePath
            // 
            this.savePath.AutoSize = true;
            this.savePath.Location = new System.Drawing.Point(205, 468);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(0, 25);
            this.savePath.TabIndex = 10;
            // 
            // openFolderBrowser
            // 
            this.openFolderBrowser.Enabled = false;
            this.openFolderBrowser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.openFolderBrowser.Location = new System.Drawing.Point(708, 459);
            this.openFolderBrowser.Name = "openFolderBrowser";
            this.openFolderBrowser.Size = new System.Drawing.Size(112, 34);
            this.openFolderBrowser.TabIndex = 11;
            this.openFolderBrowser.Text = "Select Path";
            this.openFolderBrowser.UseVisualStyleBackColor = true;
            this.openFolderBrowser.Click += new System.EventHandler(this.openFolderBrowser_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(745, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 36);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(696, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "© Leonard Swaton";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFolderBrowser);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.milliseconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEndTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartTimer;
        private Label label1;
        private Button btnEndTimer;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn program;
        private DataGridViewTextBoxColumn startTimeStamp;
        private DataGridViewTextBoxColumn endTimeStamp;
        private ComboBox programList;
        private Label label2;
        private Label milliseconds;
        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label savePath;
        private Button openFolderBrowser;
        private Button button1;
        private Label label4;
    }
}