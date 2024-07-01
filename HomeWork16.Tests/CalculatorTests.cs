using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.Equals(6, calculator.Additional(2, 4));
        }

        [Test]
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        [Test]
        public void Division_MustReturnNotNullValue()
        {
            var calculator = new Calculator();
            Assert.Equals(2, calculator.Additional(10, 5));
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
