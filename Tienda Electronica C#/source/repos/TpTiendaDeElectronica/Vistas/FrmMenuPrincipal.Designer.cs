namespace Vistas
{
    partial class FrmMenuPrincipal
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
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.Violet;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_venta.Location = new System.Drawing.Point(197, 204);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(116, 23);
            this.btn_venta.TabIndex = 0;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Violet;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Admin.Location = new System.Drawing.Point(425, 204);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(116, 23);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Adminitrar Stock";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_venta);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_Admin;
    }
}