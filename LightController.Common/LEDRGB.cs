namespace LightController.Common
{
    public class LedRgb
    {
        private readonly int _ledR;
        private readonly int _ledG;
        private readonly int _ledB;

        public LedRgb(int ledR, int ledG, int ledB)
        {
            _ledR = ledR;
            _ledG = ledG;
            _ledB = ledB;
        }

        public new string ToString()
        {
            return $"{_ledR} {_ledG} {_ledB}\n";
        }
    }
}
