using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        public int KontoNr = 0;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(int guthaben)
        {
            if (guthaben > 0)
            {
                this.guthaben = guthaben;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Einzahlen(int betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
