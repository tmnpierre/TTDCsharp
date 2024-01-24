using Exercice01.Bibliotheque;
using Xunit;

namespace Exercice01.Tests
{
    public class Class1Tests
    {
        [Theory]
        [InlineData(95, 90, 'A')]
        [InlineData(85, 90, 'B')]
        [InlineData(65, 90, 'C')]
        [InlineData(95, 65, 'B')]
        [InlineData(95, 55, 'F')]
        [InlineData(65, 55, 'F')]
        [InlineData(50, 90, 'F')]
        public void WhenGetGrade(int n, int j, char grade)
        {
            var calculator = new GradingCalculator
            {
                Score = n,
                AttendancePercentage = j
            };

            char result = calculator.GetGrade();

            Assert.Equal(grade, result);
        }
    }
}