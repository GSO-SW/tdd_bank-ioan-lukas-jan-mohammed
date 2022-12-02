using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private static int kontoNr;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get 
            { 
                return kontoNr; 
            }
        }

        public Konto(int guthaben)
        {
            if (guthaben >= 0)
            {
                this.guthaben = guthaben;
                kontoNr++;
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
