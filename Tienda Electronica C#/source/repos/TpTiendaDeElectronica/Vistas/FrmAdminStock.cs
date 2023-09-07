using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAdminStock : Form
    {
        private List<Productos> listaDeProductos = new List<Productos>();
        private List<Productos> listaFiltrada = new List<Productos>();
        private AdminitradorStock adminitradorStock;
        private Productos nuevoProducto = new Productos();
        public FrmAdminStock(List<Productos> listaDeProductos)
        {
            InitializeComponent();
            this.listaDeProductos = listaDeProductos;
            this.adminitradorStock = new AdminitradorStock(listaDeProductos);
        }

        /// <summary>
        /// Al cargar el form setea valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminStock_Load(object sender, EventArgs e)
        {
            this.listaDeProductos = adminitradorStock.HarcodearLista();
            this.cmb_CategoriaStock.SelectedIndex = 0;
            this.cmb_BuscarCategoriaStock.SelectedIndex = 0;
            this.dtgv_DatagridFiltrada.DataSource = null;
        }

        /// <summary>
        /// Muestra la lista en el datagrid de acuerdo a la categoria elegida en el combobox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void cmb_BuscarCategoriaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listaFiltrada = adminitradorStock.FiltrarCategoria(cmb_BuscarCategoriaStock.Text,this.listaDeProductos);
            this.dtgv_DatagridFiltrada.DataSource = this.listaFiltrada;
        }

        /// <summary>
        /// Agrega con un producto a la lista con sus campos al tocar el boton aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarStock_Click(object sender, EventArgs e)
        {

            try
            {

                List<Productos> lista = new List<Productos>();
                Productos prodClear = new Productos();
                ValidarDatosIngresados(txt_CantidadStock.Text, txt_PrecioStock.Text, txt_NombreStock.Text);
                AgregarDatosAProducto(txt_NombreStock.Text, txt_CantidadStock.Text, txt_PrecioStock.Text, cmb_BuscarCategoriaStock.Text);

                if (EnccuentraMismoNombre(this.nuevoProducto))
                {
                    foreach (Productos p in this.listaDeProductos)
                    {
                        if(p.Nombre.ToLower() == this.nuevoProducto.Nombre.ToLower())
                        {
                            MessageBox.Show("Ya hay un producto llamado igual, se modifico precio y cantidad ingresados",
                                        "Modificacion de producto en stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            p.Cantidad = int.Parse(txt_CantidadStock.Text);
                            p.Precio = double.Parse(txt_PrecioStock.Text);
                            this.nuevoProducto = prodClear;
                        }
                    }
                }
                else
                {
                    this.listaDeProductos.Add(this.nuevoProducto);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Sale del form actual y muestra el menu principal al tocar el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SalirStock_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(listaDeProductos);
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void CargarLista()
        {
            this.dtgv_DatagridFiltrada.DataSource = null;
            this.dtgv_DatagridFiltrada.DataSource = this.listaFiltrada;
        }

        public void ValidarDatosIngresados(string cantidad, string precio, string nombre)
        {
            try
            {
                if (cantidad == string.Empty)
                {
                    throw new ExepcionesPropias("Cantidad no ingresada");
                }
                else if (precio == string.Empty)
                {
                    throw new ExepcionesPropias("Precio no ingresado");
                }
                else if (nombre == string.Empty)
                {
                    throw new ExepcionesPropias("Nombre no ingresado");
                }
                int.Parse(cantidad);
                double.Parse(precio);
            }
            catch (FormatException ex)
            {
                throw new ExepcionesPropias("Dato no valido", ex);
            }
            catch (Exception ex)
            {
                throw new ExepcionesPropias(ex.Message);
            }
        }

        public void AgregarDatosAProducto(string nombre, string cantidad, string precio, string categoria)
        {

            AgregarNombre(nombre);
            AgregarCantidad(cantidad);
            AgregarPrecio(precio);

            switch (categoria)
            {
                case "Mother":
                    this.nuevoProducto.Categoria = ECategorias.Mother;
                    break;
                case "Microprocesador":
                    this.nuevoProducto.Categoria = ECategorias.Microprocesador;
                    break;
                case "Perisfericos":
                    this.nuevoProducto.Categoria = ECategorias.Perisfericos;
                    break;
                case "Gabinete":
                    this.nuevoProducto.Categoria = ECategorias.Gabinete;
                    break;
                case "Monitor":
                    this.nuevoProducto.Categoria = ECategorias.Monitor;
                    break;
                default:
                    break;
            }

        }

        public void AgregarNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nuevoProducto.Nombre = nombre;
            }

        }

        /// <summary>
        /// Agrega una cantidad y valida que no sea una cadena vacia al atributo de producto
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns> Producto
        public void AgregarCantidad(string cantidad)
        {
            int cantidadASumar = 0;

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (int.TryParse(cantidad, out cantidadASumar))
                {
                    this.nuevoProducto.Cantidad = cantidadASumar;
                }
            }
        }

        /// <summary>
        /// Agrega un precio al preducto y valida que no sea una cadena vacia y que sea un numero
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns> Producto
        public void AgregarPrecio(string precio)
        {
            double precioASumar = 0;

            if (!string.IsNullOrEmpty(precio))
            {
                if (double.TryParse(precio, out precioASumar))
                {
                    this.nuevoProducto.Precio = precioASumar;
                }
            }

        }

        public bool EnccuentraMismoNombre(Productos producto)
        {
            bool retorno = false;

            foreach (Productos p in this.listaDeProductos)
            {
                if (p.Nombre.ToLower() == producto.Nombre.ToLower())
                {
                    retorno = true;
                }

            }

            return retorno;
        }

        private void btn_ComprarPorductos_Click(object sender, EventArgs e)
        {
            FrmComprarPorductos frmComprar = new FrmComprarPorductos(listaDeProductos);
            frmComprar.Show();
        }
    }

}
