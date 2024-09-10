using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        [Test]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            // 1. Arrange
            // Inicializar las variables o componentes  que ejecutaran el test
            // Setearle valores a las variables antes de ejecutar la prueba

            Operacion op = new();
            int num1Test = 50;
            int num2Test = 69;

            // 2. Act
            // Ejecucion de la operacion

            int resultado = op.SumarNumeros(num1Test, num2Test);

            // 3. Assert
            // Comparacion de resultados
            // Es un componente propio del paquete UnitTest
            // Contiene un conjunto de Librerias-Operadores que permiten comparar el resultado

            ClassicAssert.AreEqual(119, resultado);

        }

        //[Test]
        //public void IsValorPar_InputNumeroImpar_ReturnFalse()
        //{
        //    Operacion op = new();
        //    int numeroImpar = 5;

        //    bool isPar = op.IsValorPar(numeroImpar);

        //    ClassicAssert.IsFalse(isPar);
        //    // Otra manera de comparar valores tipo Boolean
        //    ClassicAssert.That(isPar, Is.False);
        //}

        [Test]
        [TestCase(4)]
        [TestCase(20)]
        [TestCase(300)]
        public void IsValorPar_InputNumeroPar_ReturnTrue(int numeroPar)
        {
            // Estoy usando la variable numeroPar como parametro
            // Para asignarle un valor se utiliza la anotacion TestCase y dentro de () el valor de la variable.
            // Para testear multiples valores solo es necesario añadir cuantos TesCase sean necesarios, hara una ejecucion del metodo por cada uno.
            // Si necesito multiples parametros no es problema solo añado una coma para diferencias uno de otro. Ej. TestCase(4, 200, 'xx')
            Operacion op = new();

            bool isPar = op.IsValorPar(numeroPar);

            ClassicAssert.IsTrue(isPar);
            // Otra manera de comparar valores tipo Boolean.
            ClassicAssert.That(isPar, Is.True);
        }

        [Test]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        public bool IsValorPar_InputNumeroImpar_ReturnFalse(int numeroImpar)
        {
            Operacion op = new();

            return op.IsValorPar(numeroImpar);

        }

        [Test]
        [TestCase(2.2, 1.2)] // Result 3.4
        [TestCase(2.23, 1.24)] // Result 3.47
        public void SumarDecimal_InputDosNumeros_GetValorCorrecto(double decimal1Test, double decimal2Test)
        {
            // 1. Arrange
            // Inicializar las variables o componentes  que ejecutaran el test
            // Setearle valores a las variables antes de ejecutar la prueba

            Operacion op = new();

            // 2. Act
            // Ejecucion de la operacion

            double resultado = op.SumarDecimal(decimal1Test, decimal2Test);

            // 3. Assert
            // Cuando se ejecuta el test del metodo genera error para los testcase
            // Esto sucede debido a que los resultados pueden tener centesimas de diferencia
            // Para resolver eso se debe trabajar con un intervalo, Ej. 3.3 - 3.5, LOS RESULTADOS DENTRO DE ESE INTERVALO SERAN ACEPTADOS
            // Se ajusta indicando el valor del intervalo minimo y maximo al valor base.
            // 3.4 -> Valor Base
            // resultado -> El valor esperado
            // 0.1 -> El valor a agregar al intervalo minimo y maximo sobre el valor base, es decir: 3.3 el minimo y 3.5 el maximo.
            // Los resultados dentro del rango 3.3 y 3.5 pasan el Test.
            ClassicAssert.AreEqual(3.4, resultado, 0.1);
            // TIP: Evitar usar intervalos muy grandes, por ejemplo en vez de 0.1 poner un 2, eso no es recomendable
            // TIP: Se utilizan los intervalos mas que nada para centesimas de decimal.

        }
    }
}
