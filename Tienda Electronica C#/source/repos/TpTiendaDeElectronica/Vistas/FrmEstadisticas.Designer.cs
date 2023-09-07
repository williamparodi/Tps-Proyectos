namespace Vistas
{
    partial class FrmEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.txt_CantidadVentas = new System.Windows.Forms.TextBox();
            this.lbl_CantidadVentas = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_GananciasTotales = new System.Windows.Forms.Label();
            this.txt_GananciasTotales = new System.Windows.Forms.TextBox();
            this.txt_PromedioMirco = new System.Windows.Forms.TextBox();
            this.lbl_PromedioMicro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PromedioMother = new System.Windows.Forms.TextBox();
            this.lbl_PromedioPerisferico = new System.Windows.Forms.Label();
            this.txt_PromedioPerisferico = new System.Windows.Forms.TextBox();
            this.lbl_PromedioMonitor = new System.Windows.Forms.Label();
            this.txt_PromedioMonitor = new System.Windows.Forms.TextBox();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            this.txt_PromedioGabinete = new System.Windows.Forms.TextBox();
            this.lbl_MasVendidoCat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CantidadVentas
            // 
            this.txt_CantidadVentas.Location = new System.Drawing.Point(68, 50);
            this.txt_CantidadVentas.Name = "txt_CantidadVentas";
            this.txt_CantidadVentas.Size = new System.Drawing.Size(108, 23);
            this.txt_CantidadVentas.TabIndex = 0;
            // 
            // lbl_CantidadVentas
            // 
            this.lbl_CantidadVentas.AutoSize = true;
            this.lbl_CantidadVentas.Location = new System.Drawing.Point(68, 19);
            this.lbl_CantidadVentas.Name = "lbl_CantidadVentas";
            this.lbl_CantidadVentas.Size = new System.Drawing.Size(108, 15);
            this.lbl_CantidadVentas.TabIndex = 1;
            this.lbl_CantidadVentas.Text = "Cantidad de Ventas";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(627, 477);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(111, 41);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_GananciasTotales
            // 
            this.lbl_GananciasTotales.AutoSize = true;
            this.lbl_GananciasTotales.Location = new System.Drawing.Point(68, 97);
            this.lbl_GananciasTotales.Name = "lbl_GananciasTotales";
            this.lbl_GananciasTotales.Size = new System.Drawing.Size(100, 15);
            this.lbl_GananciasTotales.TabIndex = 3;
            this.lbl_GananciasTotales.Text = "Ganancias Totales";
            // 
            // txt_GananciasTotales
            // 
            this.txt_GananciasTotales.Location = new System.Drawing.Point(64, 125);
            this.txt_GananciasTotales.Name = "txt_GananciasTotales";
            this.txt_GananciasTotales.Size = new System.Drawing.Size(110, 23);
            this.txt_GananciasTotales.TabIndex = 4;
            // 
            // txt_PromedioMirco
            // 
            this.txt_PromedioMirco.Location = new System.Drawing.Point(65, 184);
            this.txt_PromedioMirco.Name = "txt_PromedioMirco";
            this.txt_PromedioMirco.Size = new System.Drawing.Size(100, 23);
            this.txt_PromedioMirco.TabIndex = 5;
            // 
            // lbl_PromedioMicro
            // 
            this.lbl_PromedioMicro.AutoSize = true;
            this.lbl_PromedioMicro.Location = new System.Drawing.Point(64, 166);
            this.lbl_PromedioMicro.Name = "lbl_PromedioMicro";
            this.lbl_PromedioMicro.Size = new System.Drawing.Size(203, 15);
            this.lbl_PromedioMicro.TabIndex = 6;
            this.lbl_PromedioMicro.Text = "Promedio ganancia MircoProcesador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Promedio ganancia Mother";
            // 
            // txt_PromedioMother
            // 
            this.txt_PromedioMother.Location = new System.Drawing.Point(65, 252);
            this.txt_PromedioMother.Name = "txt_PromedioMother";
            this.txt_PromedioMother.Size = new System.Drawing.Size(100, 23);
            this.txt_PromedioMother.TabIndex = 8;
            // 
            // lbl_PromedioPerisferico
            // 
            this.lbl_PromedioPerisferico.AutoSize = true;
            this.lbl_PromedioPerisferico.Location = new System.Drawing.Point(65, 293);
            this.lbl_PromedioPerisferico.Name = "lbl_PromedioPerisferico";
            this.lbl_PromedioPerisferico.Size = new System.Drawing.Size(161, 15);
            this.lbl_PromedioPerisferico.TabIndex = 9;
            this.lbl_PromedioPerisferico.Text = "Promedio ganacia Perisferico";
            // 
            // txt_PromedioPerisferico
            // 
            this.txt_PromedioPerisferico.Location = new System.Drawing.Point(64, 323);
            this.txt_PromedioPerisferico.Name = "txt_PromedioPerisferico";
            this.txt_PromedioPerisferico.Size = new System.Drawing.Size(100, 23);
            this.txt_PromedioPerisferico.TabIndex = 10;
            // 
            // lbl_PromedioMonitor
            // 
            this.lbl_PromedioMonitor.AutoSize = true;
            this.lbl_PromedioMonitor.Location = new System.Drawing.Point(63, 360);
            this.lbl_PromedioMonitor.Name = "lbl_PromedioMonitor";
            this.lbl_PromedioMonitor.Size = new System.Drawing.Size(105, 15);
            this.lbl_PromedioMonitor.TabIndex = 11;
            this.lbl_PromedioMonitor.Text = "Promedio Monitor";
            // 
            // txt_PromedioMonitor
            // 
            this.txt_PromedioMonitor.Location = new System.Drawing.Point(64, 392);
            this.txt_PromedioMonitor.Name = "txt_PromedioMonitor";
            this.txt_PromedioMonitor.Size = new System.Drawing.Size(100, 23);
            this.txt_PromedioMonitor.TabIndex = 12;
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.Location = new System.Drawing.Point(63, 442);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(160, 15);
            this.lbl_Promedio.TabIndex = 13;
            this.lbl_Promedio.Text = "Promedio ganancia Gabinete";
            // 
            // txt_PromedioGabinete
            // 
            this.txt_PromedioGabinete.Location = new System.Drawing.Point(63, 477);
            this.txt_PromedioGabinete.Name = "txt_PromedioGabinete";
            this.txt_PromedioGabinete.Size = new System.Drawing.Size(100, 23);
            this.txt_PromedioGabinete.TabIndex = 14;
            // 
            // lbl_MasVendidoCat
            // 
            this.lbl_MasVendidoCat.AutoSize = true;
            this.lbl_MasVendidoCat.Location = new System.Drawing.Point(417, 19);
            this.lbl_MasVendidoCat.Name = "lbl_MasVendidoCat";
            this.lbl_MasVendidoCat.Size = new System.Drawing.Size(257, 15);
            this.lbl_MasVendidoCat.TabIndex = 16;
            this.lbl_MasVendidoCat.Text = "Listado de producto mas vendido por categoria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(317, 239);
            this.dataGridView1.TabIndex = 17;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_MasVendidoCat);
            this.Controls.Add(this.txt_PromedioGabinete);
            this.Controls.Add(this.lbl_Promedio);
            this.Controls.Add(this.txt_PromedioMonitor);
            this.Controls.Add(this.lbl_PromedioMonitor);
            this.Controls.Add(this.txt_PromedioPerisferico);
            this.Controls.Add(this.lbl_PromedioPerisferico);
            this.Controls.Add(this.txt_PromedioMother);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PromedioMicro);
            this.Controls.Add(this.txt_PromedioMirco);
            this.Controls.Add(this.txt_GananciasTotales);
            this.Controls.Add(this.lbl_GananciasTotales);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_CantidadVentas);
            this.Controls.Add(this.txt_CantidadVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CantidadVentas;
        private System.Windows.Forms.Label lbl_CantidadVentas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_GananciasTotales;
        private System.Windows.Forms.TextBox txt_GananciasTotales;
        private System.Windows.Forms.TextBox txt_PromedioMirco;
        private System.Windows.Forms.Label lbl_PromedioMicro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PromedioMother;
        private System.Windows.Forms.Label lbl_PromedioPerisferico;
        private System.Windows.Forms.TextBox txt_PromedioPerisferico;
        private System.Windows.Forms.Label lbl_PromedioMonitor;
        private System.Windows.Forms.TextBox txt_PromedioMonitor;
        private System.Windows.Forms.Label lbl_Promedio;
        private System.Windows.Forms.TextBox txt_PromedioGabinete;
        private System.Windows.Forms.Label lbl_MasVendidoCat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}