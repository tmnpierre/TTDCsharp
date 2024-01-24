using Exercice01.Bibliotheque;


namespace Exercice01.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        [TestCase(95, 90, "A")]
        [TestCase(85, 90, "B")]
        [TestCase(65, 90, "C")]
        [TestCase(95, 65, "B")]
        [TestCase(95, 55, "F")]
        [TestCase(65, 55, "F")]
        [TestCase(50, 90, "F")]
        public void WhenGetGrade(int n, int j, char grade)
        {
            var calculator = new GradingCalculator
            {
                Score = n,
                AttendancePercentage = j
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo(grade));
        }
    }
}