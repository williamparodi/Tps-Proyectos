using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using TpUtiles;
using System.Collections.Generic;

namespace Vista
{
    public partial class FrmUtiles : Form
    {
        private Cartuchera<Util> cartuchera;
        private Lapiz lapiz;
        private Goma goma;
        private Sacapunta sacapunta;
        private SaveFileDialog saveFileDialog;
        private Fibron fibron;
        private string path;
        private string pathFibron;
        private string carpetaDefalut;
        private Cartuchera<Util> cartucheraFibron;
        
        public FrmUtiles()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Util>();
            cartucheraFibron = new Cartuchera<Util>();
            fibron = new Fibron();
            lapiz = new Lapiz();
            goma = new Goma();
            sacapunta = new Sacapunta();
            saveFileDialog = new SaveFileDialog();
            carpetaDefalut = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.InitialDirectory = carpetaDefalut;
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            saveFileDialog.Title = "Save a Text File";
            path = string.Empty;
            pathFibron = string.Empty;
            cartuchera.EventoPrecio += NotificacionPrecio;
            cartuchera.EventoTickets += GuardarTicket;
        
        }

        private void FrmUtiles_Load(object sender, EventArgs e)
        {
            cmb_TipoDeUtil.SelectedIndex = 0;
            cmb_Tipo.SelectedIndex = 1;
            fibron.HarcodeaFibrones(cartucheraFibron);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.ValidarDatosIngresados(txt_Precio.Text, txt_Marca.Text);
                if (cmb_TipoDeUtil.Text == "Lapiz")
                {
                    lapiz = lapiz.CargaDatosLapiz(txt_Precio.Text, txt_Marca.Text, cmb_Color.Text, cmb_Tipo.Text);
                    if (cartuchera + lapiz)
                    {
                        MessageBox.Show($"Se agrego Lapiz : {lapiz}", "Util agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cartuchera<Util> cartuchera= new Cartuchera<Util>();
                    }
                }
                else if (cmb_TipoDeUtil.Text == "Goma")
                {
                    goma = goma.CargaDatosGoma(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text, cmb_Tamanio.Text);
                    if (cartuchera + goma)
                    {
                        MessageBox.Show($"Se agrego Goma : {goma}","Util agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    sacapunta = sacapunta.CargaDatosSacapuntas(txt_Precio.Text, txt_Marca.Text, cmb_Tipo.Text);
                    if(cartuchera + sacapunta)
                    {
                        MessageBox.Show($"Se agrego sacapuntas : {sacapunta}","Util agregado" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
             
            }
            catch (CartucheraLLenaException ex)
            {
                MessageBox.Show(ex.Message, "Cartuchera LLena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public  void NotificacionPrecio(string texto)
        {
            MessageBox.Show(texto,"Evento Precio",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
      
        private void GuardarTicket()
        {
            try
            {
                saveFileDialog.FileName = "tickets.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(this.path))
                    {
           
                        this.path = saveFileDialog.FileName;
                        using (StreamWriter streamWriter = new StreamWriter(this.path, true))
                        {
                            streamWriter.WriteLine(cartuchera.MuestraCartuchera(cartuchera.ListaUtiles));
                        }
                    }
                    else  
                    {
                        using (StreamWriter streamWriter = new StreamWriter(this.path,true))
                        {
                            streamWriter.WriteLine(cartuchera.MuestraCartuchera(cartuchera.ListaUtiles));
                        }
                        MessageBox.Show("Se agrego informacion al archivo tickets");
                    }
                }

            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        private void btn_VerCartuchera_Click(object sender, EventArgs e)
        {
            rtx_Cartuchera.Text= string.Empty;
            rtx_Cartuchera.Text = cartuchera.MuestraCartuchera(cartuchera.ListaUtiles);
        }

        private void cmb_TipoDeUtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Tipo.DataSource = CargaDatos.CargaTipo(cmb_TipoDeUtil.Text);
            cmb_Tamanio.DataSource = CargaDatos.CargaTamanio(cmb_TipoDeUtil.Text);
            cmb_Color.DataSource = CargaDatos.CargaColor(cmb_TipoDeUtil.Text);
           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
            
        }

         
        private void btn_Resaltar_Click(object sender, EventArgs e)
        {
            try
            {
                Fibron fibron1 = new Fibron();
                Random random = new Random();
                int numero = random.Next(1, 10);
                int index = random.Next(cartucheraFibron.ListaUtiles.Count);
                fibron1 = (Fibron)cartucheraFibron.ListaUtiles[index];
                MessageBox.Show(fibron1.MuestraCantidadDeTinta(fibron1.CantidadTinta,numero), "Info Tinta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fibron1.Resaltar(numero);
                fibron1.EventoSinTinta += NotificacionSinTinta;
                fibron1.EventoError += EscribeFibron;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Fibron sin tinta ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void EscribeFibron(string texto)
        {
            try
            {
                saveFileDialog.FileName = "errors.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(this.pathFibron))
                    {
                        pathFibron = saveFileDialog.FileName;
                        using (StreamWriter streamWriter = new StreamWriter(pathFibron, true))
                        {
                            streamWriter.WriteLine(texto);
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = new StreamWriter(pathFibron,true))
                        {
                            streamWriter.WriteLine(texto);
                        }
                        MessageBox.Show("Se agrego informacion al archivo errors");
                    }
                }

            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        public void NotificacionSinTinta(string mensaje)
        {
            MessageBox.Show(mensaje,"Evento sin Tinta",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MostrarVentanaDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Error: {ex.Message}");
            stringBuilder.AppendLine("Detalle:");
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       

    }
}
