using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpUtiles;

namespace Entidades
{
    public interface IDeserealiza<T> where T : Util
    {
        T DeseralizaJsonLapiz(string str);

        T DeserealizaLapizXml(string nombreDelArchivo);

   
    }
}

