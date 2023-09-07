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
    public partial class FrmLogin : Form
    {
        private Vendedor vendedor = new Vendedor();
        private Dueño dueño = new Dueño();
        private Contador contador = new Contador();
        private AdminitradorStock administradorStock = new AdminitradorStock();
        private List<Productos> listaDeProductos;
        private List<Productos> listaProductosVendidos;
        private List<Productos> listaActualizada;
        private double gananciaTotal;
        private int cantidadVentas;
        static bool flag = false;
        public FrmLogin()
        {
            InitializeComponent();
            this.listaDeProductos = administradorStock.HarcodearLista();///la hardcodeo aca para y la voy pasando
            this.cantidadVentas = 0;
            this.gananciaTotal = 0;
            this.listaProductosVendidos = new List<Productos>();
            this.listaActualizada = new List<Productos>();
        }

        public FrmLogin(List<Productos> listaProductosVendidos,int cantidadVentas,double gananciaTotal) : this()
        {
            this.listaProductosVendidos = listaProductosVendidos;
            this.cantidadVentas = cantidadVentas;
            this.gananciaTotal = gananciaTotal;
        }

        public FrmLogin(List<Productos> listaProductosVendidos, int cantidadVentas, double gananciaTotal, List<Productos> listaActualizada) : this(listaProductosVendidos,cantidadVentas,gananciaTotal)
        {
            this.listaActualizada = listaActualizada;
        }


        /// <summary>
        /// Al apretar el boton login se fija que sea correcto el usuario y contraseña y dependiendo del usuario se
        /// despliegan diferentes forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {  
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usuario o contraseña erronea");

            if (cmb_Usuario.Text == vendedor.GetUsuario() && txt_Password.Text == vendedor.GetPassword())
            {
                if(!flag)
                {
                    FrmVenta venta = new FrmVenta(listaDeProductos);
                    venta.Show();
                    this.Hide();
                    flag = true;
                }
                else
                {
                    FrmVenta venta = new FrmVenta(listaActualizada);
                    venta.Show();
                    this.Hide();
                }
                
            }
            else if(cmb_Usuario.Text == dueño.GetUsuario() && txt_Password.Text == dueño.GetPassword())
            {
                if(!flag)
                {
                    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(listaDeProductos);
                    frmMenuPrincipal.Show();
                    this.Hide();
                    flag= true;
                }
                else
                {
                    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(listaActualizada);
                    frmMenuPrincipal.Show();
                    this.Hide();
                }
                
            }
            else if (cmb_Usuario.Text == contador.GetUsuario() && txt_Password.Text == contador.GetPassword())
            {
                FrmEstadisticas frmEstadisticas = new FrmEstadisticas(listaProductosVendidos, cantidadVentas, gananciaTotal,listaActualizada);
                frmEstadisticas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(sb.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmb_Usuario.Text = "Ingrese Usuario";
                this.txt_Password.Text = string.Empty;
            }

        }

        /// <summary>
        /// Obtiene los datos ingresados de pass en los text box de usuario y password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Password_Click(object sender, EventArgs e)
        {
            if(cmb_Usuario.Text == vendedor.GetUsuario())
            {
                txt_Password.Text = vendedor.GetPassword();
            }
            else if(cmb_Usuario.Text == dueño.GetUsuario())
            {
                txt_Password.Text = dueño.GetPassword();
            }
            else if(cmb_Usuario.Text == contador.GetUsuario())
            {
                txt_Password.Text = contador.GetPassword();
            }
            else
            {
                this.txt_Password.Text = string.Empty;
            }
    
        }
    }
}
