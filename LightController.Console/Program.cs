using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using LightController.Common;

namespace LightController
{
    class Program
    {
        static void Main(string[] args)
        {
            var serialConn = new SerialConn();

            serialConn.Connect("COM5", 115200);
            var hexRegex = new Regex("/^#[0-9a-f]{3,6}$/i");

            while (true)
            {
                Console.WriteLine("Enter:  R G B.  quit to exit. " );
                var input = Console.ReadLine();
                if (input == "quit") { break; }
                if (input.First() == '#')
                {
                    var r = int.Parse(input.Substring(1, 2), NumberStyles.HexNumber);
                    var b = int.Parse(input.Substring(3, 2), NumberStyles.HexNumber);
                    var g = int.Parse(input.Substring(5, 2), NumberStyles.HexNumber);
                    input = $"{r} {b} {g}";
                }

                var i = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                serialConn.Write(new LedRgb(i[0], i[1], i[2]));
            }
        }
    }
}
