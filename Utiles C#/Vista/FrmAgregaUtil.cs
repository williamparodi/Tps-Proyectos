using Entidades;
using System;
using System.Windows.Forms;
using TpUtiles;

namespace Vista
{
    public partial class FrmAgregaUtil : Form
    {
        private int id;
        private Util util;
        Lapiz lapiz = new Lapiz();
        Goma goma = new Goma();
        Sacapunta sacapunta = new Sacapunta();
        public FrmAgregaUtil()
        {
            InitializeComponent(); 
        }

        public FrmAgregaUtil(Util util) : this()
        {
            this.util = util;
            this.id = this.util.Id;
        }

        private void FrmAgregaUtil_Load(object sender, EventArgs e)
        {
            cmb_TipoDeUtil.SelectedIndex = 0;
            cmb_Tipo.SelectedIndex = 1;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.ValidarDatosIngresados(txt_Precio.Text, txt_Marca.Text);
                if (cmb_TipoDeUtil.Text == "Lapiz")
                {
                    lapiz = lapiz.CargaDatosLapiz(txt_Precio.Text, txt_Marca.Text, cmb_Color.Text, cmb_Tipo.Text);
                    UtilDAO.GuardaLapiz(lapiz);

                }
                else if (cmb_TipoDeUtil.Text == "Goma")
                {
                    goma = goma.CargaDatosGoma(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text, cmb_Tamanio.Text);
                    UtilDAO.GuardaGoma(goma);

                }
                else if (cmb_TipoDeUtil.Text == "Sacapunta")
                {   
                    sacapunta = sacapunta.CargaDatosSacapuntas(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text);
                    UtilDAO.GuardaSacapuntas(sacapunta);

                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.ValidarDatosIngresados(txt_Precio.Text, txt_Marca.Text);
                if (this.util is Lapiz)
                {
                    cmb_TipoDeUtil.SelectedIndex = 0;
                    this.util = lapiz.CargaDatosLapiz(txt_Precio.Text, txt_Marca.Text, cmb_Color.Text, cmb_Tipo.Text);
                    this.util.Id = id;
                    UtilDAO.ModificarLapiz((Lapiz)this.util);
                }
                else if (this.util is Goma)
                {
                    cmb_TipoDeUtil.SelectedIndex = 1;
                    this.util = goma.CargaDatosGoma(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text, cmb_Tamanio.Text);
                    this.util.Id = id;
                    UtilDAO.ModificarGoma((Goma)this.util);
                }
                else if (this.util is Sacapunta)
                {
                    cmb_TipoDeUtil.SelectedIndex = 2;
                    this.util = sacapunta.CargaDatosSacapuntas(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text);
                    this.util.Id = id;
                    UtilDAO.ModificarSacapuntas((Sacapunta)this.util);
                }

                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargaLosCamposSegunTipo()
        {
            if (this.util is Goma)
            {
                goma = (Goma)this.util;
                cmb_TipoDeUtil.SelectedIndex = 1;
                cmb_Tamanio.SelectedIndex = (int)goma.Tamanio;
                cmb_Tipo.SelectedIndex = (int)goma.TipoGoma;
            }
            else if (this.util is Sacapunta)
            {
                
                sacapunta = (Sacapunta)this.util;
                cmb_TipoDeUtil.SelectedIndex = 2;
                cmb_Tipo.SelectedIndex = (int)sacapunta.TipoSacapuntas;
            }
            else if (this.util is Lapiz)
            {
                lapiz = (Lapiz)this.util;
                cmb_TipoDeUtil.SelectedIndex = 0;
                cmb_Color.SelectedIndex = (int)lapiz.Color;
                cmb_Tipo.SelectedIndex = (int)lapiz.TipoDeLapiz;
            }
        }

        private void CargaLosCasillerosDeUtil()
        {
            txt_Marca.Text = this.util.Marca;
            txt_Precio.Text = this.util.Precio.ToString();
            //CargaLosCamposSegunTipo();
        }

        private void cmb_TipoDeUtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Tipo.DataSource = CargaDatos.CargaTipo(cmb_TipoDeUtil.Text);
            cmb_Tamanio.DataSource = CargaDatos.CargaTamanio(cmb_TipoDeUtil.Text);
            cmb_Color.DataSource = CargaDatos.CargaColor(cmb_TipoDeUtil.Text);
        }
    }

}


