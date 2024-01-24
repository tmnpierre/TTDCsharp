using Exercice01.Bibliotheque;

namespace Exercice01.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [DataTestMethod]
        [DataRow(95, 90, 'A')]
        [DataRow(85, 90, 'B')]
        [DataRow(65, 90, 'C')]
        [DataRow(95, 65, 'B')]
        [DataRow(95, 55, 'F')]
        [DataRow(65, 55, 'F')]
        [DataRow(50, 90, 'F')]
        public void WhenGetGrade(int n, int j, char grade)
        {
            var calculator = new GradingCalculator
            {
                Score = n,
                AttendancePercentage = j
            };

            char result = calculator.GetGrade();

            Assert.AreEqual(grade, result);
        }
    }
}
