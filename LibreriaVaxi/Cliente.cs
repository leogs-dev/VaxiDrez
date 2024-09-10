using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    public class Cliente
    {
        public string CrearNombreCompleto(string nombre, string apellido)
        {
            return $"{nombre} {apellido}";
        }
    }
}
