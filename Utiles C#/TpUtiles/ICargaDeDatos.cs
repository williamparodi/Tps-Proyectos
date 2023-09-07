using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ICargaDeDatos
    {
        List<string> CargaTipo(string texto);

        List<string> CargaColor(string texto);
        List<string> CargaTamanio(string texto);
    }
}
