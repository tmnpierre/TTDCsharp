using Exercice01.Bibliotheque;


namespace Exercice01.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void GetGrade_With95ScoreAnd90Attendance_ShouldReturnA()
        {
            var calculator = new GradingCalculator
            {
                Score = 95,
                AttendancePercentage = 90
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('A'));
        }

        [Test]
        //- Score : 85%, Présence : 90 => Note: B
        public void GetGrade_With85ScoreAnd90Attendance_ShouldReturnB()
        {
            var calculator = new GradingCalculator
            {
                Score = 85,
                AttendancePercentage = 90
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('B'));
        }

        [Test]
        //- Score : 65%, Présence : 90 => Note: C
        public void GetGrade_With65ScoreAnd90Attendance_ShouldReturnC()
        {
            var calculator = new GradingCalculator
            {
                Score = 65,
                AttendancePercentage = 90
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('C'));
        }
        [Test]
        //- Score : 95%, Présence : 65 => Note: B
        public void GetGrade_With95ScoreAnd65Attendance_ShouldReturnB()
        {
            var calculator = new GradingCalculator
            {
                Score = 95,
                AttendancePercentage = 65
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('B'));
        }
        [Test]
        // - Score : 95%, Présence : 55 => Note: F
        public void GetGrade_With95ScoreAnd55Attendance_ShouldReturnF()
        {
            var calculator = new GradingCalculator
            {
                Score = 95,
                AttendancePercentage = 55
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('F'));
        }
        [Test]
        //- Score : 65%, Présence : 55 => Note: F
        public void GetGrade_With65ScoreAnd55Attendance_ShouldReturnF()
        {
            var calculator = new GradingCalculator
            {
                Score = 65,
                AttendancePercentage = 55
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('F'));
        }
        [Test]
        //- Score : 50%, Présence : 90 => Note: F
        public void GetGrade_With50ScoreAnd90Attendance_ShouldReturnF()
        {
            var calculator = new GradingCalculator
            {
                Score = 50,
                AttendancePercentage = 90
            };

            char result = calculator.GetGrade();

            Assert.That(result, Is.EqualTo('F'));
        }
    }
}
