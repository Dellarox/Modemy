using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModemKraKor
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();
        bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadExisting();
            if(data.Contains("CON"))
            {
                isConnected = true;
                show("Połączenie udane.");
            }
            show(data + "\n");
        }

        void show(string data)
        {
            SetText(data.ToString());
            //SetSelection(textBoxTerminal.TextLength);
            //textBoxTerminal.ScrollToCaret();
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxTerminal.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxTerminal.Text += text;
            }
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                port.PortName = "COM1";
                port.Parity = Parity.None;
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.RequestToSend;
                port.DataReceived += dataReceived;
                port.RtsEnable = true;
                port.DtrEnable = true;

                port.WriteTimeout = 100;
                port.ReadTimeout = 100;

                port.Open();
                show("Nawiązanie połączenia." + Environment.NewLine);
                labelInfo.Text = "Połączono."; 
            }
        }

        private void buttonStopConnection_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("ATH\r");
                port.Close();
                labelInfo.Text = "Brak połączenia.";
            }
        }

    

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                if (isConnected)
                {
                    show("Tryb komend");
                    port.Write("+");
                    Thread.Sleep(100);
                    port.Write("+");
                    Thread.Sleep(100);
                    port.Write("+");
                    Thread.Sleep(100);
                }
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write(textBoxSendMessage.Text + "\r");
            }
        }

        private void textBoxSendMessage_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxSendMessage_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
