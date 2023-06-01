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
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lblTitulo = new Label();
            lblImagen = new Label();
            pnlBotones = new Panel();
            button1 = new Button();
            btnAnimales = new Button();
            btnAlimentos = new Button();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(198, 71);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(414, 106);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Zootopia";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(337, 255);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(170, 25);
            lblImagen.TabIndex = 1;
            lblImagen.Text = "imagen de animales";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(button1);
            pnlBotones.Controls.Add(btnAnimales);
            pnlBotones.Controls.Add(btnAlimentos);
            pnlBotones.Location = new Point(0, 401);
            pnlBotones.Margin = new Padding(3, 4, 3, 4);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(889, 125);
            pnlBotones.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(599, 25);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(231, 82);
            button1.TabIndex = 2;
            button1.Text = "Visitar animales";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAnimales
            // 
            btnAnimales.Location = new Point(327, 25);
            btnAnimales.Margin = new Padding(3, 4, 3, 4);
            btnAnimales.Name = "btnAnimales";
            btnAnimales.Size = new Size(243, 82);
            btnAnimales.TabIndex = 1;
            btnAnimales.Text = "Crear animales";
            btnAnimales.UseVisualStyleBackColor = true;
            btnAnimales.Click += btnAnimales_Click;
            // 
            // btnAlimentos
            // 
            btnAlimentos.Location = new Point(51, 25);
            btnAlimentos.Margin = new Padding(3, 4, 3, 4);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Size = new Size(242, 82);
            btnAlimentos.TabIndex = 0;
            btnAlimentos.Text = "Crear alimentos";
            btnAlimentos.UseVisualStyleBackColor = true;
            btnAlimentos.Click += btnAlimentos_Click;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(pnlBotones);
            Controls.Add(lblImagen);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InicioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zootopia";
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblImagen;
        private Panel pnlBotones;
        private Button btnAnimales;
        private Button btnAlimentos;
        private Button button1;
    }
}