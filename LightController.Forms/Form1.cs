using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using LightController.Common;

namespace LightController.Forms
{
    public partial class Form1 : Form
    {
        private readonly SerialConn _serialConn;
        readonly string[] _ports;
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
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            var colour = colorDialog1.Color;
            SetCurrentColour(colour);
        }

        private void btnSendColour_Click(object sender, EventArgs e)
        {
            var led = new LedRgb(_selectedColour.R, _selectedColour.G, _selectedColour.B);
            _serialConn.Write(led);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var selectedItem = (string) cmbSerialPorts.SelectedItem;
            if (!string.IsNullOrWhiteSpace(selectedItem))
            {
                _serialConn.Connect(selectedItem, 115200);
                btnChooseColour.Enabled = true;
                btnSendColour.Enabled = true;
                this.Text = "Electra Colour Picker - Connected";
            }
        }

        private void cmbSerialPorts_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = (string)cmbSerialPorts.SelectedItem;
            btnConnect.Enabled = string.IsNullOrWhiteSpace(selectedItem);
        }

        private void SetCurrentColour(Color colour)
        {
            pbPrev5.BackColor = pbPrev4.BackColor;
            pbPrev4.BackColor = pbPrev3.BackColor;
            pbPrev3.BackColor = pbPrev2.BackColor;
            pbPrev2.BackColor = pbPrev1.BackColor;
            pbPrev1.BackColor = picSelectedColour.BackColor;

            _selectedColour = colour;
            picSelectedColour.BackColor = colour;
        }

        private void pbPrev1_Click(object sender, EventArgs e)
        {
            SetCurrentColour(pbPrev1.BackColor);
        }

        private void pbPrev2_Click(object sender, EventArgs e)
        {
            SetCurrentColour(pbPrev2.BackColor);
        }

        private void pbPrev3_Click(object sender, EventArgs e)
        {
            SetCurrentColour(pbPrev3.BackColor);
        }

        private void pbPrev4_Click(object sender, EventArgs e)
        {
            SetCurrentColour(pbPrev4.BackColor);
        }

        private void pbPrev5_Click(object sender, EventArgs e)
        {
            SetCurrentColour(pbPrev5.BackColor);
        }
    }
}
