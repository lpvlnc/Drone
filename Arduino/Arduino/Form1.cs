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

namespace Arduino
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GetAvailableComPorts();
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelSpeedDescription.Text = trackBarSpeed.Value.ToString();
        }

        private void GetAvailableComPorts()
        {
            Console.WriteLine("Searching available com port names");
            comboBoxCOM.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length > 0)
            {
                comboBoxCOM.Enabled = true;
                comboBoxCOM.Items.AddRange(ports);
            }
            Console.WriteLine("Search finished");
            
        }

        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCOM.SelectedIndex >= 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            labelStatusDescription.Text = "Conectando...";
            labelStatusDescription.ForeColor = Color.Coral;
            try
            {
                serial.PortName = comboBoxCOM.SelectedItem.ToString();
                serial.Open();
                serial.BaudRate = 9600;
                if (serial.IsOpen)
                {
                    labelStatusDescription.Text = "Conectado";
                    labelStatusDescription.ForeColor = Color.Green;
                    trackBarSpeed.Enabled = true;
                }
                else
                    SetDefaultValues();
            }
            catch
            {
                labelStatusDescription.Text = "Desconectado - Tempo limite excedido";
                labelStatusDescription.ForeColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
        }

        private void trackBarSpeed_MouseUp(object sender, MouseEventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.WriteLine(trackBarSpeed.Value.ToString());
            }
            else
                SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            labelStatusDescription.Text = "Desconectado";
            labelStatusDescription.ForeColor = Color.Red;
            trackBarSpeed.Value = 1000;
            trackBarSpeed.Enabled = false;
        }
    }
}
