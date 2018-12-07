using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using LightController.Common;

namespace LightController.Forms
{
    public partial class Form1 : Form
    {
        private SerialConn _serialConn;
        string[] _ports;
        private Color _selectedColour;

        public Form1()
        {
            InitializeComponent();
            _serialConn = new SerialConn();

            _ports = SerialPort.GetPortNames();
            cmbSerialPorts.Items.AddRange(_ports);
        }


        private void btnChooseColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var colour = colorDialog1.Color;
                _selectedColour = colour;
                picSelectedColour.BackColor = colour;
            }
        }

        private void btnSendColour_Click(object sender, EventArgs e)
        {
            var led = new LedRgb(_selectedColour.R, _selectedColour.G, _selectedColour.B);
            _serialConn.Write(led);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var selectedItem = (string) cmbSerialPorts.SelectedItem;
            if (string.IsNullOrWhiteSpace(selectedItem))
            {
                _serialConn.Connect(selectedItem, 115200);
            }
        }
    }
}
