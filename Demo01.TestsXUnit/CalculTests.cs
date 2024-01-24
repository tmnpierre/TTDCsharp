using Demo01.Bibliotheque;

namespace Demo01.TestsXUnit
{
    public class CalculTests //Tjrs en public
    {

        private Calcul? _calcul;

        public CalculTests()
        {
            _calcul = new Calcul();
        }

        [Fact]
        public void WhenAddition_10_30_Then_40()
        {
            // Arrange = On prepare les choses
            var calcul = new Calcul();

            // Act = On execute la fonction
            var result = calcul.Addition(10, 30);

            // Assert = Verification dans le cadre des test
            //Assert.AreEqual(40, result);
            Assert.Equal(40, result);
        }

        [Fact]
        public void WhenDivision_30_10_Then_3()
        {
            var calcul = new Calcul();

            var result = calcul.Division(30, 10);

            Assert.Equal(3, result);
        }

        [Fact]
        public void WhenDivision_By_0_Throw_DivideByZeroException()
        {
            var calcul = new Calcul();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calcul.Division(10, 0));
        }
    }
}
