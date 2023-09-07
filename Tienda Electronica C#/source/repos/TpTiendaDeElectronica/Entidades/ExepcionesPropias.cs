using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExepcionesPropias : Exception
    {
        public ExepcionesPropias() : base("Datos invalidos")
        {

        }
        public ExepcionesPropias(string mensaje) : base(mensaje)
        {

        }

        public ExepcionesPropias(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

       
    }
}
