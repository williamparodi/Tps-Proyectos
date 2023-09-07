using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        private string path;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            path = string.Empty;
        }

        private void btn_Utiles_Click(object sender, EventArgs e)
        {
            FrmUtiles frmUtiles = new FrmUtiles();
            frmUtiles.ShowDialog();
            this.Close();
        }

        private void btn_SerealizaDeserealiza_Click(object sender, EventArgs e)
        {
            FrmSerealizaDeserealiza frmSerealizaDeserealiza = new FrmSerealizaDeserealiza();
            frmSerealizaDeserealiza.ShowDialog();
            this.Close();
        }

        private void btn_Tickets_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(LeerTicket());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            
        }

        private void btn_Base_Click(object sender, EventArgs e)
        {
            FrmBaseDeDatos frmBaseDeDatos = new FrmBaseDeDatos();
            frmBaseDeDatos.ShowDialog();
            this.Close();
        }

        private string LeerTicket()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //obtengo el nombre del archivo
                        this.path = ofd.FileName;

                        using (StreamReader streamReader = new StreamReader(this.path))
                        {
                            this.path = streamReader.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return this.path;
        }

    }
}
