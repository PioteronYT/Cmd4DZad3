using Cmd4DZad3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Samochod samochod = new Samochod("BMW", 2020, 10);
            double wartoscOczekiwana = 500;
            int iloscDni = 5;
            //Act
            double wynik = samochod.ObliczKosztWynajmu(iloscDni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }
    }
}