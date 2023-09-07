namespace Vistas
{
    partial class FrmComprarPorductos
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
            this.cmb_Proveedores = new System.Windows.Forms.ComboBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.dgtv_ListaProductos = new System.Windows.Forms.DataGridView();
            this.lbl_listaProductosProvee = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgtv_Carro = new System.Windows.Forms.DataGridView();
            this.btn_Comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_ListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Proveedores
            // 
            this.cmb_Proveedores.FormattingEnabled = true;
            this.cmb_Proveedores.Items.AddRange(new object[] {
            "Pedro",
            "Juan",
            "Carlos"});
            this.cmb_Proveedores.Location = new System.Drawing.Point(74, 45);
            this.cmb_Proveedores.Name = "cmb_Proveedores";
            this.cmb_Proveedores.Size = new System.Drawing.Size(121, 23);
            this.cmb_Proveedores.TabIndex = 0;
            this.cmb_Proveedores.SelectedIndexChanged += new System.EventHandler(this.cmb_Proveedores_SelectedIndexChanged);
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Location = new System.Drawing.Point(76, 18);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(99, 15);
            this.lbl_Proveedor.TabIndex = 1;
            this.lbl_Proveedor.Text = "Lista Proveedores";
            // 
            // dgtv_ListaProductos
            // 
            this.dgtv_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_ListaProductos.Location = new System.Drawing.Point(351, 59);
            this.dgtv_ListaProductos.Name = "dgtv_ListaProductos";
            this.dgtv_ListaProductos.RowTemplate.Height = 25;
            this.dgtv_ListaProductos.Size = new System.Drawing.Size(240, 150);
            this.dgtv_ListaProductos.TabIndex = 2;
            this.dgtv_ListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtv_ListaProductos_CellClick);
            // 
            // lbl_listaProductosProvee
            // 
            this.lbl_listaProductosProvee.AutoSize = true;
            this.lbl_listaProductosProvee.Location = new System.Drawing.Point(406, 25);
            this.lbl_listaProductosProvee.Name = "lbl_listaProductosProvee";
            this.lbl_listaProductosProvee.Size = new System.Drawing.Size(94, 15);
            this.lbl_listaProductosProvee.TabIndex = 3;
            this.lbl_listaProductosProvee.Text = "Lista Producctos";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(621, 234);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgtv_Carro
            // 
            this.dgtv_Carro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_Carro.Location = new System.Drawing.Point(356, 299);
            this.dgtv_Carro.Name = "dgtv_Carro";
            this.dgtv_Carro.RowTemplate.Height = 25;
            this.dgtv_Carro.Size = new System.Drawing.Size(240, 150);
            this.dgtv_Carro.TabIndex = 5;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(632, 425);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comprar.TabIndex = 6;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // FrmComprarPorductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.dgtv_Carro);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_listaProductosProvee);
            this.Controls.Add(this.dgtv_ListaProductos);
            this.Controls.Add(this.lbl_Proveedor);
            this.Controls.Add(this.cmb_Proveedores);
            this.Name = "FrmComprarPorductos";
            this.Text = "FrmComprarPorductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_ListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Proveedores;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.DataGridView dgtv_ListaProductos;
        private System.Windows.Forms.Label lbl_listaProductosProvee;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgtv_Carro;
        private System.Windows.Forms.Button btn_Comprar;
    }
}