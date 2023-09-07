using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{
    public static class ArchivoTxt
    {
        public static string path = "tickets.txt";

        /// <summary>
        /// Lee el archivo y pone como por default la carpeta mis documentos para guardarlo 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionArchivo"></exception>
        public static string LeeArchivo()
        {
            string text = "";
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.SpecialFolder.Desktop);
            Console.WriteLine(Environment.SpecialFolder.MyDocuments);

            if(File.Exists(path))
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    text = streamReader.ReadToEnd();
                }
            }
            else
            {
                throw new ExceptionArchivo("El archivo no existe");
            }

            return text;
        }

        
    }
}
