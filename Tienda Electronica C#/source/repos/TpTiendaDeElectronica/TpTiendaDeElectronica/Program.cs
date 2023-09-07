using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace TpTiendaDeElectronica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Proyecto de consola para pruebas
            AdminitradorStock adm = new AdminitradorStock();
            List<Productos> lista = new List<Productos>();
            List<string> lista2 = new List<string>();
           
            lista = adm.HarcodearLista();
            Productos producto = new Productos(ECategorias.Microprocesador, "Ryzen 5", 545555, 555);
            lista.Add(producto);
            string nombreMasRepe = "";
           

            foreach (Productos p in lista)
            {
                lista2.Add(p.Nombre);
            }
                foreach (var item in lista2.GroupBy(x => x))
                {
                    //Console.WriteLine($"{item.Key} encontrado {item.Count()} veces");
                }

            nombreMasRepe = lista2.First();
            Console.WriteLine($"{nombreMasRepe}");



        }
    }
}
