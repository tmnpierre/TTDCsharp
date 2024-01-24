using Demo01.Bibliotheque;

namespace Demo01.TestsNUnit
{

    [TestFixture]
    public class CalculTests //Tjrs en public
    {
        private Calcul? _calcul;

        // fonctionne aussi mais pas recommandé pour NUnit et MSTest
        //public CalculTest()
        //{
        //    _calcul = new();
        //}

        [OneTimeSetUp]// s'exécutera UNE FOIS AVANT TOUT LES TEST
        public void OneTimeSetUp()
        {
            _calcul = new Calcul();
        }

        [OneTimeTearDown]  // s'exécutera UNE FOIS APRES TOUT LES TEST
        public void OneTimeTearDown()
        {
            _calcul = null;
        }

        [SetUp] // s'exécutera AVANT CHAQUE TEST
        public void SetUp()
        {
            _calcul = new Calcul();
        }

        [TearDown]  // s'exécutera APRES CHAQUE TEST
        public void TearDown()
        {
            _calcul = null;
        }

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
