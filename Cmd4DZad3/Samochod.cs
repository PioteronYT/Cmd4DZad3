using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd4DZad3
{
    public class Samochod : Pojazd
    {
        private int liczbaDrzwi;

        public Samochod(string marka, UInt16 rokProdukcji, int liczbaDrzwi) : base(marka, rokProdukcji)
        {
            this.liczbaDrzwi = liczbaDrzwi;
        }
        public Samochod(Samochod auto) : base(auto.marka, auto.rokProdukcji)
        {
            liczbaDrzwi = auto.liczbaDrzwi;
        }
        public override double ObliczKosztWynajmu(int dni)
        {
            return dni * 100;
        }
        public override string Opis()
        {
            return $"{marka} {rokProdukcji} {liczbaDrzwi}";
        }
    }
}
