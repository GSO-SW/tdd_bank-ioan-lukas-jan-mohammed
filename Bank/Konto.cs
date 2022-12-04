using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private static int kontoNr = 0;
        private int aktuelleKontoNr = 0;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(int guthaben)
        {
            if (guthaben >= 0)
            {
                this.guthaben = guthaben;
                kontoNr++;
                this.aktuelleKontoNr = kontoNr;
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

        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        public int AktuelleKontoNr
        {
            get
            {
                return aktuelleKontoNr;
            }
        }
    }
}
