namespace Vista
{
    partial class FrmUtiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtiles));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_AgregarUtil = new System.Windows.Forms.Label();
            this.lbl_Util = new System.Windows.Forms.Label();
            this.cmb_TipoDeUtil = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Tamanio = new System.Windows.Forms.Label();
            this.cmb_Tamanio = new System.Windows.Forms.ComboBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_VerCartuchera = new System.Windows.Forms.Button();
            this.rtx_Cartuchera = new System.Windows.Forms.RichTextBox();
            this.lbl_Cartuchera = new System.Windows.Forms.Label();
            this.btn_Resaltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.LightPink;
            this.btn_Agregar.Location = new System.Drawing.Point(21, 317);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(87, 29);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_AgregarUtil
            // 
            this.lbl_AgregarUtil.AutoSize = true;
            this.lbl_AgregarUtil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AgregarUtil.Location = new System.Drawing.Point(53, 24);
            this.lbl_AgregarUtil.Name = "lbl_AgregarUtil";
            this.lbl_AgregarUtil.Size = new System.Drawing.Size(103, 21);
            this.lbl_AgregarUtil.TabIndex = 1;
            this.lbl_AgregarUtil.Text = "Agregar Util";
            // 
            // lbl_Util
            // 
            this.lbl_Util.AutoSize = true;
            this.lbl_Util.Location = new System.Drawing.Point(21, 61);
            this.lbl_Util.Name = "lbl_Util";
            this.lbl_Util.Size = new System.Drawing.Size(25, 15);
            this.lbl_Util.TabIndex = 2;
            this.lbl_Util.Text = "Util";
            // 
            // cmb_TipoDeUtil
            // 
            this.cmb_TipoDeUtil.BackColor = System.Drawing.Color.LightPink;
            this.cmb_TipoDeUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDeUtil.FormattingEnabled = true;
            this.cmb_TipoDeUtil.Items.AddRange(new object[] {
            "Lapiz",
            "Goma",
            "Sacapunta"});
            this.cmb_TipoDeUtil.Location = new System.Drawing.Point(104, 61);
            this.cmb_TipoDeUtil.Name = "cmb_TipoDeUtil";
            this.cmb_TipoDeUtil.Size = new System.Drawing.Size(121, 23);
            this.cmb_TipoDeUtil.TabIndex = 3;
            this.cmb_TipoDeUtil.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoDeUtil_SelectedIndexChanged);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(21, 109);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_Marca.TabIndex = 4;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_Marca
            // 
            this.txt_Marca.BackColor = System.Drawing.Color.LightPink;
            this.txt_Marca.Location = new System.Drawing.Point(104, 101);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(120, 23);
            this.txt_Marca.TabIndex = 5;
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(20, 154);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(36, 15);
            this.lbl_Color.TabIndex = 6;
            this.lbl_Color.Text = "Color";
            // 
            // cmb_Color
            // 
            this.cmb_Color.BackColor = System.Drawing.Color.LightPink;
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Items.AddRange(new object[] {
            "Amarillo",
            "Negro",
            "Azul",
            "Rojo"});
            this.cmb_Color.Location = new System.Drawing.Point(104, 146);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(120, 23);
            this.cmb_Color.TabIndex = 7;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(21, 269);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_Precio.TabIndex = 8;
            this.lbl_Precio.Text = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.Color.LightPink;
            this.txt_Precio.Location = new System.Drawing.Point(102, 266);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(74, 23);
            this.txt_Precio.TabIndex = 9;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(21, 190);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_Tipo.TabIndex = 10;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.BackColor = System.Drawing.Color.LightPink;
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Normal",
            "Grafito",
            "ParaTinta",
            "ParaLapiz",
            "Portatil",
            "Electrico"});
            this.cmb_Tipo.Location = new System.Drawing.Point(103, 190);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tipo.TabIndex = 11;
            // 
            // lbl_Tamanio
            // 
            this.lbl_Tamanio.AutoSize = true;
            this.lbl_Tamanio.Location = new System.Drawing.Point(21, 228);
            this.lbl_Tamanio.Name = "lbl_Tamanio";
            this.lbl_Tamanio.Size = new System.Drawing.Size(49, 15);
            this.lbl_Tamanio.TabIndex = 12;
            this.lbl_Tamanio.Text = "Tamaño";
            // 
            // cmb_Tamanio
            // 
            this.cmb_Tamanio.BackColor = System.Drawing.Color.LightPink;
            this.cmb_Tamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tamanio.FormattingEnabled = true;
            this.cmb_Tamanio.Items.AddRange(new object[] {
            "Numero1",
            "Numero2",
            "Numero3"});
            this.cmb_Tamanio.Location = new System.Drawing.Point(102, 228);
            this.cmb_Tamanio.Name = "cmb_Tamanio";
            this.cmb_Tamanio.Size = new System.Drawing.Size(122, 23);
            this.cmb_Tamanio.TabIndex = 13;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightPink;
            this.btn_Salir.Location = new System.Drawing.Point(612, 401);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(138, 34);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_VerCartuchera
            // 
            this.btn_VerCartuchera.BackColor = System.Drawing.Color.LightPink;
            this.btn_VerCartuchera.Location = new System.Drawing.Point(277, 307);
            this.btn_VerCartuchera.Name = "btn_VerCartuchera";
            this.btn_VerCartuchera.Size = new System.Drawing.Size(114, 48);
            this.btn_VerCartuchera.TabIndex = 17;
            this.btn_VerCartuchera.Text = "Ver Cartuchera";
            this.btn_VerCartuchera.UseVisualStyleBackColor = false;
            this.btn_VerCartuchera.Click += new System.EventHandler(this.btn_VerCartuchera_Click);
            // 
            // rtx_Cartuchera
            // 
            this.rtx_Cartuchera.BackColor = System.Drawing.Color.LightPink;
            this.rtx_Cartuchera.Location = new System.Drawing.Point(433, 61);
            this.rtx_Cartuchera.Name = "rtx_Cartuchera";
            this.rtx_Cartuchera.Size = new System.Drawing.Size(285, 223);
            this.rtx_Cartuchera.TabIndex = 18;
            this.rtx_Cartuchera.Text = "";
            // 
            // lbl_Cartuchera
            // 
            this.lbl_Cartuchera.AutoSize = true;
            this.lbl_Cartuchera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cartuchera.Location = new System.Drawing.Point(530, 24);
            this.lbl_Cartuchera.Name = "lbl_Cartuchera";
            this.lbl_Cartuchera.Size = new System.Drawing.Size(97, 21);
            this.lbl_Cartuchera.TabIndex = 19;
            this.lbl_Cartuchera.Text = "Cartuchera ";
            // 
            // btn_Resaltar
            // 
            this.btn_Resaltar.BackColor = System.Drawing.Color.LightPink;
            this.btn_Resaltar.Location = new System.Drawing.Point(280, 380);
            this.btn_Resaltar.Name = "btn_Resaltar";
            this.btn_Resaltar.Size = new System.Drawing.Size(111, 33);
            this.btn_Resaltar.TabIndex = 20;
            this.btn_Resaltar.Text = "Resaltar";
            this.btn_Resaltar.UseVisualStyleBackColor = false;
            this.btn_Resaltar.Click += new System.EventHandler(this.btn_Resaltar_Click);
            // 
            // FrmUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Resaltar);
            this.Controls.Add(this.lbl_Cartuchera);
            this.Controls.Add(this.rtx_Cartuchera);
            this.Controls.Add(this.btn_VerCartuchera);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.cmb_Tamanio);
            this.Controls.Add(this.lbl_Tamanio);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.cmb_TipoDeUtil);
            this.Controls.Add(this.lbl_Util);
            this.Controls.Add(this.lbl_AgregarUtil);
            this.Controls.Add(this.btn_Agregar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUtiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utiles";
            this.Load += new System.EventHandler(this.FrmUtiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_AgregarUtil;
        private System.Windows.Forms.Label lbl_Util;
        private System.Windows.Forms.ComboBox cmb_TipoDeUtil;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbl_Tamanio;
        private System.Windows.Forms.ComboBox cmb_Tamanio;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_VerCartuchera;
        private System.Windows.Forms.RichTextBox rtx_Cartuchera;
        private System.Windows.Forms.Label lbl_Cartuchera;
        private System.Windows.Forms.Button btn_Resaltar;
    }
}