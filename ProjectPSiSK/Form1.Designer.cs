namespace ProjectPSiSK
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pgBarStatus = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBoxStopB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxParityB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxDataB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.ckBoxEnterSending = new System.Windows.Forms.CheckBox();
            this.txBoxOut = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckBoxLogTXT = new System.Windows.Forms.CheckBox();
            this.ckBoxView = new System.Windows.Forms.CheckBox();
            this.txBoxIn = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pgBarStatus);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Połączenie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pgBarStatus
            // 
            this.pgBarStatus.Location = new System.Drawing.Point(8, 194);
            this.pgBarStatus.Name = "pgBarStatus";
            this.pgBarStatus.Size = new System.Drawing.Size(412, 23);
            this.pgBarStatus.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(317, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Rozłącz";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(317, 116);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 32);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Połącz";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Location = new System.Drawing.Point(317, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(23, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(69, 40);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "OFF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBoxStopB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbBoxParityB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbBoxDataB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbBoxRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBoxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia";
            // 
            // cbBoxStopB
            // 
            this.cbBoxStopB.FormattingEnabled = true;
            this.cbBoxStopB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbBoxStopB.Location = new System.Drawing.Point(147, 142);
            this.cbBoxStopB.Name = "cbBoxStopB";
            this.cbBoxStopB.Size = new System.Drawing.Size(121, 23);
            this.cbBoxStopB.TabIndex = 1;
            this.cbBoxStopB.Text = "One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bity stopu:";
            // 
            // cbBoxParityB
            // 
            this.cbBoxParityB.FormattingEnabled = true;
            this.cbBoxParityB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbBoxParityB.Location = new System.Drawing.Point(147, 113);
            this.cbBoxParityB.Name = "cbBoxParityB";
            this.cbBoxParityB.Size = new System.Drawing.Size(121, 23);
            this.cbBoxParityB.TabIndex = 1;
            this.cbBoxParityB.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bity parzystości:";
            // 
            // cbBoxDataB
            // 
            this.cbBoxDataB.FormattingEnabled = true;
            this.cbBoxDataB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbBoxDataB.Location = new System.Drawing.Point(147, 84);
            this.cbBoxDataB.Name = "cbBoxDataB";
            this.cbBoxDataB.Size = new System.Drawing.Size(121, 23);
            this.cbBoxDataB.TabIndex = 1;
            this.cbBoxDataB.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bity danych:";
            // 
            // cbBoxRate
            // 
            this.cbBoxRate.FormattingEnabled = true;
            this.cbBoxRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbBoxRate.Location = new System.Drawing.Point(147, 55);
            this.cbBoxRate.Name = "cbBoxRate";
            this.cbBoxRate.Size = new System.Drawing.Size(121, 23);
            this.cbBoxRate.TabIndex = 1;
            this.cbBoxRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prędkość:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(147, 26);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(121, 23);
            this.cbBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa portu:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.txBoxOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wysyłanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(316, 187);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckBoxWriteLine);
            this.groupBox3.Controls.Add(this.ckBoxEnterSending);
            this.groupBox3.Location = new System.Drawing.Point(3, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 45);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // ckBoxWriteLine
            // 
            this.ckBoxWriteLine.AutoSize = true;
            this.ckBoxWriteLine.Location = new System.Drawing.Point(186, 19);
            this.ckBoxWriteLine.Name = "ckBoxWriteLine";
            this.ckBoxWriteLine.Size = new System.Drawing.Size(115, 19);
            this.ckBoxWriteLine.TabIndex = 1;
            this.ckBoxWriteLine.Text = "Wyślij całą linijkę";
            this.ckBoxWriteLine.UseVisualStyleBackColor = true;
            this.ckBoxWriteLine.CheckedChanged += new System.EventHandler(this.ckBoxWriteLine_CheckedChanged);
            // 
            // ckBoxEnterSending
            // 
            this.ckBoxEnterSending.AutoSize = true;
            this.ckBoxEnterSending.Location = new System.Drawing.Point(6, 18);
            this.ckBoxEnterSending.Name = "ckBoxEnterSending";
            this.ckBoxEnterSending.Size = new System.Drawing.Size(174, 19);
            this.ckBoxEnterSending.TabIndex = 0;
            this.ckBoxEnterSending.Text = "Wysyłaj przy pomocy Entera";
            this.ckBoxEnterSending.UseVisualStyleBackColor = true;
            this.ckBoxEnterSending.CheckedChanged += new System.EventHandler(this.ckBoxEnterSending_CheckedChanged);
            // 
            // txBoxOut
            // 
            this.txBoxOut.Location = new System.Drawing.Point(0, 3);
            this.txBoxOut.Multiline = true;
            this.txBoxOut.Name = "txBoxOut";
            this.txBoxOut.Size = new System.Drawing.Size(429, 176);
            this.txBoxOut.TabIndex = 0;
            this.txBoxOut.TextChanged += new System.EventHandler(this.txBoxOut_TextChanged);
            this.txBoxOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBoxOut_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.txBoxIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(432, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Odbieranie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Wyczyść";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckBoxLogTXT);
            this.groupBox4.Controls.Add(this.ckBoxView);
            this.groupBox4.Location = new System.Drawing.Point(3, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 45);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // ckBoxLogTXT
            // 
            this.ckBoxLogTXT.AutoSize = true;
            this.ckBoxLogTXT.Location = new System.Drawing.Point(135, 18);
            this.ckBoxLogTXT.Name = "ckBoxLogTXT";
            this.ckBoxLogTXT.Size = new System.Drawing.Size(153, 19);
            this.ckBoxLogTXT.TabIndex = 1;
            this.ckBoxLogTXT.Text = "Zapisz logi do pliku *.txt";
            this.ckBoxLogTXT.UseVisualStyleBackColor = true;
            this.ckBoxLogTXT.CheckedChanged += new System.EventHandler(this.ckBoxLogTXT_CheckedChanged);
            // 
            // ckBoxView
            // 
            this.ckBoxView.AutoSize = true;
            this.ckBoxView.Location = new System.Drawing.Point(15, 18);
            this.ckBoxView.Name = "ckBoxView";
            this.ckBoxView.Size = new System.Drawing.Size(104, 19);
            this.ckBoxView.TabIndex = 0;
            this.ckBoxView.Text = "Włącz podgląd";
            this.ckBoxView.UseVisualStyleBackColor = true;
            this.ckBoxView.CheckedChanged += new System.EventHandler(this.ckBoxView_CheckedChanged);
            // 
            // txBoxIn
            // 
            this.txBoxIn.Enabled = false;
            this.txBoxIn.Location = new System.Drawing.Point(0, 3);
            this.txBoxIn.Multiline = true;
            this.txBoxIn.Name = "txBoxIn";
            this.txBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBoxIn.Size = new System.Drawing.Size(429, 176);
            this.txBoxIn.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(432, 227);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IoT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 253);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(454, 292);
            this.MinimumSize = new System.Drawing.Size(454, 292);
            this.Name = "Form1";
            this.Text = "Com2IoT";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Label label1;
        private ComboBox cbBoxStopB;
        private Label label5;
        private ComboBox cbBoxParityB;
        private Label label4;
        private ComboBox cbBoxDataB;
        private Label label3;
        private ComboBox cbBoxRate;
        private Label label2;
        private ComboBox cbBoxPort;
        private Button btnClose;
        private Button btnOpen;
        private GroupBox groupBox2;
        private ProgressBar pgBarStatus;
        private Label labelStatus;
        private TextBox txBoxOut;
        private GroupBox groupBox3;
        private CheckBox ckBoxWriteLine;
        private CheckBox ckBoxEnterSending;
        private TabPage tabPage3;
        private TextBox txBoxIn;
        private TabPage tabPage4;
        private Button btnSend;
        private GroupBox groupBox4;
        private Button btnDelete;
        private CheckBox ckBoxLogTXT;
        private CheckBox ckBoxView;
    }
}