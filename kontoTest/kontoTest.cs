using Bank;

namespace BankTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void Konto_KannMitGuthabenEröffnetWerden()
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
    }
}