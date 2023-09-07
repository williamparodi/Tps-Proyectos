using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TpUtiles;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Vista
{
    public partial class FrmBaseDeDatos : Form
    {
        CancellationTokenSource tokenSource;
        CancellationToken token;
        Bitmap imageBorrar = new Bitmap(@"C:\Users\Willy\source\repos\TpUtiles\Vista\Resources\Trash_can_opens.gif");
        Bitmap imageAgregar = new Bitmap(@"C:\Users\Willy\source\repos\TpUtiles\Vista\Resources\red-01.gif");
        public FrmBaseDeDatos()
        {
            tokenSource= new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            InitializeComponent();
            
        }

        /// <summary>
        /// Evento de carga de form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseDeDatos_Load(object sender, EventArgs e)
        {
            dtgv_BaseDeDatos.DataSource = null;
            cmb_TipoDeUtil.SelectedIndex = 0;
            pic_ImagenBorrar.Image = null;
        }

        /// <summary>
        /// Lee la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LeerBase_Click(object sender, EventArgs e)
        {
            try
            { 
                RefrescaLista();
                CancelaImagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre un form y agrega util a la base de datos con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarUtil_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregaUtil frmAgregaUtil = new FrmAgregaUtil();

                if (frmAgregaUtil.ShowDialog() == DialogResult.OK)
                {
                    ActivaImagen(imageAgregar);
                    MessageBox.Show("Util agregado a la base", "Se agrego Util", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescaLista();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Elimina un util elegido en el datagrid y se muestra una imagen. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_BaseDeDatos.SelectedRows.Count > 0)
                {
                    Util utilABorrar = (Util)dtgv_BaseDeDatos.CurrentRow.DataBoundItem;
                    UtilDAO.BorraDatos(utilABorrar);
                    MessageBox.Show("Se elimino el util seleccionado", "Borrado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivaImagen(imageBorrar);
                    RefrescaLista();
                }
                else
                {
                    throw new Exception("Haga click en un producto para borrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Boton editar que lleva a otro form en el cual se editan los datos del util elegido en el Datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_BaseDeDatos.SelectedRows.Count > 0)
                {
                    Util util = (Util)dtgv_BaseDeDatos.CurrentRow.DataBoundItem;
                   
                    FrmAgregaUtil frmAgregaUtil = new FrmAgregaUtil(util);

                    if (frmAgregaUtil.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Util modificado en la base", "Se modifico Util", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescaLista();
                    }

                    RefrescaLista();
                }
                else
                {
                    throw new Exception("Haga click en un producto para editar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento cuando se cambia el combobox se refresca la info del datagrid y cancela la imagen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TipoDeUtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescaLista();
            CancelaImagen();
        }

        /// <summary>
        /// Cancela la muestra de la imagen cuando se hace clik en cualquier lugar del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseDeDatos_Click(object sender, EventArgs e)
        {
            CancelaImagen();
        }

        /// <summary>
        ///Lee y refresca la info de la base de datos en el Datagrid 
        /// </summary>
        public void RefrescaLista()
        {
            LeeDatos(cmb_TipoDeUtil.Text);
            dtgv_BaseDeDatos.Refresh();
            dtgv_BaseDeDatos.Update();
        }

        /// <summary>
        /// Pone los datos en el data grid traidos de la base de datos
        /// </summary>
        /// <param name="texto"></param>
        public void LeeDatos(string texto)
        {
            List<Util> list = new List<Util>();
            try
            {
                switch (texto)
                {
                    case "Lapiz":
                        dtgv_BaseDeDatos.DataSource = UtilDAO.LeerDatosLapiz();
                        break;
                    case "Goma":
                        dtgv_BaseDeDatos.DataSource = UtilDAO.LeerDatosGoma();
                        break;
                    case "Sacapunta":
                        dtgv_BaseDeDatos.DataSource = UtilDAO.LeerDatosSacapuntas();
                        break;
                    case "Fibron":
                        dtgv_BaseDeDatos.DataSource = UtilDAO.LeerDatosFibrones();
                        break;
                    default:
                        throw new ExceptionArchivo("Error al leer la base");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra la imagen siempre y cuando no este cancelada por el token 
        /// </summary>
        /// <param name="imagen"></param>
        public void MuestraImagen(Bitmap imagen)
        {
            while (!tokenSource.IsCancellationRequested)// mientras no se pida la cancelacion
            {
                Thread.Sleep(1000);
                if (this.pic_ImagenBorrar.InvokeRequired)
                {
                    Action action = new Action(() =>
                    {
                        this.pic_ImagenBorrar.Image = imagen;
                        //this.pic_ImagenBorrar.Image = imageBorrar;
                    });
                    this.pic_ImagenBorrar.BeginInvoke(action);
                }
                else
                {
                    if(this.pic_ImagenBorrar.Image != null)
                    {
                        this.pic_ImagenBorrar.Image = imagen;
                    }
                   
                }
            }
        }

        /// <summary>
        /// Inicia una la tarea de mostrar la imagen que se le pasa por parametro
        /// </summary>
        /// <param name="imagen"></param>
        private void ActivaImagen(Bitmap imagen)
        {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task.Run(() =>
            {
                MuestraImagen(imagen);
            }, this.token);

        }

        /// <summary>
        /// Cancela la ejecucion de la imagen y la pone en null
        /// </summary>
        private void CancelaImagen()
        {
            try
            {
                if (this.pic_ImagenBorrar is not null)
                {
                    this.tokenSource.Cancel();
                    this.pic_ImagenBorrar.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ContarNombre_Click(object sender, EventArgs e)
        {
            int cantidad = Validaciones.ToString(cmb_TipoDeUtil.Text);
            MessageBox.Show($"Cantidad : {cantidad}");
        }
    }


   
}
