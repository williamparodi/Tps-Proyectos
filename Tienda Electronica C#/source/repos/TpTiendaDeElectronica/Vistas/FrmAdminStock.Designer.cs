namespace Vistas
{
    partial class FrmAdminStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminStock));
            this.lbl_CategoriaStock = new System.Windows.Forms.Label();
            this.cmb_CategoriaStock = new System.Windows.Forms.ComboBox();
            this.lbl_NombreStock = new System.Windows.Forms.Label();
            this.lbl_PrecioStock = new System.Windows.Forms.Label();
            this.txt_PrecioStock = new System.Windows.Forms.TextBox();
            this.lbl_CantidadStock = new System.Windows.Forms.Label();
            this.txt_CantidadStock = new System.Windows.Forms.TextBox();
            this.lbl_TituloStock = new System.Windows.Forms.Label();
            this.btn_AceptarStock = new System.Windows.Forms.Button();
            this.btn_CanelarStock = new System.Windows.Forms.Button();
            this.lbl_ListaDeProductosStock = new System.Windows.Forms.Label();
            this.lbl_BusquedaCategoria = new System.Windows.Forms.Label();
            this.cmb_BuscarCategoriaStock = new System.Windows.Forms.ComboBox();
            this.dtgv_DatagridFiltrada = new System.Windows.Forms.DataGridView();
            this.btn_SalirStock = new System.Windows.Forms.Button();
            this.txt_NombreStock = new System.Windows.Forms.TextBox();
            this.btn_ComprarPorductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DatagridFiltrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CategoriaStock
            // 
            this.lbl_CategoriaStock.AutoSize = true;
            this.lbl_CategoriaStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CategoriaStock.Location = new System.Drawing.Point(25, 64);
            this.lbl_CategoriaStock.Name = "lbl_CategoriaStock";
            this.lbl_CategoriaStock.Size = new System.Drawing.Size(79, 16);
            this.lbl_CategoriaStock.TabIndex = 0;
            this.lbl_CategoriaStock.Text = "Categoria :";
            // 
            // cmb_CategoriaStock
            // 
            this.cmb_CategoriaStock.FormattingEnabled = true;
            this.cmb_CategoriaStock.Items.AddRange(new object[] {
            "Mother",
            "Microprocesador",
            "Perisfericos",
            "Gabinete",
            "Monitor"});
            this.cmb_CategoriaStock.Location = new System.Drawing.Point(110, 62);
            this.cmb_CategoriaStock.Name = "cmb_CategoriaStock";
            this.cmb_CategoriaStock.Size = new System.Drawing.Size(121, 23);
            this.cmb_CategoriaStock.TabIndex = 1;
            // 
            // lbl_NombreStock
            // 
            this.lbl_NombreStock.AutoSize = true;
            this.lbl_NombreStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreStock.Location = new System.Drawing.Point(25, 98);
            this.lbl_NombreStock.Name = "lbl_NombreStock";
            this.lbl_NombreStock.Size = new System.Drawing.Size(65, 16);
            this.lbl_NombreStock.TabIndex = 2;
            this.lbl_NombreStock.Text = "Nombre :";
            // 
            // lbl_PrecioStock
            // 
            this.lbl_PrecioStock.AutoSize = true;
            this.lbl_PrecioStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioStock.Location = new System.Drawing.Point(25, 137);
            this.lbl_PrecioStock.Name = "lbl_PrecioStock";
            this.lbl_PrecioStock.Size = new System.Drawing.Size(56, 16);
            this.lbl_PrecioStock.TabIndex = 4;
            this.lbl_PrecioStock.Text = "Precio :";
            // 
            // txt_PrecioStock
            // 
            this.txt_PrecioStock.Location = new System.Drawing.Point(110, 135);
            this.txt_PrecioStock.Name = "txt_PrecioStock";
            this.txt_PrecioStock.Size = new System.Drawing.Size(121, 23);
            this.txt_PrecioStock.TabIndex = 5;
            // 
            // lbl_CantidadStock
            // 
            this.lbl_CantidadStock.AutoSize = true;
            this.lbl_CantidadStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadStock.Location = new System.Drawing.Point(25, 179);
            this.lbl_CantidadStock.Name = "lbl_CantidadStock";
            this.lbl_CantidadStock.Size = new System.Drawing.Size(73, 16);
            this.lbl_CantidadStock.TabIndex = 6;
            this.lbl_CantidadStock.Text = "Cantidad :";
            // 
            // txt_CantidadStock
            // 
            this.txt_CantidadStock.Location = new System.Drawing.Point(110, 177);
            this.txt_CantidadStock.Name = "txt_CantidadStock";
            this.txt_CantidadStock.Size = new System.Drawing.Size(121, 23);
            this.txt_CantidadStock.TabIndex = 7;
            // 
            // lbl_TituloStock
            // 
            this.lbl_TituloStock.AutoSize = true;
            this.lbl_TituloStock.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloStock.Location = new System.Drawing.Point(25, 19);
            this.lbl_TituloStock.Name = "lbl_TituloStock";
            this.lbl_TituloStock.Size = new System.Drawing.Size(244, 25);
            this.lbl_TituloStock.TabIndex = 8;
            this.lbl_TituloStock.Text = "Agregar y editar stock";
            // 
            // btn_AceptarStock
            // 
            this.btn_AceptarStock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AceptarStock.Location = new System.Drawing.Point(532, 177);
            this.btn_AceptarStock.Name = "btn_AceptarStock";
            this.btn_AceptarStock.Size = new System.Drawing.Size(152, 31);
            this.btn_AceptarStock.TabIndex = 9;
            this.btn_AceptarStock.Text = "Aceptar";
            this.btn_AceptarStock.UseVisualStyleBackColor = true;
            this.btn_AceptarStock.Click += new System.EventHandler(this.btn_AceptarStock_Click);
            // 
            // btn_CanelarStock
            // 
            this.btn_CanelarStock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CanelarStock.Location = new System.Drawing.Point(336, 177);
            this.btn_CanelarStock.Name = "btn_CanelarStock";
            this.btn_CanelarStock.Size = new System.Drawing.Size(152, 31);
            this.btn_CanelarStock.TabIndex = 10;
            this.btn_CanelarStock.Text = "Cancelar";
            this.btn_CanelarStock.UseVisualStyleBackColor = true;
            // 
            // lbl_ListaDeProductosStock
            // 
            this.lbl_ListaDeProductosStock.AutoSize = true;
            this.lbl_ListaDeProductosStock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ListaDeProductosStock.Location = new System.Drawing.Point(25, 232);
            this.lbl_ListaDeProductosStock.Name = "lbl_ListaDeProductosStock";
            this.lbl_ListaDeProductosStock.Size = new System.Drawing.Size(273, 23);
            this.lbl_ListaDeProductosStock.TabIndex = 11;
            this.lbl_ListaDeProductosStock.Text = "Lista de Productos en stock";
            // 
            // lbl_BusquedaCategoria
            // 
            this.lbl_BusquedaCategoria.AutoSize = true;
            this.lbl_BusquedaCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BusquedaCategoria.Location = new System.Drawing.Point(25, 269);
            this.lbl_BusquedaCategoria.Name = "lbl_BusquedaCategoria";
            this.lbl_BusquedaCategoria.Size = new System.Drawing.Size(144, 16);
            this.lbl_BusquedaCategoria.TabIndex = 12;
            this.lbl_BusquedaCategoria.Text = "Buscar por Categoria";
            // 
            // cmb_BuscarCategoriaStock
            // 
            this.cmb_BuscarCategoriaStock.FormattingEnabled = true;
            this.cmb_BuscarCategoriaStock.Items.AddRange(new object[] {
            "Mother",
            "Microprocesador",
            "Perisfericos",
            "Gabinete",
            "Monitor"});
            this.cmb_BuscarCategoriaStock.Location = new System.Drawing.Point(177, 267);
            this.cmb_BuscarCategoriaStock.Name = "cmb_BuscarCategoriaStock";
            this.cmb_BuscarCategoriaStock.Size = new System.Drawing.Size(121, 23);
            this.cmb_BuscarCategoriaStock.TabIndex = 13;
            this.cmb_BuscarCategoriaStock.SelectedIndexChanged += new System.EventHandler(this.cmb_BuscarCategoriaStock_SelectedIndexChanged);
            // 
            // dtgv_DatagridFiltrada
            // 
            this.dtgv_DatagridFiltrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DatagridFiltrada.Location = new System.Drawing.Point(25, 331);
            this.dtgv_DatagridFiltrada.Name = "dtgv_DatagridFiltrada";
            this.dtgv_DatagridFiltrada.RowTemplate.Height = 25;
            this.dtgv_DatagridFiltrada.Size = new System.Drawing.Size(463, 150);
            this.dtgv_DatagridFiltrada.TabIndex = 16;
            // 
            // btn_SalirStock
            // 
            this.btn_SalirStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SalirStock.Location = new System.Drawing.Point(629, 457);
            this.btn_SalirStock.Name = "btn_SalirStock";
            this.btn_SalirStock.Size = new System.Drawing.Size(129, 34);
            this.btn_SalirStock.TabIndex = 17;
            this.btn_SalirStock.Text = "Salir";
            this.btn_SalirStock.UseVisualStyleBackColor = true;
            this.btn_SalirStock.Click += new System.EventHandler(this.btn_SalirStock_Click);
            // 
            // txt_NombreStock
            // 
            this.txt_NombreStock.Location = new System.Drawing.Point(110, 100);
            this.txt_NombreStock.Name = "txt_NombreStock";
            this.txt_NombreStock.Size = new System.Drawing.Size(121, 23);
            this.txt_NombreStock.TabIndex = 18;
            // 
            // btn_ComprarPorductos
            // 
            this.btn_ComprarPorductos.Location = new System.Drawing.Point(532, 110);
            this.btn_ComprarPorductos.Name = "btn_ComprarPorductos";
            this.btn_ComprarPorductos.Size = new System.Drawing.Size(152, 23);
            this.btn_ComprarPorductos.TabIndex = 19;
            this.btn_ComprarPorductos.Text = "Comprar Productos";
            this.btn_ComprarPorductos.UseVisualStyleBackColor = true;
            this.btn_ComprarPorductos.Click += new System.EventHandler(this.btn_ComprarPorductos_Click);
            // 
            // FrmAdminStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btn_ComprarPorductos);
            this.Controls.Add(this.txt_NombreStock);
            this.Controls.Add(this.btn_SalirStock);
            this.Controls.Add(this.dtgv_DatagridFiltrada);
            this.Controls.Add(this.cmb_BuscarCategoriaStock);
            this.Controls.Add(this.lbl_BusquedaCategoria);
            this.Controls.Add(this.lbl_ListaDeProductosStock);
            this.Controls.Add(this.btn_CanelarStock);
            this.Controls.Add(this.btn_AceptarStock);
            this.Controls.Add(this.lbl_TituloStock);
            this.Controls.Add(this.txt_CantidadStock);
            this.Controls.Add(this.lbl_CantidadStock);
            this.Controls.Add(this.txt_PrecioStock);
            this.Controls.Add(this.lbl_PrecioStock);
            this.Controls.Add(this.lbl_NombreStock);
            this.Controls.Add(this.cmb_CategoriaStock);
            this.Controls.Add(this.lbl_CategoriaStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminStock";
            this.Text = "Administrar Stock";
            this.Load += new System.EventHandler(this.FrmAdminStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DatagridFiltrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CategoriaStock;
        private System.Windows.Forms.ComboBox cmb_CategoriaStock;
        private System.Windows.Forms.Label lbl_NombreStock;
        private System.Windows.Forms.Label lbl_PrecioStock;
        private System.Windows.Forms.TextBox txt_PrecioStock;
        private System.Windows.Forms.Label lbl_CantidadStock;
        private System.Windows.Forms.TextBox txt_CantidadStock;
        private System.Windows.Forms.Label lbl_TituloStock;
        private System.Windows.Forms.Button btn_AceptarStock;
        private System.Windows.Forms.Button btn_CanelarStock;
        private System.Windows.Forms.Label lbl_ListaDeProductosStock;
        private System.Windows.Forms.Label lbl_BusquedaCategoria;
        private System.Windows.Forms.ComboBox cmb_BuscarCategoriaStock;
        private System.Windows.Forms.DataGridView dtgv_DatagridFiltrada;
        private System.Windows.Forms.Button btn_SalirStock;
        private System.Windows.Forms.TextBox txt_NombreStock;
        private System.Windows.Forms.Button btn_ComprarPorductos;
    }
}