using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCode
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Suma_CaminoFeliz()
        {
            // Arrange (Organizar/Inicializa)
            int a = 4;
            int b = 5;
            int Espero = 9;
            // Act (Actuar)
            int actual = UnitTest.Calcular.Suma(a, b);
            // Assert (Confirmar/Comprobar)
            Assert.AreEqual(Espero, actual);
        }

        [DataRow(4, 5, 9)]
        [DataRow(5, 5, 10)]
        [DataRow(1, 1, 2)]
        [TestMethod]
        public void Suma_CaminoFeliz(int a, int b, int Espero)
        {
            // Arrange (Organizar/Inicializa)

            // Act (Actuar)
            int actual = UnitTest.Calcular.Suma(a, b);
            // Assert (Confirmar/Comprobar)
            Assert.AreEqual(Espero, actual);
        }

        //[TestMethod]
        //public void Suma_TestCaminoMalo()
        //{
        //}
    }
}


// Arrange (Organizar/Inicializa)
// Act (Actuar)
// Assert (Confirmar/Comprobar)
