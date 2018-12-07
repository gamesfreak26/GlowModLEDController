using System.IO.Ports;

namespace LightController.Common
{
    public class SerialConn
    {
        SerialPort _serialPort;

        public void Connect(string port, int baudrate)
        {
            if (_serialPort == null)
                _serialPort = new SerialPort(port, baudrate);

            if (_serialPort.IsOpen)
                _serialPort.Close();

            _serialPort.DtrEnable = true;
            _serialPort.Open();
        }

        public void Write(LedRgb ledRgb)
        {
            _serialPort.Write(ledRgb.ToString());
        }
    }
}