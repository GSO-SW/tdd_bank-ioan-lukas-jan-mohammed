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
            int Anfangsguthaben = 100;
            int Einzahlbetrag = 10;
            int Auszahlbetrag = 10;
            int Ziehlguhaben = 120;

            //Act
            k = new Konto(Anfangsguthaben);
            for (int i = 0; i < 3; i++)
            {
                k.Einzahlen(Einzahlbetrag);
            }
            k.Auszahlen(Auszahlbetrag);

            //Assert
            Assert.AreEqual(120, Ziehlguhaben);
        }
    }
}