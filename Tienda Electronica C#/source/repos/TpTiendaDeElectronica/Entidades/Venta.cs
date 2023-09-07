using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Venta
    {
        protected List<Productos> listaProductos;

        /// <summary>
        /// Contructor por defecto que instancia una lista
        /// </summary>
        public Venta()
        {
            this.listaProductos = new List<Productos>();
        }

        /// <summary>
        /// Contructor con sobrecarga
        /// </summary>
        /// <param name="listaProductos"></param>
        public Venta(List<Productos> listaProductos) : this()
        {
            this.listaProductos = listaProductos;
        }

        /// <summary>
        /// Propiedad de la clase setea y retorna una lista
        /// </summary>
        public List<Productos> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        /// <summary>
        /// Crea un string con los datos de la lista de Productos
        /// </summary>
        /// <returns></returns> un string con los datos de la lista
        public virtual string MostrarListaProductos(List<Productos> lista)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de Productos: ");

            foreach (Productos p in lista)
            {
                sb.AppendLine(p.MostrarProducto());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Suma el total de los precios en la lista
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <returns></returns> double con el precio total        
        public double CalcularTotal(List<Productos> listaProductos)
        {
            double total = 0;

            if (listaProductos is not null && listaProductos.Any())//se fija q contenga elementos
            {
                foreach (Productos p in listaProductos)
                {
                    total += p.Precio;
                }
            }

            return total;
        }

        /// <summary>
        /// Calcula el %10 de incremento en el total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns> double con el total incrementado
        public double CalcularPagoConCredito(double total)
        {
            double totalCredito = 0;

            if (total > 0)
            {
                totalCredito = total * 1.10;
            }

            return totalCredito;
        }

        /// <summary>
        /// Confirma la venta fijandose que sea mayor a 0
        /// </summary>
        /// <param name="listaVenta"></param>
        /// <returns></returns> bool true si tiene mas de 0 y false si tiene 0 o menos 
        public bool ConfirmaVenta(List<Productos> listaVenta)
        {
            bool retorno = true;

            if (listaProductos is not null && listaProductos.Count > 0)
            {
                foreach (Productos producto in listaVenta)
                {
                    if (producto.Cantidad <= 0)
                    {
                        retorno = false;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Confirma y calcula el total correspondiente de acuerdo a la forma de pago especificada 
        /// </summary>
        /// <param name="formaPago"></param>
        /// <param name="listaCompras"></param>
        /// <returns></returns> double con el total 
        public double CalcularPago(string formaPago, List<Productos> listaCompras)
        {
            double subtotal = 0;
            double total = 0;

            if (formaPago != string.Empty && listaCompras is not null)
            {
                if (formaPago == "Credito")
                {
                    subtotal = CalcularTotal(listaCompras);
                    total = CalcularPagoConCredito(subtotal);
                }
                else if (formaPago == "Efectivo")
                {
                    total = CalcularTotal(listaCompras);
                }
            }

            return total;
        }

        /// <summary>
        /// Descuenta una unidad si se confirma la venta en la lista de compras
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="listaCompras"></param>
        public void DescontarUnidad(List<Productos> listaProductos, List<Productos> listaCompras)
        {
            if (listaProductos is not null && listaCompras is not null && listaProductos.Any() && listaCompras.Any())
            {

                foreach (Productos p in listaProductos)
                {
                    foreach (Productos x in listaCompras)
                    {
                        if (p == x)
                        {
                            p.Cantidad -= x.Cantidad;                    
                        }

                    }
                }

            }
        }


    }

}
