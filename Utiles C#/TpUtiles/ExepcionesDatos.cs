using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExepcionesDatos : Exception
    {
        public ExepcionesDatos() : base("Datos invalidos")
        {

        }
        public ExepcionesDatos(string mensaje) : base(mensaje)
        {

        }

        public ExepcionesDatos(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    
    }
}
