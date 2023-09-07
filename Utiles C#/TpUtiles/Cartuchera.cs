using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace TpUtiles
{
    public delegate void DelegadoPrecio(string mensaje);
    public delegate void DelegadoTicket();
    public class Cartuchera<T> where T : Util
    {
        private int capacidad;
        private List<T> listaUtiles;
        public event DelegadoPrecio EventoPrecio;
        public event DelegadoTicket EventoTickets;

        public Cartuchera()
        {
            this.capacidad = 0;
            this.listaUtiles = new List<T>();
        }

        public Cartuchera(int capacidad, List<T> listaUtiles) : this()
        {
            this.capacidad = capacidad;
            this.listaUtiles = listaUtiles;
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public List<T> ListaUtiles
        {
            get { return listaUtiles; }
            set { listaUtiles = value; }
        }

        /// <summary>
        /// Propiedad que devuelve el valor del precio acumulado en la lista
        /// </summary>
        public double PrecioTotal
        {
            get { return AcumulaPrecio(this.ListaUtiles); }
         
        }

        /// <summary>
        /// Sobrecarga del operador + que lanza dos eventos uno si supera los $500 totales de la lista y otro que lanza uno para luego guardar en txt
        /// Ademas si la capacidad de la cartuchera es incrementada cada vez q se agrega un util al ser 5 o mayor a 5 lanza una excepcion
        /// </summary>
        /// <param name="cartuchera"></param>
        /// <param name="util"></param>
        /// <returns></returns>
        /// <exception cref="CartucheraLLenaException"></exception>
        public static bool operator +(Cartuchera<T> cartuchera, T util)
        {
            bool retorno = false;
            
            if (cartuchera is not null && util is not null)
            {
                if (cartuchera.Capacidad < 5)
                {
                    cartuchera.listaUtiles.Add(util);
                    cartuchera.Capacidad++;

                    if (cartuchera.PrecioTotal > 500)
                    {
                        if (cartuchera.EventoPrecio is not null && cartuchera.EventoTickets is not null)
                        {
                            cartuchera.EventoPrecio.Invoke("Evento : Se supero los $500 totales");
                            cartuchera.EventoTickets.Invoke(); 
                        }
                    }
                        retorno = true;
                }
                else
                {
                    throw new CartucheraLLenaException("La cartuchera esta llena");
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve el precio acumulado en la lista pasada por parametro
        /// </summary>
        /// <param name="listaUtiles"></param>
        /// <returns></returns>
        public double AcumulaPrecio(List<T> listaUtiles)
        {
            double precioTotal = 0;

            if (listaUtiles is not null)
            {
                foreach (T item in listaUtiles)
                {
                    precioTotal += item.Precio;
                }
            }

            return precioTotal;
        }

        /// <summary>
        /// Retorna un stringo con los datos la cartuchera dependendiendo de que tipo es el item 
        /// </summary>
        /// <param name="listaUtil"></param>
        /// <returns></returns>
        public string MuestraCartuchera(List<T> listaUtil)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de utiles : ");

            if(listaUtil is not null)
            {
                foreach(T item  in listaUtil)
                {
                    if(item is Lapiz)
                    {
                        sb.AppendLine("Util : Lapiz ");
                        sb.AppendLine(item.ToString());
                    }
                    else if(item is Goma)
                    {
                        sb.AppendLine("Util : Goma ");
                        sb.AppendLine(item.ToString());
                    }
                    else
                    {
                        sb.AppendLine("Util : Lapiz ");
                        sb.AppendLine(item.ToString());
                    }
                }
            }

            return sb.ToString();
        }
        
        
                    
    }

}


