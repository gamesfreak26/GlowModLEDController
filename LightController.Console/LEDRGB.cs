using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightController
{
    class LEDRGB
    {
        private int _ledR;
        private int _ledG;
        private int _ledB;

        public LEDRGB(int ledR, int ledG, int ledB)
        {
            _ledR = ledR;
            _ledG = ledG;
            _ledB = ledB;
        }

        public new string ToString()
        {
            return string.Format("{0} {1} {2}\n", _ledR, _ledG, _ledB);
        }
    }
}
