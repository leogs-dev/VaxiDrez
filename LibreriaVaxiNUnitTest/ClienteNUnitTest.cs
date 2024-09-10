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
    public class ClienteNUnitTest
    {
        [Test]
        [TestCase("Vaxi", "Drez")]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto(string nombre, string apellido)
        {
            // 1. arrange
            Cliente cliente = new Cliente();

            // 2. act
            string nombreCompleto = cliente.CrearNombreCompleto(nombre, apellido);

            // 3. Assert
            ClassicAssert.That(nombreCompleto, Is.EqualTo("Vaxi Drez"));
        }
    }
}
