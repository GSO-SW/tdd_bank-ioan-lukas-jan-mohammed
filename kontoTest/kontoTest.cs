using Bank;

namespace BankTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void Konto_KannMitGuthabenEr�ffnetWerden()
        {
            //Arrange
            Konto k;
            int startguthaben = 100;

            //Act
            k = new Konto(startguthaben);

            //Assert
            Assert.AreEqual(startguthaben, k.Guthaben);
        }
    }
}