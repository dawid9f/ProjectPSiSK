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
            this.btnStopIoT = new System.Windows.Forms.Button();
            this.btnStartIoT = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelStatusIoT = new System.Windows.Forms.Label();
            this.pgBarIot = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txHostIoT = new System.Windows.Forms.TextBox();
            this.txDivKey = new System.Windows.Forms.TextBox();
            this.txDivId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pgBarStatus);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(495, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Połączenie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pgBarStatus
            // 
            this.pgBarStatus.Location = new System.Drawing.Point(9, 259);
            this.pgBarStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pgBarStatus.Name = "pgBarStatus";
            this.pgBarStatus.Size = new System.Drawing.Size(471, 31);
            this.pgBarStatus.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(362, 205);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Rozłącz";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(362, 155);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(118, 43);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Połącz";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Location = new System.Drawing.Point(362, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(118, 137);
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
            this.labelStatus.Location = new System.Drawing.Point(20, 45);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(88, 50);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(343, 247);
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
            this.cbBoxStopB.Location = new System.Drawing.Point(168, 189);
            this.cbBoxStopB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxStopB.Name = "cbBoxStopB";
            this.cbBoxStopB.Size = new System.Drawing.Size(138, 28);
            this.cbBoxStopB.TabIndex = 1;
            this.cbBoxStopB.Text = "One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
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
            this.cbBoxParityB.Location = new System.Drawing.Point(168, 151);
            this.cbBoxParityB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxParityB.Name = "cbBoxParityB";
            this.cbBoxParityB.Size = new System.Drawing.Size(138, 28);
            this.cbBoxParityB.TabIndex = 1;
            this.cbBoxParityB.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
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
            this.cbBoxDataB.Location = new System.Drawing.Point(168, 112);
            this.cbBoxDataB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxDataB.Name = "cbBoxDataB";
            this.cbBoxDataB.Size = new System.Drawing.Size(138, 28);
            this.cbBoxDataB.TabIndex = 1;
            this.cbBoxDataB.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
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
            this.cbBoxRate.Location = new System.Drawing.Point(168, 73);
            this.cbBoxRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxRate.Name = "cbBoxRate";
            this.cbBoxRate.Size = new System.Drawing.Size(138, 28);
            this.cbBoxRate.TabIndex = 1;
            this.cbBoxRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prędkość:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(168, 35);
            this.cbBoxPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(138, 28);
            this.cbBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa portu:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.txBoxOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(495, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wysyłanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(361, 249);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 49);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckBoxWriteLine);
            this.groupBox3.Controls.Add(this.ckBoxEnterSending);
            this.groupBox3.Location = new System.Drawing.Point(3, 239);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(351, 60);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // ckBoxWriteLine
            // 
            this.ckBoxWriteLine.AutoSize = true;
            this.ckBoxWriteLine.Location = new System.Drawing.Point(213, 25);
            this.ckBoxWriteLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckBoxWriteLine.Name = "ckBoxWriteLine";
            this.ckBoxWriteLine.Size = new System.Drawing.Size(144, 24);
            this.ckBoxWriteLine.TabIndex = 1;
            this.ckBoxWriteLine.Text = "Wyślij całą linijkę";
            this.ckBoxWriteLine.UseVisualStyleBackColor = true;
            this.ckBoxWriteLine.CheckedChanged += new System.EventHandler(this.ckBoxWriteLine_CheckedChanged);
            // 
            // ckBoxEnterSending
            // 
            this.ckBoxEnterSending.AutoSize = true;
            this.ckBoxEnterSending.Location = new System.Drawing.Point(7, 24);
            this.ckBoxEnterSending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckBoxEnterSending.Name = "ckBoxEnterSending";
            this.ckBoxEnterSending.Size = new System.Drawing.Size(217, 24);
            this.ckBoxEnterSending.TabIndex = 0;
            this.ckBoxEnterSending.Text = "Wysyłaj przy pomocy Entera";
            this.ckBoxEnterSending.UseVisualStyleBackColor = true;
            this.ckBoxEnterSending.CheckedChanged += new System.EventHandler(this.ckBoxEnterSending_CheckedChanged);
            // 
            // txBoxOut
            // 
            this.txBoxOut.Location = new System.Drawing.Point(0, 4);
            this.txBoxOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBoxOut.Multiline = true;
            this.txBoxOut.Name = "txBoxOut";
            this.txBoxOut.Size = new System.Drawing.Size(490, 233);
            this.txBoxOut.TabIndex = 0;
            this.txBoxOut.TextChanged += new System.EventHandler(this.txBoxOut_TextChanged);
            this.txBoxOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBoxOut_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.txBoxIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(495, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Odbieranie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 249);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Wyczyść";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckBoxLogTXT);
            this.groupBox4.Controls.Add(this.ckBoxView);
            this.groupBox4.Location = new System.Drawing.Point(3, 239);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(351, 60);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // ckBoxLogTXT
            // 
            this.ckBoxLogTXT.AutoSize = true;
            this.ckBoxLogTXT.Location = new System.Drawing.Point(154, 24);
            this.ckBoxLogTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckBoxLogTXT.Name = "ckBoxLogTXT";
            this.ckBoxLogTXT.Size = new System.Drawing.Size(192, 24);
            this.ckBoxLogTXT.TabIndex = 1;
            this.ckBoxLogTXT.Text = "Zapisz logi do pliku *.txt";
            this.ckBoxLogTXT.UseVisualStyleBackColor = true;
            this.ckBoxLogTXT.CheckedChanged += new System.EventHandler(this.ckBoxLogTXT_CheckedChanged);
            // 
            // ckBoxView
            // 
            this.ckBoxView.AutoSize = true;
            this.ckBoxView.Location = new System.Drawing.Point(17, 24);
            this.ckBoxView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckBoxView.Name = "ckBoxView";
            this.ckBoxView.Size = new System.Drawing.Size(132, 24);
            this.ckBoxView.TabIndex = 0;
            this.ckBoxView.Text = "Włącz podgląd";
            this.ckBoxView.UseVisualStyleBackColor = true;
            this.ckBoxView.CheckedChanged += new System.EventHandler(this.ckBoxView_CheckedChanged);
            // 
            // txBoxIn
            // 
            this.txBoxIn.Enabled = false;
            this.txBoxIn.Location = new System.Drawing.Point(0, 4);
            this.txBoxIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBoxIn.Multiline = true;
            this.txBoxIn.Name = "txBoxIn";
            this.txBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBoxIn.Size = new System.Drawing.Size(490, 233);
            this.txBoxIn.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnStopIoT);
            this.tabPage4.Controls.Add(this.btnStartIoT);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.pgBarIot);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(495, 307);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IoT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnStopIoT
            // 
            this.btnStopIoT.Location = new System.Drawing.Point(362, 205);
            this.btnStopIoT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopIoT.Name = "btnStopIoT";
            this.btnStopIoT.Size = new System.Drawing.Size(118, 43);
            this.btnStopIoT.TabIndex = 4;
            this.btnStopIoT.Text = "Stop";
            this.btnStopIoT.UseVisualStyleBackColor = true;
            // 
            // btnStartIoT
            // 
            this.btnStartIoT.Location = new System.Drawing.Point(362, 155);
            this.btnStartIoT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartIoT.Name = "btnStartIoT";
            this.btnStartIoT.Size = new System.Drawing.Size(118, 43);
            this.btnStartIoT.TabIndex = 3;
            this.btnStartIoT.Text = "Start";
            this.btnStartIoT.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelStatusIoT);
            this.groupBox6.Location = new System.Drawing.Point(362, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(118, 137);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Wysyłąnie";
            // 
            // labelStatusIoT
            // 
            this.labelStatusIoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatusIoT.AutoSize = true;
            this.labelStatusIoT.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatusIoT.ForeColor = System.Drawing.Color.Red;
            this.labelStatusIoT.Location = new System.Drawing.Point(20, 45);
            this.labelStatusIoT.Name = "labelStatusIoT";
            this.labelStatusIoT.Size = new System.Drawing.Size(88, 50);
            this.labelStatusIoT.TabIndex = 0;
            this.labelStatusIoT.Text = "OFF";
            // 
            // pgBarIot
            // 
            this.pgBarIot.Location = new System.Drawing.Point(9, 259);
            this.pgBarIot.Name = "pgBarIot";
            this.pgBarIot.Size = new System.Drawing.Size(471, 31);
            this.pgBarIot.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txHostIoT);
            this.groupBox5.Controls.Add(this.txDivKey);
            this.groupBox5.Controls.Add(this.txDivId);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(9, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 244);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ustawienia urządzenia IoT";
            // 
            // txHostIoT
            // 
            this.txHostIoT.Location = new System.Drawing.Point(34, 198);
            this.txHostIoT.Name = "txHostIoT";
            this.txHostIoT.Size = new System.Drawing.Size(268, 27);
            this.txHostIoT.TabIndex = 5;
            // 
            // txDivKey
            // 
            this.txDivKey.Location = new System.Drawing.Point(34, 129);
            this.txDivKey.Name = "txDivKey";
            this.txDivKey.Size = new System.Drawing.Size(268, 27);
            this.txDivKey.TabIndex = 4;
            // 
            // txDivId
            // 
            this.txDivId.Location = new System.Drawing.Point(34, 63);
            this.txDivId.Name = "txDivId";
            this.txDivId.Size = new System.Drawing.Size(268, 27);
            this.txDivId.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nazwa hosta IoT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Klucz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id urządzenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 327);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(516, 374);
            this.MinimumSize = new System.Drawing.Size(516, 374);
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
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private GroupBox groupBox5;
        private Button btnStopIoT;
        private Button btnStartIoT;
        private GroupBox groupBox6;
        private Label labelStatusIoT;
        private ProgressBar pgBarIot;
        private TextBox txHostIoT;
        private TextBox txDivKey;
        private TextBox txDivId;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}