using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd4DZad3
{
    public abstract class Pojazd
    {
        protected string marka;
        protected UInt16 rokProdukcji;

        public Pojazd(string marka, UInt16 rokProdukcji)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
        }
        public abstract double ObliczKosztWynajmu(int dni);
        public virtual string Opis()
        {
            return marka + " " + rokProdukcji;
        }
    }
}
