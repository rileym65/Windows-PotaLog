namespace PotaLog
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
            label1 = new Label();
            tb_CallSign = new TextBox();
            label2 = new Label();
            cb_Band = new ComboBox();
            label3 = new Label();
            dt_Date = new DateTimePicker();
            label4 = new Label();
            tb_Park = new TextBox();
            label5 = new Label();
            LogData = new DataGridView();
            CallSign = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            RstSent = new DataGridViewTextBoxColumn();
            RstRcvd = new DataGridViewTextBoxColumn();
            PTP = new DataGridViewCheckBoxColumn();
            Park = new DataGridViewTextBoxColumn();
            label6 = new Label();
            cb_Mode = new ComboBox();
            ExportButton = new Button();
            ExitButton = new Button();
            ExportDialog = new SaveFileDialog();
            SaveButton = new Button();
            LoadFileDialog = new OpenFileDialog();
            LoadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LogData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Call Sign:";
            // 
            // tb_CallSign
            // 
            tb_CallSign.Location = new Point(74, 6);
            tb_CallSign.Name = "tb_CallSign";
            tb_CallSign.Size = new Size(100, 23);
            tb_CallSign.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Band:";
            // 
            // cb_Band
            // 
            cb_Band.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Band.FormattingEnabled = true;
            cb_Band.Items.AddRange(new object[] { "70CM", "2M", "6M", "10M", "12M", "15M", "17M", "20M", "30M", "40M", "60M", "80M", "160M", "630M", "2200M" });
            cb_Band.Location = new Point(74, 35);
            cb_Band.Name = "cb_Band";
            cb_Band.Size = new Size(121, 23);
            cb_Band.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 9);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            // 
            // dt_Date
            // 
            dt_Date.Location = new Point(287, 3);
            dt_Date.Name = "dt_Date";
            dt_Date.Size = new Size(200, 23);
            dt_Date.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 38);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Park:";
            // 
            // tb_Park
            // 
            tb_Park.Location = new Point(287, 35);
            tb_Park.Name = "tb_Park";
            tb_Park.Size = new Size(200, 23);
            tb_Park.TabIndex = 7;
            tb_Park.Text = "US-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 75);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Contacts:";
            // 
            // LogData
            // 
            LogData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogData.Columns.AddRange(new DataGridViewColumn[] { CallSign, Time, RstSent, RstRcvd, PTP, Park });
            LogData.Location = new Point(12, 93);
            LogData.Name = "LogData";
            LogData.Size = new Size(712, 309);
            LogData.TabIndex = 9;
            // 
            // CallSign
            // 
            CallSign.HeaderText = "Callsign";
            CallSign.Name = "CallSign";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // RstSent
            // 
            RstSent.HeaderText = "RST Sent";
            RstSent.Name = "RstSent";
            // 
            // RstRcvd
            // 
            RstRcvd.HeaderText = "RST Rcvd";
            RstRcvd.Name = "RstRcvd";
            // 
            // PTP
            // 
            PTP.HeaderText = "PTP";
            PTP.Name = "PTP";
            // 
            // Park
            // 
            Park.HeaderText = "Park";
            Park.Name = "Park";
            Park.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(556, 9);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Mode:";
            // 
            // cb_Mode
            // 
            cb_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Mode.FormattingEnabled = true;
            cb_Mode.Items.AddRange(new object[] { "AM", "CW", "FM", "FT8", "SSB" });
            cb_Mode.Location = new Point(603, 6);
            cb_Mode.Name = "cb_Mode";
            cb_Mode.Size = new Size(121, 23);
            cb_Mode.TabIndex = 11;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(12, 417);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(75, 23);
            ExportButton.TabIndex = 12;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(649, 417);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(265, 417);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadFileDialog
            // 
            LoadFileDialog.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(372, 417);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 15;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(ExitButton);
            Controls.Add(ExportButton);
            Controls.Add(cb_Mode);
            Controls.Add(label6);
            Controls.Add(LogData);
            Controls.Add(label5);
            Controls.Add(tb_Park);
            Controls.Add(label4);
            Controls.Add(dt_Date);
            Controls.Add(label3);
            Controls.Add(cb_Band);
            Controls.Add(label2);
            Controls.Add(tb_CallSign);
            Controls.Add(label1);
            Name = "Form1";
            Text = "POTA Log";
            ((System.ComponentModel.ISupportInitialize)LogData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_CallSign;
        private Label label2;
        private ComboBox cb_Band;
        private Label label3;
        private DateTimePicker dt_Date;
        private Label label4;
        private TextBox tb_Park;
        private Label label5;
        private DataGridView LogData;
        private Label label6;
        private ComboBox cb_Mode;
        private DataGridViewTextBoxColumn CallSign;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn RstSent;
        private DataGridViewTextBoxColumn RstRcvd;
        private DataGridViewCheckBoxColumn PTP;
        private DataGridViewTextBoxColumn Park;
        private Button ExportButton;
        private Button ExitButton;
        private SaveFileDialog ExportDialog;
        private Button SaveButton;
        private OpenFileDialog LoadFileDialog;
        private Button LoadButton;
    }
}
