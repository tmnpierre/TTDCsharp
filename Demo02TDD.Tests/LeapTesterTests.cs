using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02TDD.Core;

namespace Demo02TDD.Tests
{
    [TestClass]
    public class LeapTesterTests
    {
        [DataTestMethod]
        [DataRow(1200)]
        [DataRow(400)]
        public void TestLeap_400_ShouldBe_True(int year)
        {
            LeapTester tester = new LeapTester();

            bool result = tester.IsLeap(year);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(12)]
        [DataRow(404)]
        public void TestLeap_4_Not_100_ShouldBe_True(int year)
        {
            LeapTester tester = new LeapTester();

            bool result = tester.IsLeap(year);

            Assert.IsTrue(result);
        }
    }
}
