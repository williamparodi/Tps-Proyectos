using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpUtiles;
using Entidades;

namespace Entidades
{
    public  interface ISerializa<T> where T : Util
    {

        void SerializaLapizJson(T objeto);

        void SerializaLapizXml(string nombreArchivo, T objeto);
        
        
    }  
}
