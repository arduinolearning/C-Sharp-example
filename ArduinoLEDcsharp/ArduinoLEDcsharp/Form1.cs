using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoLEDcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //the COM port of my Arduino
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 9600;
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
        }


    }
}
