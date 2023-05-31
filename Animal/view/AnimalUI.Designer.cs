namespace animales.view
{
    partial class AnimalUI
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
            this.lblAnimal = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbAlimentacion = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(107, 45);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(261, 40);
            this.lblAnimal.TabIndex = 0;
            this.lblAnimal.Text = "Crear animales";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(118, 344);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(214, 46);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // cmbAlimentacion
            // 
            this.cmbAlimentacion.FormattingEnabled = true;
            this.cmbAlimentacion.Location = new System.Drawing.Point(193, 301);
            this.cmbAlimentacion.Name = "cmbAlimentacion";
            this.cmbAlimentacion.Size = new System.Drawing.Size(175, 28);
            this.cmbAlimentacion.TabIndex = 13;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(168, 188);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(202, 26);
            this.txtEdad.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Location = new System.Drawing.Point(55, 301);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(112, 20);
            this.lblAlimentacion.TabIndex = 10;
            this.lblAlimentacion.Text = "Alimentacion:  ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(55, 194);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 20);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(57, 243);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 20);
            this.lblPeso.TabIndex = 15;
            this.lblPeso.Text = "Peso: ";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(159, 243);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 16;
            // 
            // AnimalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 446);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbAlimentacion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAlimentacion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAnimal);
            this.Name = "AnimalUI";
            this.Text = "AnimalUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbAlimentacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
    }
}