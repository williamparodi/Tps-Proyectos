using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionArchivo : Exception
    {
        public ExceptionArchivo() :base("Datos invalidos")
        {

        }
        public ExceptionArchivo(string mensaje) : base(mensaje)
        {

        }

        public ExceptionArchivo(string mensaje,Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
