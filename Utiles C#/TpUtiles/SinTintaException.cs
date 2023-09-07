using System;

namespace Entidades
{
    public class SinTintaException : Exception
    { 
        public SinTintaException() : base("Datos invalidos")
        {

        }

        public SinTintaException(string message) : base(message)
        {

        }

        public SinTintaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
