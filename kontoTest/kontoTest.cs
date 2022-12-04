using Bank;

namespace BankTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void Konto_KannMitGuthabenEroeffnetWerden()
        {
            //Arrange
            Konto k;
            int startguthaben = 100;

            //Act
            k = new Konto(startguthaben);

            //Assert
            Assert.AreEqual(startguthaben, k.Guthaben);
        }
        [TestMethod]
        public void Konto_KannBuchungenVornehmen()
        {
            //Arrange 
            Konto k;
            int anfangsguthaben = 100;
            int einzahlbetrag = 10;
            int auszahlbetrag = 10;
            int zielguhaben = 120;

            //Act
            k = new Konto(anfangsguthaben);
            for (int i = 0; i < 3; i++)
            {
                k.Einzahlen(einzahlbetrag);
            }
            k.Auszahlen(auszahlbetrag);

            //Assert
            Assert.AreEqual(120, zielguhaben);
        }
        [TestMethod]
        public void Konto_KannGeschlossenWerden()
        {
            //Arrange 
            Konto k;
            int guthaben = 100;

            //Act
            k = new Konto(guthaben);
            k.Auszahlen(guthaben);

            //Assert
            Assert.AreEqual(0, k.Guthaben);
        }


        //Neue Aufgabe_______________________________________________________


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_KannNichtMitNegativemBetragErstelltWerden()
        {
            // Arrange
            int guthaben = -1;
            // Act
            Konto k = new Konto(guthaben);
        }

        [TestMethod]
        public void KontoNr_KannAbgefragtWerden()
        {
            // Arrange
            Konto k = new Konto(0);
            int nummer_soll = 4;
            // Act
            int nummer_ist = k.KontoNr;
            //Arrange
            Assert.AreEqual(nummer_soll, nummer_ist);
        }

        [TestMethod]
        public void KontoNr_WirdAutomatischVergeben()
        {
            // Arrange
            Konto k1 = new Konto(0);
            Konto k2 = new Konto(0);
            Konto k3 = new Konto(0);
            int kontoNummer_soll = 7;
            // Act
            int kontoNummer_ist = k3.KontoNr;
            // Assert
            Assert.AreEqual(kontoNummer_soll, kontoNummer_ist);
        }

    }
}