using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscapeRoom;

namespace CalculadoraTests
{
    [TestClass]
    public class OperacionesTest
    {
        [TestMethod]
        public void TestSuma()
        {
            int valor1 = 7;
            int valor2 = 5;
            int expected = 12;

            Operaciones calculadora = new Operaciones();

            int actual = calculadora.Suma(valor1, valor2);

            Assert.AreEqual(expected, actual, 0, "El resultado de la suma no es correcto");
        }

        [TestMethod]
        public void TestSumaNegativos()
        {
            int valor1 = -7;
            int valor2 = 5;
            int expected = -2;

            Operaciones calculadora = new Operaciones();

            int actual = calculadora.Suma(valor1, valor2);

            Assert.AreEqual(expected, actual, 0, "El resultado de la suma no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TestDivisonEnCero()
        {
            int valor1 = 5;
            int valor2 = 0;

            Operaciones calculadora = new Operaciones();

            int actual = calculadora.Division(valor1, valor2);
        }
    }
}
