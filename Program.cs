using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightController
{
    class Program
    {
        static SerialPort _SerialPort;


        static void Main(string[] args)
        {
            Connect("COM5", 115200);
            
            while (true)
            {
                Console.WriteLine("Enter:  R G B.  quit to exit.");
                var input = Console.ReadLine();
                if (input == "quit") { break; }
                var i = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                SerialWrite(i[0], i[1], i[2]);
            }
        }

        public static void Connect(string port, int baudrate)
        {
            if (_SerialPort == null) 
                _SerialPort = new SerialPort(port, baudrate);
        
            if (_SerialPort.IsOpen)
                _SerialPort.Close();

            _SerialPort.DtrEnable = true;
            _SerialPort.Open();

        }

        public static void SerialWrite(int red, int green, int blue)
        {
            LEDRGB rgb = new LEDRGB(red, green, blue) ;
            _SerialPort.Write(rgb.ToString());
        }
    }
}
