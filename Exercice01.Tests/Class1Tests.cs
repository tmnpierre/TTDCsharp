using Exercice01.Bibliotheque;


namespace Exercice01.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        private GradingCalculator _gradingCalculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _gradingCalculator = new GradingCalculator();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _gradingCalculator = null;
        }

        [Test]
        //- Score : 95%, Présence : 90 => Note: A

        [Test]
        //- Score : 85%, Présence : 90 => Note: B

        [Test]
        //- Score : 65%, Présence : 90 => Note: C

        [Test]
        //- Score : 95%, Présence : 65 => Note: B

        [Test]
        // - Score : 95%, Présence : 55 => Note: F

        [Test]
        //- Score : 65%, Présence : 55 => Note: F

        [Test]
        //- Score : 50%, Présence : 90 => Note: F
    }
}
