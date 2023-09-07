using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        private List<Productos> listaDeProductos;
        public FrmMenuPrincipal(List<Productos> listaDeProductos)
        {
            InitializeComponent();
            this.listaDeProductos = listaDeProductos;
        }

        /// <summary>
        ///Al apretar el boton venta despliesga el form venta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_venta_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta(listaDeProductos);
            frmVenta.Show();
            this.Hide();
        }

        /// <summary>
        /// Al apretar el boton administrador de stock despliega el form administrador de stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            FrmAdminStock frmAdminStock = new FrmAdminStock(listaDeProductos);
            frmAdminStock.Show();
            this.Hide();
        }
    }
}
