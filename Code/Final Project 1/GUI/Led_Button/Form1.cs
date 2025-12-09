using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml.Linq;
using ZedGraph;
using System.Management;

namespace Led_Button
{
    public partial class Form1: Form
    {
        int Receive_Button_Status_Flag = 0;
        int LED_Tracking_Flag = 0, Pulse_Tracking_Flag = 0, Position_Tracking_Flag = 0, Get_Weight_Flag = 0;

        string RX_Data;

        public Form1()
        {
            InitializeComponent();
            String[] Baud_Rate = { "1200", "2400", "4800", "9600", "115200" };
            cmbBaudrate.Items.AddRange(Baud_Rate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCOM.DataSource = SerialPort.GetPortNames();
            cmbCOM.Text = "Undefined";
            cmbBaudrate.Text = "Undefined";

            //Initialize graph
            GraphPane myPanne = zedGraphControl1.GraphPane;
            myPanne.Title.Text = "Position Response";
            myPanne.XAxis.Title.Text = "Time";
            myPanne.YAxis.Title.Text = "Position";

            RollingPointPairList list = new RollingPointPairList(500000);

            LineItem line = myPanne.AddCurve("Position", list, Color.Red, SymbolType.None);

            myPanne.XAxis.Scale.Min = 0;
            myPanne.XAxis.Scale.Max = 1;
            myPanne.XAxis.Scale.MinorStep = 0.1;
            myPanne.XAxis.Scale.MajorStep = 0.5;

            myPanne.YAxis.Scale.Min = 0;
            myPanne.YAxis.Scale.Max = 300;
            myPanne.YAxis.Scale.MinorStep = 50;
            myPanne.YAxis.Scale.MajorStep = 100;

            zedGraphControl1.AxisChange();
        }

        double sum = 0;

        public void draw(double line_draw)
        {
            LineItem line = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (line == null)
            {
                return;
            }
            IPointListEdit list = line.Points as IPointListEdit;
            if (list == null)
            {
                return;
            }

            list.Add(sum, line_draw);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            sum += 0.0005;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((cmbCOM.Text == "Undefined") || (cmbBaudrate.Text == "Undefined"))
            {
                MessageBox.Show("Please set configuration first");
                return;
            }
                       
            if (!srlCOM.IsOpen)
            {
                btnConnect.Text = "DISCONNECT";
                srlCOM.PortName = cmbCOM.Text;
                srlCOM.BaudRate = Convert.ToInt32(cmbBaudrate.Text);
                srlCOM.Open();               
            }
            else
            {
                btnConnect.Text = "CONNECT";
                srlCOM.Close();
            }        
        }      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void btnSend_Click(object sender, EventArgs e)
        {
            String Send_Data = txtSendData.Text;
            String Send_7_Segment_LED_Data = txt7SegLED.Text;
            srlCOM.Write(Send_Data);

            Send_7_Segment_LED_Data = "0007" + Send_7_Segment_LED_Data.PadLeft(4, '0') + "011";
            srlCOM.Write(Send_7_Segment_LED_Data);
        }

        //====================RECEIVE DATA VIA COM====================//
        //===========================================================//
        //===========================================================//

        private void srlCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string RX_Data = srlCOM.ReadLine().Trim();

            //========================LED TRACKING======================//
            if (LED_Tracking_Flag == 1)
            {
                lstReceiveLEDStatus.Items.Add(RX_Data);
            }

            //==================MOTOR POSITION TRACKING=================//
            if (Position_Tracking_Flag == 1)
            {
                lstReceiveMotorPosition.Items.Add(RX_Data);
            }

            //========================DRAW GRAPH========================//
            if (Pulse_Tracking_Flag == 1)
            {
                lstReceiveMotorPulse.Items.Add(RX_Data);

                if (int.TryParse(RX_Data, out int value))
                {
                    Invoke(new MethodInvoker(() => draw(value)));
                }
            }

            //============================DI============================//
            if (RX_Data == "00080000011")
            {
                txtDILow.BackColor = Color.Aqua;
                txtDIHigh.BackColor = Color.White;
            }
            else if (RX_Data == "00080001011")
            {
                txtDILow.BackColor = Color.White;
                txtDIHigh.BackColor = Color.Aqua;
            }

            //=============================ADC==========================//
            if (Get_Weight_Flag == 1)
            {
                txtGetWeight.Text = RX_Data;
            }

            //=========================LED STATUS=======================//
            if (RX_Data == "1000")
            {
                pnlLED1.BackColor = Color.White;
            }
            else if (RX_Data == "1001")
            {
                pnlLED1.BackColor = Color.Green;
            }

            if (RX_Data == "1010")
            {
                pnlLED2.BackColor = Color.White;
            }
            else if (RX_Data == "1011")
            {
                pnlLED2.BackColor = Color.Green;
            }
        }

        //========================CONTROL LED========================//
        //===========================================================//
        //===========================================================//

        //=======================CONTROL LED 1=======================//
        private void btnOn_1_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("00000001011");

                pnlLED1.BackColor = Color.Green;
            }
        }

        private void btnOff_1_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("00000000011");

                pnlLED1.BackColor = Color.White;
            }
        }

        //=======================CONTROL LED 2=======================//
        private void btnOn_2_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("00000011011");

                pnlLED2.BackColor = Color.Green;
            }
        }

        private void btnOff_2_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("00000010011");

                pnlLED2.BackColor = Color.White;
            }
        }

        //=======================CONTROL MOTOR=======================//
        //===========================================================//
        //===========================================================//

        //======================CONTROL POSITION=====================//
        private void btnRestartMotor_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00010000011");
        }
        private void btnPosition45_Click(object sender, EventArgs e)
        {
            srlCOM.Write("0001002D011");
        }

        private void btnPosition90_Click(object sender, EventArgs e)
        {
            srlCOM.Write("0001005A011");
        }

        private void btnPosition180_Click(object sender, EventArgs e)
        {
            srlCOM.Write("000100B4011");
        }

        private void btnPosition360_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00010168011");
        }

        //=========================DRAW GRAPH========================//
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Pulse_Tracking_Flag == 0)
            {
                srlCOM.Write("00020001011");
                btnDraw.Text = "Stop";
                Pulse_Tracking_Flag = 1;
            }
            else if (Pulse_Tracking_Flag == 1)
            {
                srlCOM.Write("00020000011");
                btnDraw.Text = "Plot";
                Pulse_Tracking_Flag = 0;
            }
        }       

        //=========================TRACKING==========================//
        //===========================================================//
        //===========================================================//

        //========================LED TRACKING=======================//
        private void btnLED_Tracking_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else if (LED_Tracking_Flag == 0)
            {
                srlCOM.Write("00030001011");
                btnLED_Tracking.Text = "Stop Tracking";
                LED_Tracking_Flag = 1;
            }
            else if (LED_Tracking_Flag == 1)
            {
                srlCOM.Write("00030000011");
                btnLED_Tracking.Text = "Tracking";
                LED_Tracking_Flag = 0;
            }
        }       

        //=====================POSITION TRACKING=====================//
        private void btnPositionTracking_Click(object sender, EventArgs e)
        {
            if (Position_Tracking_Flag == 0)
            {
                srlCOM.Write("00030011011");
                btnPositionTracking.Text = "Stop";
                Position_Tracking_Flag = 1;
            }
            else if (Position_Tracking_Flag == 1)
            {
                srlCOM.Write("00030010011");
                btnPositionTracking.Text = "Position Tracking";
                Position_Tracking_Flag = 0;
            }
        }       

        //=======================SPEED TRACKING======================//


        //=======================DIGITAL OUPUT=======================//
        //===========================================================//
        //===========================================================//
        private void btnOnOpto_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00080011011");
                
        }

        private void btnOffOpto_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00080010011");
        }     

        //=======================CONTROL SPEED=======================//
        //===========================================================//
        //===========================================================//
        private void trkMotorSpeed_Scroll(object sender, EventArgs e)
        {
            string speed = trkMotorSpeed.Value.ToString("D4");
            string Speed_Data = "0004" + speed + "011";
            srlCOM.Write(Speed_Data);
        }

        private void btnStopControlSpeed_Click(object sender, EventArgs e)
        {
            srlCOM.Write("0004FFFF011");
        }

        private void btnReverseSpeed_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00041000011");
        }

        //============================DAC============================//
        //===========================================================//
        //===========================================================//
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string digital = trackBar1.Value.ToString("D4");
            string Digital_Data = "0006" + digital + "011";
            srlCOM.Write(Digital_Data);

            txtDutyCycle.Text = digital;
        }      

        private void btnStopDAC_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00060000011");
        }

        //============================ADC============================//
        //===========================================================//
        //===========================================================//
        private void btnGetWeight_Click(object sender, EventArgs e)
        {
            if (Get_Weight_Flag == 0)
            {
                srlCOM.Write("00090001011");
                btnGetWeight.Text = "Stop";
                Get_Weight_Flag = 1;
            }
            else if (Get_Weight_Flag == 1)
            {
                srlCOM.Write("00090000011");
                btnGetWeight.Text = "Position Tracking";
                Get_Weight_Flag = 0;
            }
        }
       
        //==========================EEPROM===========================//
        //===========================================================//
        //===========================================================//
        private void btnStoreLEDStatus_Click(object sender, EventArgs e)
        {
            srlCOM.Write("00050001011");
        }

        //============================USB============================//
        //===========================================================//
        //===========================================================//
        private void btnUSBConnect_Click(object sender, EventArgs e)
        {
            GetVidPidFromComPort(srlCOM.PortName);
        }

        private void GetVidPidFromComPort(string portName)
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        string name = obj["Name"]?.ToString();
                        if (name != null && name.Contains(portName)) 
                        {
                            string deviceId = obj["PNPDeviceID"]?.ToString(); 
                            if (deviceId != null)
                            {
                                // Extract VID and PID
                                var match = System.Text.RegularExpressions.Regex.Match(deviceId, @"VID_([0-9A-F]{4})&PID_([0-9A-F]{4})", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                                if (match.Success)
                                {
                                    int vidDecimal = Convert.ToInt32(match.Groups[1].Value, 16);
                                    int pidDecimal = Convert.ToInt32(match.Groups[2].Value, 16);

                                    txtVID.Text = vidDecimal.ToString();   
                                    txtPID.Text = pidDecimal.ToString();  
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not leak VID/PID:\n" + ex.Message);
            }
        }
    }
}
