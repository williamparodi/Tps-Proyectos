using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TpUtiles;

namespace Vista
{
    public partial class FrmSerealizaDeserealiza : Form
    {
        Cartuchera<Lapiz> cartuchera;
        List<Lapiz> listaDeserealizado;
        private Lapiz lapiz;
        private int fila;
        private string pathXml;
        private string pathJson;
        public FrmSerealizaDeserealiza()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Lapiz>();
            lapiz = new Lapiz();
            listaDeserealizado = new List<Lapiz>();
            pathXml = "";
            pathJson = "";
            cartuchera.ListaUtiles = HardcodeaLista();
        }

        private void btn_SerealizarXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (pathXml == "")
                {
                    pathXml = "lapiz.xml";
                    lapiz.SerializaLapizXml(pathXml, lapiz);
                    MessageBox.Show("Lapiz serealizado en formato Xml");
                }
                else
                {
                    lapiz.SerializaLapizXml(pathXml, lapiz);
                    MessageBox.Show("Se Actualizo el lapiz serealizado en formato Xml");
                }

            }
            catch (ExceptionArchivo ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmSerealizaDeserealiza_Load(object sender, EventArgs e)
        {
            dtgv_ListaLapices.DataSource = null;
            dtgv_LapicesDeserealizados.DataSource = null;
            dtgv_ListaLapices.DataSource = cartuchera.ListaUtiles;
        }

        public virtual List<Lapiz> HardcodeaLista()
        {
            Lapiz lapiz1 = new Lapiz(10, "Faber Castell", EColor.Azul, ETipoLapiz.Normal);
            Lapiz lapiz2 = new Lapiz(25, "Larro", EColor.Amarillo, ETipoLapiz.Grafito);
            Lapiz lapiz3 = new Lapiz(166, "Jovi", EColor.Rojo, ETipoLapiz.Normal);
            Lapiz lapiz4 = new Lapiz(35, "Filgo", EColor.Negro, ETipoLapiz.Normal);
            Lapiz lapiz5 = new Lapiz(36, "Plexy", EColor.Rojo, ETipoLapiz.Grafito);
            List<Lapiz> auxLista = new List<Lapiz>();
            auxLista.Add(lapiz1);
            auxLista.Add(lapiz2);
            auxLista.Add(lapiz3);
            auxLista.Add(lapiz4);
            auxLista.Add(lapiz5);

            return auxLista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!File.Exists("lapiz.json"))
                {
                    lapiz.SerializaLapizJson(lapiz);
                    MessageBox.Show("Lapiz serealizado en formato Json");
                }
                else
                {
                    lapiz.SerializaLapizJson(lapiz);
                    MessageBox.Show("Se actualizo el lapiz serealizado en Json");
                }
            }
            catch (ExceptionArchivo ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgv_ListaLapices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            if (fila != -1)
            {
                if (cartuchera.ListaUtiles[fila] is not null)
                {
                    lapiz.Precio = cartuchera.ListaUtiles[fila].Precio;
                    lapiz.Color = cartuchera.ListaUtiles[fila].Color;
                    lapiz.Marca = cartuchera.ListaUtiles[fila].Marca;
                    lapiz.TipoDeLapiz = cartuchera.ListaUtiles[fila].TipoDeLapiz;
                }
            }
        }

        private void btn_DeserealizarJson_Click(object sender, EventArgs e)
        {
            try
            {
                pathJson = "lapiz.json";
                if (File.Exists(pathJson))
                {
                    lapiz = (Lapiz)lapiz.DeseralizaJsonLapiz(pathJson);
                    if (lapiz is not null)
                    {
                        listaDeserealizado.Add(lapiz);
                        MessageBox.Show("Se deserealizo lapiz de formato json");
                        dtgv_LapicesDeserealizados.DataSource = null;
                        dtgv_LapicesDeserealizados.DataSource = listaDeserealizado;
                    }
                }
                else
                {
                    MessageBox.Show("Primero debería serializar un lapiz en formato json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_DeserealizarXml_Click(object sender, EventArgs e)
        {
            try
            {
                pathJson = "lapiz.xml";
                if (File.Exists(pathJson))
                {
                    lapiz = (Lapiz)lapiz.DeserealizaLapizXml(pathJson);
                    if (lapiz is not null)
                    {
                        listaDeserealizado.Add(lapiz);
                        MessageBox.Show("Se deserealizo lapiz de formato xml");
                        dtgv_LapicesDeserealizados.DataSource = null;
                        dtgv_LapicesDeserealizados.DataSource = listaDeserealizado;
                    }
                }
                else
                {
                    MessageBox.Show("Primero debería serializar un lapiz en formato xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ExceptionArchivo ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }

}
