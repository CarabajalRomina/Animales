namespace animales.view
{
    partial class InicioView
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(178, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(414, 106);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Zootopia";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(303, 204);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(150, 20);
            this.lblImagen.TabIndex = 1;
            this.lblImagen.Text = "imagen de animales";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.button1);
            this.pnlBotones.Controls.Add(this.btnAnimales);
            this.pnlBotones.Controls.Add(this.btnAlimentos);
            this.pnlBotones.Location = new System.Drawing.Point(0, 321);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(800, 100);
            this.pnlBotones.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Visitar animales";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(294, 20);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(219, 66);
            this.btnAnimales.TabIndex = 1;
            this.btnAnimales.Text = "Crear animales";
            this.btnAnimales.UseVisualStyleBackColor = true;
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.Location = new System.Drawing.Point(46, 20);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(218, 66);
            this.btnAlimentos.TabIndex = 0;
            this.btnAlimentos.Text = "Crear alimentos";
            this.btnAlimentos.UseVisualStyleBackColor = true;
            this.btnAlimentos.Click += new System.EventHandler(this.btnAlimentos_Click);
            // 
            // InicioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "InicioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zootopia";
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.Button button1;
    }
}