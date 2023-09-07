using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmDetalleCompra : Form
    {
        public bool confirma;
        static  List<string> facturas = new List<string>();
        public double precioTotal = 0;
        public FrmDetalleCompra()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Crea un string con los datos del producto de la lista con el detalle de compra
        /// </summary>
        /// <param name="listaFiltrada"></param>
        /// <param name="precio"></param>
        public FrmDetalleCompra(List<Productos> listaFiltrada, string precio) : this()
        {
            StringBuilder sb = new StringBuilder();
            double precioASumar = 0;
            sb.AppendLine("Listado de Productos : ");
            foreach (Productos p in listaFiltrada)
            {
                sb.Append(p.MostrarProducto());
                sb.AppendLine($" Cantidad : {p.Cantidad}");
            }
            sb.AppendLine($"Precio Total :{precio}");
            if (double.TryParse(precio, out precioASumar))
            {
                this.precioTotal += precioASumar;
            }

            this.lbl_ListaProductos.Text = sb.ToString();
        }

        public FrmDetalleCompra(List<Productos> listaFiltrada, string precio, List<string> listaFacturas) : this(listaFiltrada, precio)
        {
            facturas = listaFacturas;
        }

        /// <summary>
        /// Al apretar el boton aceptar genera un mensaje de venta exitosa y esconde la visibilidad del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Venta exitosa!");
            sb.AppendLine("Factura guardada");
            MessageBox.Show(sb.ToString(), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.confirma = true;
            this.Hide();
        }

        /// <summary>
        /// Al apretar el boton cancelar muestra un mensaje de venta cancelada y esconde la visibilidad del form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Venta cancelada");
            MessageBox.Show(sb.ToString(), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.confirma = false;
            this.Hide();
        }

        private void btn_HistorialFacturas_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
   
            if(facturas is not null && facturas.Any())
            {
                foreach(var item in facturas)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            MessageBox.Show(sb.ToString(), "Listado facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);         
          
        }
    }
}
