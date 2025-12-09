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

namespace Led_Button
{
    public partial class Form1: Form
    {
        int Receive_Button = 0;
        string LED_Status_Data;

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
                    btnConnect.Text = "Disconnected";
                    srlCOM.PortName = cmbCOM.Text;
                    srlCOM.BaudRate = Convert.ToInt32(cmbBaudrate.Text);
                    srlCOM.Open();
                }
                else
                {
                    btnConnect.Text = "Connected";
                    srlCOM.Close();
                }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("SONLDE");
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (!srlCOM.IsOpen)
            {
                MessageBox.Show("Please connect first");
            }
            else
            {
                srlCOM.Write("SOFLDE");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String Send_Data = txtSendData.Text;
            srlCOM.Write(Send_Data);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (Receive_Button == 0)
            {
                srlCOM.Write("GTDT");
                btnReceive.Text = "STOP RECEIVE DATA";
                Receive_Button = 1;
            }
            else
            {
                srlCOM.Write("SGDT");
                btnReceive.Text = "RECEIVE DATA";
                Receive_Button = 0;
                txtReceiveData.Text = "Receiving data not activated";
            }       
        }

        private void srlCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Receive_Button == 1)
            {
                LED_Status_Data = srlCOM.ReadExisting().Trim(); // Đọc dữ liệu & loại bỏ ký tự xuống dòng dư thừa

                if (!string.IsNullOrEmpty(LED_Status_Data)) // Kiểm tra dữ liệu hợp lệ
                {
                    this.Invoke((MethodInvoker)delegate {
                        txtReceiveData.AppendText(LED_Status_Data + Environment.NewLine); // Giữ lại dữ liệu cũ

                        lstReceiveData.Items.Add(LED_Status_Data); // Thêm vào ListBox
                    });
                }
            }
        }
    }
}
