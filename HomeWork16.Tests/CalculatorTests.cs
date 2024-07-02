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

            Assert.That(calculator.Additional(2, 4) == 6);
        }

        [Test]
        public void c_MustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(12, 7) == 5);
        }

        [Test]
        public void Miltiplication_MustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(3, 4) == 12);
        }

        [Test]
        public void Division_MustReturnNotNullValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(10, 5) == 2);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(150, 0));
        }
    }
}
