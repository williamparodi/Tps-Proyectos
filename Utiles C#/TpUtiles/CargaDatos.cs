using System.Collections.Generic;

namespace Entidades
{
    public static class CargaDatos 
    {
        /// <summary>
        /// Devuelve una lista de strings cargada con los tipos de util dependiendo del texto ingresado
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// <exception cref="ExepcionesDatos"></exception>
        public static List<string> CargaTipo(string texto)
        {
            List<string> listaTipo = new List<string>();
            if (!string.IsNullOrEmpty(texto))
            {
                if (texto == "Lapiz")
                {
                    listaTipo.Add("Normal");
                    listaTipo.Add("Grafito");
                }
                else if (texto == "Goma")
                {
                    listaTipo.Add("ParaLapiz");
                    listaTipo.Add("ParaTinta");
                }
                else if (texto == "Sacapunta")
                {
                    listaTipo.Add("Portatil");
                    listaTipo.Add("Electrico");
                }
            }
            else
            {
                throw new ExepcionesDatos("Datos mal ingresados");
            }

            return listaTipo;
        }

        /// <summary>
        /// Devulve una lista de strings con los colores cargados si el texto es "Lapiz"
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// <exception cref="ExepcionesDatos"></exception>
        public static List<string> CargaColor(string texto)
        {
            List<string> listaColor = new List<string>();
            if (!string.IsNullOrEmpty(texto))
            {
                if (texto == "Lapiz")
                {
                    listaColor.Add("Amarillo");
                    listaColor.Add("Negro");
                    listaColor.Add("Azul");
                    listaColor.Add("Rojo");
                }
            }
            else
            {
                throw new ExepcionesDatos("Dato mal ingresado");
            }

            return listaColor;
        }

        /// <summary>
        /// Devuelve una lista de strings con los tamanios cargados si el texto es "Goma"
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// <exception cref="ExepcionesDatos"></exception>
        public static List<string> CargaTamanio(string texto)
        {
            List<string> listaTamanio = new List<string>();
            if (!string.IsNullOrEmpty(texto))
            {
                if (texto == "Goma")
                {
                    listaTamanio.Add("Numero1");
                    listaTamanio.Add("Numero2");
                    listaTamanio.Add("Numero3");
                }
            }
            else
            {
                throw new ExepcionesDatos("Dato mal ingresado");
            }

            return listaTamanio;
        }
        
    }
}
