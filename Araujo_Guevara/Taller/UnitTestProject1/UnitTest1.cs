using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taller;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularSueldoUno()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 3803;//valor que se espera 3803
            int actualR;
            actualR = (int)calculo.Sueldo(350);
            Assert.AreEqual(expectedR,actualR);
        }
        [TestMethod]
        public void CalcularSueldoDos()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 10866;//sueldo esperado 10866
            int actualR;
            actualR = (int)calculo.Sueldo(1000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularSueldoTres()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 11952;//sueldo esperado 11952
            int actualR;
            actualR = (int)calculo.Sueldo(1100);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularSueldoCuatro()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 27165;//sueldo esperado 27165
            int actualR;
            actualR = (int)calculo.Sueldo(2500);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularNumerosNegativos()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 0;//el valor que espera es 0
            int actualR;
            actualR = (int)calculo.Sueldo(-2500);
            Assert.AreEqual(expectedR, actualR);
        }
        
        [TestMethod]
        public void CalcularImpuestoRan1()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 0;
            int actualR;
            actualR = (int)calculo.calcularImpueto(3803);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan2()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 35;
            int actualR;
            actualR = (int)calculo.calcularImpueto(12000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan3()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 867;
            int actualR;
            actualR = (int)calculo.calcularImpueto(15100);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan4()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 876;
            int actualR;
            actualR = (int)calculo.calcularImpueto(21000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan5()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 3483;
            int actualR;
            actualR = (int)calculo.calcularImpueto(38500);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan6()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 5549;
            int actualR;
            actualR = (int)calculo.calcularImpueto(50000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan7()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 9810;
            int actualR;
            actualR = (int)calculo.calcularImpueto(70000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan8()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 17992;
            int actualR;
            actualR = (int)calculo.calcularImpueto(100000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CalcularImpuestoRan9()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 22835;
            int actualR;
            actualR = (int)calculo.calcularImpueto(116000);
            Assert.AreEqual(expectedR, actualR);
        }
        [TestMethod]
        public void CacularNegativoRango()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 0; //el valor que espera es 0
            int actualR;
            actualR = (int)calculo.calcularImpueto(-30);
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void CacularNumeroExtenso()
        {
            CalculoImpuesto calculo = new CalculoImpuesto();
            int expectedR = 0; //el valor que espera es 0
            int actualR;
            actualR = (int)calculo.Sueldo(1234560000);
            Assert.AreEqual(expectedR, actualR);
        }

        
    }
}
