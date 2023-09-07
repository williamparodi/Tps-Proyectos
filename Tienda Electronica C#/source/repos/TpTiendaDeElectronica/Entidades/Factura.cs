using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Factura
    {
        static int numeroFactura = 001;
       
        public static string CrearFactura(List<Productos> listaDeCompras,Cliente cliente,DateTime fechaCompra,double precioTotal)
        {
            Venta venta = new Venta();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Factura Numero : {numeroFactura++}");
            sb.AppendLine($"Fecha : {fechaCompra}");
            sb.AppendLine($"Datos Cliente : ");
            sb.AppendLine($"{cliente.MostarCliente()}");
            sb.AppendLine(venta.MostrarListaProductos(listaDeCompras));
            sb.AppendLine($"Precio Total : {precioTotal}");
            sb.AppendLine("------------------------------------------");
            return sb.ToString();
        }
    }
}
