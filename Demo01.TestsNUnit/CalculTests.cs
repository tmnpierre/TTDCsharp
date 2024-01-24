using Demo01.Bibliotheque;

namespace Demo01.TestsNUnit
{
    [TestFixture]
    public class CalculTests //Tjrs en public
    {
        [Test]
        public void WhenAddition_10_30_Then_40()
        {
            // Arrange = On prepare les choses
            var calcul = new Calcul();

            // Act = On execute la fonction
            var result = calcul.Addition(10, 30);

            // Assert = Verification dans le cadre des test
            //Assert.AreEqual(40, result);
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void WhenDivision_30_10_Then_3()
        {
            var calcul = new Calcul();

            var result = calcul.Division(30, 10);

            //Assert.AreEqual(3, result);
            Assert.That(result, Is.EqualTo(3));    
        }

        [Test]
        public void WhenDivision_By_0_Throw_DivideByZeroException()
        {
            var calcul = new Calcul();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calcul.Division(10, 0));
        }
    }
}
