namespace Vistas
{
    partial class FrmDetalleCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleCompra));
            this.lbl_DetallesDeCompra = new System.Windows.Forms.Label();
            this.lbl_ListaProductos = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_HistorialFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DetallesDeCompra
            // 
            this.lbl_DetallesDeCompra.AutoSize = true;
            this.lbl_DetallesDeCompra.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_DetallesDeCompra.Font = new System.Drawing.Font("Noto Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DetallesDeCompra.Location = new System.Drawing.Point(12, 29);
            this.lbl_DetallesDeCompra.Name = "lbl_DetallesDeCompra";
            this.lbl_DetallesDeCompra.Size = new System.Drawing.Size(254, 33);
            this.lbl_DetallesDeCompra.TabIndex = 0;
            this.lbl_DetallesDeCompra.Text = "Detalles de Compra";
            // 
            // lbl_ListaProductos
            // 
            this.lbl_ListaProductos.AutoSize = true;
            this.lbl_ListaProductos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_ListaProductos.Font = new System.Drawing.Font("Noto Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ListaProductos.Location = new System.Drawing.Point(12, 89);
            this.lbl_ListaProductos.Name = "lbl_ListaProductos";
            this.lbl_ListaProductos.Size = new System.Drawing.Size(240, 28);
            this.lbl_ListaProductos.TabIndex = 1;
            this.lbl_ListaProductos.Text = "Listado de Productos";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Aceptar.Location = new System.Drawing.Point(766, 492);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 37);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(596, 492);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 37);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_HistorialFacturas
            // 
            this.btn_HistorialFacturas.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HistorialFacturas.Location = new System.Drawing.Point(26, 492);
            this.btn_HistorialFacturas.Name = "btn_HistorialFacturas";
            this.btn_HistorialFacturas.Size = new System.Drawing.Size(201, 37);
            this.btn_HistorialFacturas.TabIndex = 4;
            this.btn_HistorialFacturas.Text = "Historial Facturas";
            this.btn_HistorialFacturas.UseVisualStyleBackColor = true;
            this.btn_HistorialFacturas.Click += new System.EventHandler(this.btn_HistorialFacturas_Click);
            // 
            // FrmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 553);
            this.Controls.Add(this.btn_HistorialFacturas);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_ListaProductos);
            this.Controls.Add(this.lbl_DetallesDeCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DetallesDeCompra;
        private System.Windows.Forms.Label lbl_ListaProductos;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_HistorialFacturas;
    }
}