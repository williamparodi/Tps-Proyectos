namespace Vista
{
    partial class FrmAgregaUtil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregaUtil));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Util = new System.Windows.Forms.Label();
            this.cmb_TipoDeUtil = new System.Windows.Forms.ComboBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Tamanio = new System.Windows.Forms.Label();
            this.cmb_Tamanio = new System.Windows.Forms.ComboBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 347);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(121, 30);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar Nuevo";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(12, 70);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_Marca.TabIndex = 1;
            this.lbl_Marca.Tag = "";
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Util
            // 
            this.lbl_Util.AutoSize = true;
            this.lbl_Util.Location = new System.Drawing.Point(12, 26);
            this.lbl_Util.Name = "lbl_Util";
            this.lbl_Util.Size = new System.Drawing.Size(25, 15);
            this.lbl_Util.TabIndex = 2;
            this.lbl_Util.Text = "Util";
            // 
            // cmb_TipoDeUtil
            // 
            this.cmb_TipoDeUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDeUtil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_TipoDeUtil.FormattingEnabled = true;
            this.cmb_TipoDeUtil.Items.AddRange(new object[] {
            "Lapiz",
            "Goma",
            "Sacapunta"});
            this.cmb_TipoDeUtil.Location = new System.Drawing.Point(104, 23);
            this.cmb_TipoDeUtil.Name = "cmb_TipoDeUtil";
            this.cmb_TipoDeUtil.Size = new System.Drawing.Size(121, 23);
            this.cmb_TipoDeUtil.TabIndex = 3;
            this.cmb_TipoDeUtil.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoDeUtil_SelectedIndexChanged);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(102, 67);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(123, 23);
            this.txt_Marca.TabIndex = 4;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(12, 121);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_Tipo.TabIndex = 5;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Normal",
            "Grafito"});
            this.cmb_Tipo.Location = new System.Drawing.Point(102, 118);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tipo.TabIndex = 6;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(103, 260);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(91, 23);
            this.txt_Precio.TabIndex = 7;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(12, 263);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_Precio.TabIndex = 8;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(12, 167);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(36, 15);
            this.lbl_Color.TabIndex = 9;
            this.lbl_Color.Text = "Color";
            // 
            // cmb_Color
            // 
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Items.AddRange(new object[] {
            "Amarillo",
            "Negro",
            "Azul",
            "Rojo"});
            this.cmb_Color.Location = new System.Drawing.Point(103, 167);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(121, 23);
            this.cmb_Color.TabIndex = 10;
            // 
            // lbl_Tamanio
            // 
            this.lbl_Tamanio.AutoSize = true;
            this.lbl_Tamanio.Location = new System.Drawing.Point(12, 216);
            this.lbl_Tamanio.Name = "lbl_Tamanio";
            this.lbl_Tamanio.Size = new System.Drawing.Size(52, 15);
            this.lbl_Tamanio.TabIndex = 12;
            this.lbl_Tamanio.Text = "Tamanio";
            // 
            // cmb_Tamanio
            // 
            this.cmb_Tamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tamanio.FormattingEnabled = true;
            this.cmb_Tamanio.Items.AddRange(new object[] {
            "Numero1",
            "Numero2",
            "Numero3"});
            this.cmb_Tamanio.Location = new System.Drawing.Point(103, 213);
            this.cmb_Tamanio.Name = "cmb_Tamanio";
            this.cmb_Tamanio.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tamanio.TabIndex = 13;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(186, 347);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(121, 30);
            this.btn_Modificar.TabIndex = 14;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // FrmAgregaUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.cmb_Tamanio);
            this.Controls.Add(this.lbl_Tamanio);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.cmb_TipoDeUtil);
            this.Controls.Add(this.lbl_Util);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregaUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega - Edita ";
            this.Load += new System.EventHandler(this.FrmAgregaUtil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Util;
        private System.Windows.Forms.ComboBox cmb_TipoDeUtil;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_Tamanio;
        private System.Windows.Forms.ComboBox cmb_Tamanio;
        private System.Windows.Forms.Button btn_Modificar;
    }
}