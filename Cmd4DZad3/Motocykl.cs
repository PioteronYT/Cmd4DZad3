using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd4DZad3
{
    public class Motocykl : Pojazd
    {
        private bool czyZabytkowy;

        public Motocykl(string marka, UInt16 rokProdukcji, bool czyZabytkowy) : base(marka, rokProdukcji)
        {
            this.czyZabytkowy = czyZabytkowy;
        }
        public Motocykl(Motocykl motocykl) : base(motocykl.marka, motocykl.rokProdukcji)
        {
            czyZabytkowy = motocykl.czyZabytkowy;
        }
        public override double ObliczKosztWynajmu(int dni)
        {
            return czyZabytkowy ? 70 * dni * 1.2 : 70 * dni;
        }
        public override string Opis()
        {
            return $"{marka} {rokProdukcji} {czyZabytkowy}";
        }
    }
}
