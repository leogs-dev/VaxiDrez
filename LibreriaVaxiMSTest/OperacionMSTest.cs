using LibreriaVaxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxiMSTest
{
    [TestClass]
    public class OperacionMSTest
    {
        [TestMethod]
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

            Assert.AreEqual(119, resultado);

        }
    }
}
