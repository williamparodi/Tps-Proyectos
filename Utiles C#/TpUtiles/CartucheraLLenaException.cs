using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraLLenaException : Exception
    {
        public CartucheraLLenaException() : base("Datos Invalidos")
        {

        }

        public CartucheraLLenaException(string mensaje) : base(mensaje)
        {

        }

        public CartucheraLLenaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
