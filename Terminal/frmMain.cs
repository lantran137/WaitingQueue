using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class frmMain : Form
    {
        private string[] TimCom()
        {
            return SerialPort.GetPortNames();
            
        }
        public frmMain()
        {
            InitializeComponent();
            
        }
        public frmMain(string message)
        {
            InitializeComponent();
            TimCom();
            if (!ConnectCom(message)) 
            {
                MessageBox.Show("Vui long ket noi cong COM");
            }
        }



        private bool ConnectCom(string message)
        {
            
            try
            {
                using (SerialPort port1 = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One))
                {
                    
                    if (port1.IsOpen)
                    {
                        port1.DiscardInBuffer();
                        port1.Close();
                    }
                    port1.Open();
                    byte[] b = BitConverter.GetBytes(Convert.ToInt32(message));
                    port1.Write(b, 0, 1);

                    //port1.Write(message);
                    return true;
                   

                }

            }
            catch
            {
                return false;
            }
        }

        private void miReScan_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                string[] Coms = SerialPort.GetPortNames();
                cbxCom.Items.Clear();
                for (int i = 0; i < Coms.Length; i++)
                {
                    cbxCom.Items.Add(Coms[i]);
                }

            }
            else
            {
                MessageBox.Show("Please close!!!!");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (this.UART.IsOpen)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                MessageBox.Show("Da ngat ket noi thanh cong");
                
            }
        }

        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string txt= UART.ReadExisting().ToString();
            txt += UART.ReadExisting().ToString();
            SetText(txt.ToString());
            //txbReceived.ScrollToCaret();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UART.Write(txbSending.Text);
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling threadu to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txbReceived.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
                this.txbReceived.Text = text;
            }
            else
            {
                this.txbReceived.Text = text;
            }
        }
    }
}
