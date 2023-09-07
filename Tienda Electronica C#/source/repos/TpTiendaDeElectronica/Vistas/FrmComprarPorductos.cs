using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmComprarPorductos : Form
    {
        private Proveedor proveedor;
        private List<Productos> listaStock;
        private List<Productos> listaCarro;
        private int fila;
        public FrmComprarPorductos()
        {
            InitializeComponent();
            this.proveedor = new Proveedor();
            this.listaStock = new List<Productos>();
            this.listaCarro = new List<Productos>();
        }

        public FrmComprarPorductos(List<Productos> listaStock) : this()
        {
            this.listaStock = listaStock;
        }

        private void cmb_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.proveedor = proveedor.EligeProveedor(cmb_Proveedores.Text);
            this.dgtv_ListaProductos.DataSource = null;
            this.dgtv_ListaProductos.DataSource = proveedor.ListaProductos;
        }

        private void dgtv_ListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.fila = e.RowIndex;
            if (fila != -1)
            {
                if (proveedor.ListaProductos[fila].Cantidad > 0)
                {
                    AgregarAlCarro(proveedor.ListaProductos[fila]);
                }
                else
                {
                    MessageBox.Show("Ese producto no tiene stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        private void AgregarAlCarro(Productos producto)
        {
            Productos auxProducto = new Productos();
            bool flag = false;

            auxProducto.Nombre = producto.Nombre;
            auxProducto.Categoria = producto.Categoria;
            auxProducto.Precio = producto.Precio;

            foreach (Productos p in this.listaCarro)
            {
                if (p.Nombre == auxProducto.Nombre)
                {
                    p.Cantidad++;
                    p.Precio += auxProducto.Precio;
                    flag = true;
                }
            }
            if (!flag)
            {
                auxProducto.Cantidad = 1;
                this.listaCarro.Add(auxProducto);
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.dgtv_Carro.DataSource = null;
            this.dgtv_Carro.DataSource = listaCarro;
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if(this.listaCarro is not null)
            {
                foreach(Productos p in listaCarro)
                {
                    this.listaStock.Add(p);
                }
                FrmAdminStock frmAdminStock = new FrmAdminStock(listaStock);
                frmAdminStock.Show();
                this.Hide();
            }
            
        }
    }
}
