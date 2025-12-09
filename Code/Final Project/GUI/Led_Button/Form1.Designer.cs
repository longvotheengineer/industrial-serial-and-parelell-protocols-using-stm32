namespace Led_Button
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOff_1 = new System.Windows.Forms.Button();
            this.btnOn_1 = new System.Windows.Forms.Button();
            this.srlCOM = new System.IO.Ports.SerialPort(this.components);
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.lstReceiveLEDStatus = new System.Windows.Forms.ListBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStoreLEDStatus = new System.Windows.Forms.Button();
            this.btnLED_Tracking = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOn_2 = new System.Windows.Forms.Button();
            this.btnOff_2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPosition45 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRampDownSpeed = new System.Windows.Forms.Button();
            this.btnStopControlSpeed = new System.Windows.Forms.Button();
            this.trkMotorSpeed = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPositionTracking = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPosition360 = new System.Windows.Forms.Button();
            this.btnPosition180 = new System.Windows.Forms.Button();
            this.btnPosition90 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnOffOpto = new System.Windows.Forms.Button();
            this.btnOnOpto = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtDILow = new System.Windows.Forms.TextBox();
            this.txtDIHigh = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.lstReceiveMotorPulse = new System.Windows.Forms.ListBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lstReceiveMotorPosition = new System.Windows.Forms.ListBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.pnlLED2 = new System.Windows.Forms.Panel();
            this.pnlLED1 = new System.Windows.Forms.Panel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txt7SegLED = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn7SegLED = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btnGetWeight = new System.Windows.Forms.Button();
            this.txtGetWeight = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btnStopDAC = new System.Windows.Forms.Button();
            this.txtDutyCycle = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMotorSpeed)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 36);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(143, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOff_1
            // 
            this.btnOff_1.Location = new System.Drawing.Point(56, 24);
            this.btnOff_1.Name = "btnOff_1";
            this.btnOff_1.Size = new System.Drawing.Size(50, 36);
            this.btnOff_1.TabIndex = 0;
            this.btnOff_1.Text = "OFF";
            this.btnOff_1.UseVisualStyleBackColor = true;
            this.btnOff_1.Click += new System.EventHandler(this.btnOff_1_Click);
            // 
            // btnOn_1
            // 
            this.btnOn_1.Location = new System.Drawing.Point(0, 24);
            this.btnOn_1.Name = "btnOn_1";
            this.btnOn_1.Size = new System.Drawing.Size(50, 36);
            this.btnOn_1.TabIndex = 0;
            this.btnOn_1.Text = "ON";
            this.btnOn_1.UseVisualStyleBackColor = true;
            this.btnOn_1.Click += new System.EventHandler(this.btnOn_1_Click);
            // 
            // srlCOM
            // 
            this.srlCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srlCOM_DataReceived);
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(70, 162);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(146, 36);
            this.txtSendData.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 162);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.cmbCOM);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM CONFIGURATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Location = new System.Drawing.Point(83, 64);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(101, 24);
            this.cmbBaudrate.TabIndex = 0;
            // 
            // cmbCOM
            // 
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(83, 31);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(101, 24);
            this.cmbCOM.TabIndex = 0;
            // 
            // lstReceiveLEDStatus
            // 
            this.lstReceiveLEDStatus.FormattingEnabled = true;
            this.lstReceiveLEDStatus.ItemHeight = 16;
            this.lstReceiveLEDStatus.Location = new System.Drawing.Point(6, 24);
            this.lstReceiveLEDStatus.Name = "lstReceiveLEDStatus";
            this.lstReceiveLEDStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstReceiveLEDStatus.Size = new System.Drawing.Size(141, 68);
            this.lstReceiveLEDStatus.TabIndex = 4;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(7, 199);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(420, 258);
            this.zedGraphControl1.TabIndex = 5;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStoreLEDStatus);
            this.groupBox2.Controls.Add(this.btnLED_Tracking);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL LED";
            // 
            // btnStoreLEDStatus
            // 
            this.btnStoreLEDStatus.Location = new System.Drawing.Point(122, 122);
            this.btnStoreLEDStatus.Name = "btnStoreLEDStatus";
            this.btnStoreLEDStatus.Size = new System.Drawing.Size(87, 36);
            this.btnStoreLEDStatus.TabIndex = 8;
            this.btnStoreLEDStatus.Text = "Store Status";
            this.btnStoreLEDStatus.UseVisualStyleBackColor = true;
            this.btnStoreLEDStatus.Click += new System.EventHandler(this.btnStoreLEDStatus_Click);
            // 
            // btnLED_Tracking
            // 
            this.btnLED_Tracking.Location = new System.Drawing.Point(122, 51);
            this.btnLED_Tracking.Name = "btnLED_Tracking";
            this.btnLED_Tracking.Size = new System.Drawing.Size(87, 36);
            this.btnLED_Tracking.TabIndex = 1;
            this.btnLED_Tracking.Text = "Tracking";
            this.btnLED_Tracking.UseVisualStyleBackColor = true;
            this.btnLED_Tracking.Click += new System.EventHandler(this.btnLED_Tracking_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOn_2);
            this.groupBox5.Controls.Add(this.btnOff_2);
            this.groupBox5.Location = new System.Drawing.Point(6, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 66);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LED 2";
            // 
            // btnOn_2
            // 
            this.btnOn_2.Location = new System.Drawing.Point(0, 24);
            this.btnOn_2.Name = "btnOn_2";
            this.btnOn_2.Size = new System.Drawing.Size(50, 36);
            this.btnOn_2.TabIndex = 0;
            this.btnOn_2.Text = "ON";
            this.btnOn_2.UseVisualStyleBackColor = true;
            this.btnOn_2.Click += new System.EventHandler(this.btnOn_2_Click);
            // 
            // btnOff_2
            // 
            this.btnOff_2.Location = new System.Drawing.Point(56, 24);
            this.btnOff_2.Name = "btnOff_2";
            this.btnOff_2.Size = new System.Drawing.Size(50, 36);
            this.btnOff_2.TabIndex = 0;
            this.btnOff_2.Text = "OFF";
            this.btnOff_2.UseVisualStyleBackColor = true;
            this.btnOff_2.Click += new System.EventHandler(this.btnOff_2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOn_1);
            this.groupBox3.Controls.Add(this.btnOff_1);
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 66);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED 1";
            // 
            // btnPosition45
            // 
            this.btnPosition45.Location = new System.Drawing.Point(6, 23);
            this.btnPosition45.Name = "btnPosition45";
            this.btnPosition45.Size = new System.Drawing.Size(78, 38);
            this.btnPosition45.TabIndex = 8;
            this.btnPosition45.Text = "45°";
            this.btnPosition45.UseVisualStyleBackColor = true;
            this.btnPosition45.Click += new System.EventHandler(this.btnPosition45_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.btnPositionTracking);
            this.groupBox4.Controls.Add(this.btnDraw);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.zedGraphControl1);
            this.groupBox4.Location = new System.Drawing.Point(501, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 464);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL MOTOR";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRampDownSpeed);
            this.groupBox7.Controls.Add(this.btnStopControlSpeed);
            this.groupBox7.Controls.Add(this.trkMotorSpeed);
            this.groupBox7.Location = new System.Drawing.Point(186, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(241, 122);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SPEED";
            // 
            // btnRampDownSpeed
            // 
            this.btnRampDownSpeed.Location = new System.Drawing.Point(122, 80);
            this.btnRampDownSpeed.Name = "btnRampDownSpeed";
            this.btnRampDownSpeed.Size = new System.Drawing.Size(113, 36);
            this.btnRampDownSpeed.TabIndex = 11;
            this.btnRampDownSpeed.Text = "Ramp Down";
            this.btnRampDownSpeed.UseVisualStyleBackColor = true;
            // 
            // btnStopControlSpeed
            // 
            this.btnStopControlSpeed.Location = new System.Drawing.Point(6, 80);
            this.btnStopControlSpeed.Name = "btnStopControlSpeed";
            this.btnStopControlSpeed.Size = new System.Drawing.Size(113, 36);
            this.btnStopControlSpeed.TabIndex = 11;
            this.btnStopControlSpeed.Text = "Stop";
            this.btnStopControlSpeed.UseVisualStyleBackColor = true;
            this.btnStopControlSpeed.Click += new System.EventHandler(this.btnStopControlSpeed_Click);
            // 
            // trkMotorSpeed
            // 
            this.trkMotorSpeed.Location = new System.Drawing.Point(6, 34);
            this.trkMotorSpeed.Maximum = 100;
            this.trkMotorSpeed.Name = "trkMotorSpeed";
            this.trkMotorSpeed.Size = new System.Drawing.Size(229, 56);
            this.trkMotorSpeed.TabIndex = 10;
            this.trkMotorSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkMotorSpeed.Scroll += new System.EventHandler(this.trkMotorSpeed_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Speed Tracking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPosition180_Click);
            // 
            // btnPositionTracking
            // 
            this.btnPositionTracking.Location = new System.Drawing.Point(186, 154);
            this.btnPositionTracking.Name = "btnPositionTracking";
            this.btnPositionTracking.Size = new System.Drawing.Size(119, 38);
            this.btnPositionTracking.TabIndex = 8;
            this.btnPositionTracking.Text = "Position Tracking";
            this.btnPositionTracking.UseVisualStyleBackColor = true;
            this.btnPositionTracking.Click += new System.EventHandler(this.btnPositionTracking_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(50, 154);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(88, 38);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw Graph";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPosition360);
            this.groupBox6.Controls.Add(this.btnPosition180);
            this.groupBox6.Controls.Add(this.btnPosition90);
            this.groupBox6.Controls.Add(this.btnPosition45);
            this.groupBox6.Location = new System.Drawing.Point(6, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(174, 122);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "POSITION";
            // 
            // btnPosition360
            // 
            this.btnPosition360.Location = new System.Drawing.Point(90, 67);
            this.btnPosition360.Name = "btnPosition360";
            this.btnPosition360.Size = new System.Drawing.Size(78, 38);
            this.btnPosition360.TabIndex = 8;
            this.btnPosition360.Text = "360°";
            this.btnPosition360.UseVisualStyleBackColor = true;
            this.btnPosition360.Click += new System.EventHandler(this.btnPosition360_Click);
            // 
            // btnPosition180
            // 
            this.btnPosition180.Location = new System.Drawing.Point(6, 67);
            this.btnPosition180.Name = "btnPosition180";
            this.btnPosition180.Size = new System.Drawing.Size(78, 38);
            this.btnPosition180.TabIndex = 8;
            this.btnPosition180.Text = "180°";
            this.btnPosition180.UseVisualStyleBackColor = true;
            this.btnPosition180.Click += new System.EventHandler(this.btnPosition180_Click);
            // 
            // btnPosition90
            // 
            this.btnPosition90.Location = new System.Drawing.Point(90, 23);
            this.btnPosition90.Name = "btnPosition90";
            this.btnPosition90.Size = new System.Drawing.Size(78, 38);
            this.btnPosition90.TabIndex = 8;
            this.btnPosition90.Text = "90°";
            this.btnPosition90.UseVisualStyleBackColor = true;
            this.btnPosition90.Click += new System.EventHandler(this.btnPosition90_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtVID);
            this.groupBox8.Controls.Add(this.txtPID);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.btnUSBConnect);
            this.groupBox8.Location = new System.Drawing.Point(249, 198);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 134);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "USB COMMUNICATION";
            // 
            // txtVID
            // 
            this.txtVID.Location = new System.Drawing.Point(79, 64);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(121, 22);
            this.txtVID.TabIndex = 2;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(79, 99);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(121, 22);
            this.txtPID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vender ID";
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(6, 21);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(197, 31);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "CONNECT";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Location = new System.Drawing.Point(249, 348);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 162);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "DI  && DO";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnOffOpto);
            this.groupBox11.Controls.Add(this.btnOnOpto);
            this.groupBox11.Location = new System.Drawing.Point(7, 90);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(208, 62);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "DO";
            // 
            // btnOffOpto
            // 
            this.btnOffOpto.Location = new System.Drawing.Point(104, 21);
            this.btnOffOpto.Name = "btnOffOpto";
            this.btnOffOpto.Size = new System.Drawing.Size(92, 36);
            this.btnOffOpto.TabIndex = 0;
            this.btnOffOpto.Text = "OFF";
            this.btnOffOpto.UseVisualStyleBackColor = true;
            this.btnOffOpto.Click += new System.EventHandler(this.btnOffOpto_Click);
            // 
            // btnOnOpto
            // 
            this.btnOnOpto.Location = new System.Drawing.Point(6, 21);
            this.btnOnOpto.Name = "btnOnOpto";
            this.btnOnOpto.Size = new System.Drawing.Size(92, 36);
            this.btnOnOpto.TabIndex = 0;
            this.btnOnOpto.Text = "ON";
            this.btnOnOpto.UseVisualStyleBackColor = true;
            this.btnOnOpto.Click += new System.EventHandler(this.btnOnOpto_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtDILow);
            this.groupBox10.Controls.Add(this.txtDIHigh);
            this.groupBox10.Location = new System.Drawing.Point(6, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(209, 63);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "DI";
            // 
            // txtDILow
            // 
            this.txtDILow.Location = new System.Drawing.Point(6, 21);
            this.txtDILow.Multiline = true;
            this.txtDILow.Name = "txtDILow";
            this.txtDILow.Size = new System.Drawing.Size(92, 26);
            this.txtDILow.TabIndex = 0;
            this.txtDILow.Text = "LOW";
            this.txtDILow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDIHigh
            // 
            this.txtDIHigh.Location = new System.Drawing.Point(104, 21);
            this.txtDIHigh.Multiline = true;
            this.txtDIHigh.Name = "txtDIHigh";
            this.txtDIHigh.Size = new System.Drawing.Size(93, 26);
            this.txtDIHigh.TabIndex = 0;
            this.txtDIHigh.Text = "HIGHT";
            this.txtDIHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox17);
            this.groupBox12.Controls.Add(this.groupBox16);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Location = new System.Drawing.Point(12, 211);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(204, 422);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "INTERFACE MONITOR";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.lstReceiveMotorPulse);
            this.groupBox17.Location = new System.Drawing.Point(9, 325);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(195, 89);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "MOTOR PULSE";
            // 
            // lstReceiveMotorPulse
            // 
            this.lstReceiveMotorPulse.FormattingEnabled = true;
            this.lstReceiveMotorPulse.ItemHeight = 16;
            this.lstReceiveMotorPulse.Location = new System.Drawing.Point(6, 24);
            this.lstReceiveMotorPulse.Name = "lstReceiveMotorPulse";
            this.lstReceiveMotorPulse.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstReceiveMotorPulse.Size = new System.Drawing.Size(176, 52);
            this.lstReceiveMotorPulse.TabIndex = 4;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.listBox1);
            this.groupBox16.Location = new System.Drawing.Point(9, 230);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(195, 89);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "MOTOR SPEED";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(176, 52);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.lstReceiveMotorPosition);
            this.groupBox14.Location = new System.Drawing.Point(9, 127);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(195, 94);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "MOTOR POSITION";
            // 
            // lstReceiveMotorPosition
            // 
            this.lstReceiveMotorPosition.FormattingEnabled = true;
            this.lstReceiveMotorPosition.ItemHeight = 16;
            this.lstReceiveMotorPosition.Location = new System.Drawing.Point(6, 24);
            this.lstReceiveMotorPosition.Name = "lstReceiveMotorPosition";
            this.lstReceiveMotorPosition.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstReceiveMotorPosition.Size = new System.Drawing.Size(176, 52);
            this.lstReceiveMotorPosition.TabIndex = 4;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.pnlLED2);
            this.groupBox13.Controls.Add(this.pnlLED1);
            this.groupBox13.Controls.Add(this.lstReceiveLEDStatus);
            this.groupBox13.Location = new System.Drawing.Point(9, 21);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(195, 100);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "LED TRACKING";
            // 
            // pnlLED2
            // 
            this.pnlLED2.Location = new System.Drawing.Point(153, 65);
            this.pnlLED2.Name = "pnlLED2";
            this.pnlLED2.Size = new System.Drawing.Size(29, 27);
            this.pnlLED2.TabIndex = 5;
            // 
            // pnlLED1
            // 
            this.pnlLED1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLED1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLED1.Location = new System.Drawing.Point(153, 24);
            this.pnlLED1.Name = "pnlLED1";
            this.pnlLED1.Size = new System.Drawing.Size(29, 28);
            this.pnlLED1.TabIndex = 5;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txt7SegLED);
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Controls.Add(this.btn7SegLED);
            this.groupBox15.Location = new System.Drawing.Point(249, 526);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(215, 107);
            this.groupBox15.TabIndex = 13;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "7 SEGMENT LED";
            // 
            // txt7SegLED
            // 
            this.txt7SegLED.Location = new System.Drawing.Point(63, 21);
            this.txt7SegLED.Multiline = true;
            this.txt7SegLED.Name = "txt7SegLED";
            this.txt7SegLED.Size = new System.Drawing.Size(146, 36);
            this.txt7SegLED.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = " Retrieve PC Timestamp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn7SegLED
            // 
            this.btn7SegLED.Location = new System.Drawing.Point(5, 21);
            this.btn7SegLED.Name = "btn7SegLED";
            this.btn7SegLED.Size = new System.Drawing.Size(53, 36);
            this.btn7SegLED.TabIndex = 2;
            this.btn7SegLED.Text = "Send";
            this.btn7SegLED.UseVisualStyleBackColor = true;
            this.btn7SegLED.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.groupBox19);
            this.groupBox18.Controls.Add(this.groupBox20);
            this.groupBox18.Location = new System.Drawing.Point(501, 494);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(433, 139);
            this.groupBox18.TabIndex = 14;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "ADC && DAC";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btnGetWeight);
            this.groupBox19.Controls.Add(this.txtGetWeight);
            this.groupBox19.Location = new System.Drawing.Point(6, 28);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(196, 98);
            this.groupBox19.TabIndex = 14;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "ADC";
            // 
            // btnGetWeight
            // 
            this.btnGetWeight.Location = new System.Drawing.Point(6, 21);
            this.btnGetWeight.Name = "btnGetWeight";
            this.btnGetWeight.Size = new System.Drawing.Size(92, 36);
            this.btnGetWeight.TabIndex = 0;
            this.btnGetWeight.Text = "Get Weight";
            this.btnGetWeight.UseVisualStyleBackColor = true;
            this.btnGetWeight.Click += new System.EventHandler(this.btnGetWeight_Click);
            // 
            // txtGetWeight
            // 
            this.txtGetWeight.Location = new System.Drawing.Point(104, 21);
            this.txtGetWeight.Multiline = true;
            this.txtGetWeight.Name = "txtGetWeight";
            this.txtGetWeight.Size = new System.Drawing.Size(86, 36);
            this.txtGetWeight.TabIndex = 1;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btnStopDAC);
            this.groupBox20.Controls.Add(this.txtDutyCycle);
            this.groupBox20.Controls.Add(this.trackBar1);
            this.groupBox20.Location = new System.Drawing.Point(213, 28);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(214, 97);
            this.groupBox20.TabIndex = 14;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "DAC";
            // 
            // btnStopDAC
            // 
            this.btnStopDAC.Location = new System.Drawing.Point(6, 57);
            this.btnStopDAC.Name = "btnStopDAC";
            this.btnStopDAC.Size = new System.Drawing.Size(92, 36);
            this.btnStopDAC.TabIndex = 2;
            this.btnStopDAC.Text = "Stop";
            this.btnStopDAC.UseVisualStyleBackColor = true;
            this.btnStopDAC.Click += new System.EventHandler(this.btnStopDAC_Click);
            // 
            // txtDutyCycle
            // 
            this.txtDutyCycle.Location = new System.Drawing.Point(104, 57);
            this.txtDutyCycle.Multiline = true;
            this.txtDutyCycle.Name = "txtDutyCycle";
            this.txtDutyCycle.Size = new System.Drawing.Size(104, 36);
            this.txtDutyCycle.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 18);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(202, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMotorSpeed)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOff_1;
        private System.Windows.Forms.Button btnOn_1;
        private System.IO.Ports.SerialPort srlCOM;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.ListBox lstReceiveLEDStatus;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLED_Tracking;
        private System.Windows.Forms.Button btnStoreLEDStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOn_2;
        private System.Windows.Forms.Button btnOff_2;
        private System.Windows.Forms.Button btnPosition45;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPosition360;
        private System.Windows.Forms.Button btnPosition180;
        private System.Windows.Forms.Button btnPosition90;
        private System.Windows.Forms.TrackBar trkMotorSpeed;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtVID;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPositionTracking;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnOffOpto;
        private System.Windows.Forms.Button btnOnOpto;
        private System.Windows.Forms.TextBox txtDIHigh;
        private System.Windows.Forms.TextBox txtDILow;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ListBox lstReceiveMotorPosition;
        private System.Windows.Forms.Panel pnlLED2;
        private System.Windows.Forms.Panel pnlLED1;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txt7SegLED;
        private System.Windows.Forms.Button btn7SegLED;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.ListBox lstReceiveMotorPulse;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button btnRampDownSpeed;
        private System.Windows.Forms.Button btnStopControlSpeed;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtDutyCycle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStopDAC;
        private System.Windows.Forms.Button btnGetWeight;
        private System.Windows.Forms.TextBox txtGetWeight;
    }
}

