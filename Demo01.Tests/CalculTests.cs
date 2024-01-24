using Demo01.Bibliotheque;

namespace Demo01.Tests
{
    [TestClass]
    public class CalculTests //Tjrs en public
    {
        [TestMethod]
        public void WhenAddition_10_30_Then_40()
        {
            // Arrange = On prepare les choses
            var calcul = new Calcul();

            // Act = On execute la fonction
            var result = calcul.Addition(10, 30);

            // Assert = Verification dans le cadre des test
            Assert.AreEqual(40, result);
        }
    }
}
