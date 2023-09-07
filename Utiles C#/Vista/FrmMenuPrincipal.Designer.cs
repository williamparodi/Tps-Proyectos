namespace Vista
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btn_Utiles = new System.Windows.Forms.Button();
            this.btn_SerealizaDeserealiza = new System.Windows.Forms.Button();
            this.btn_Base = new System.Windows.Forms.Button();
            this.btn_Tickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Utiles
            // 
            this.btn_Utiles.BackColor = System.Drawing.Color.Salmon;
            this.btn_Utiles.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Utiles.Location = new System.Drawing.Point(148, 81);
            this.btn_Utiles.Name = "btn_Utiles";
            this.btn_Utiles.Size = new System.Drawing.Size(138, 75);
            this.btn_Utiles.TabIndex = 0;
            this.btn_Utiles.Text = "UTILES";
            this.btn_Utiles.UseVisualStyleBackColor = false;
            this.btn_Utiles.Click += new System.EventHandler(this.btn_Utiles_Click);
            // 
            // btn_SerealizaDeserealiza
            // 
            this.btn_SerealizaDeserealiza.BackColor = System.Drawing.Color.Salmon;
            this.btn_SerealizaDeserealiza.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SerealizaDeserealiza.Location = new System.Drawing.Point(486, 81);
            this.btn_SerealizaDeserealiza.Name = "btn_SerealizaDeserealiza";
            this.btn_SerealizaDeserealiza.Size = new System.Drawing.Size(138, 75);
            this.btn_SerealizaDeserealiza.TabIndex = 1;
            this.btn_SerealizaDeserealiza.Text = "SEREALIZA Y DESEREALIZA";
            this.btn_SerealizaDeserealiza.UseVisualStyleBackColor = false;
            this.btn_SerealizaDeserealiza.Click += new System.EventHandler(this.btn_SerealizaDeserealiza_Click);
            // 
            // btn_Base
            // 
            this.btn_Base.BackColor = System.Drawing.Color.Salmon;
            this.btn_Base.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Base.Location = new System.Drawing.Point(148, 242);
            this.btn_Base.Name = "btn_Base";
            this.btn_Base.Size = new System.Drawing.Size(138, 75);
            this.btn_Base.TabIndex = 2;
            this.btn_Base.Text = "BASE DE DATOS";
            this.btn_Base.UseVisualStyleBackColor = false;
            this.btn_Base.Click += new System.EventHandler(this.btn_Base_Click);
            // 
            // btn_Tickets
            // 
            this.btn_Tickets.BackColor = System.Drawing.Color.Salmon;
            this.btn_Tickets.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Tickets.Location = new System.Drawing.Point(486, 242);
            this.btn_Tickets.Name = "btn_Tickets";
            this.btn_Tickets.Size = new System.Drawing.Size(138, 75);
            this.btn_Tickets.TabIndex = 3;
            this.btn_Tickets.Text = "TICKETS";
            this.btn_Tickets.UseVisualStyleBackColor = false;
            this.btn_Tickets.Click += new System.EventHandler(this.btn_Tickets_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Tickets);
            this.Controls.Add(this.btn_Base);
            this.Controls.Add(this.btn_SerealizaDeserealiza);
            this.Controls.Add(this.btn_Utiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Utiles;
        private System.Windows.Forms.Button btn_SerealizaDeserealiza;
        private System.Windows.Forms.Button btn_Base;
        private System.Windows.Forms.Button btn_Tickets;
    }
}
