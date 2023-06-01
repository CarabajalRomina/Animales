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
            components = new System.ComponentModel.Container();
            lblAnimal = new Label();
            btnCrear = new Button();
            cmbDiet = new ComboBox();
            txtNombre = new TextBox();
            lblAlimentacion = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            lblPeso = new Label();
            splitter1 = new Splitter();
            pnlFormAnimal = new Panel();
            numUpDnPeso = new NumericUpDown();
            numUpEdad = new NumericUpDown();
            cmbTipoAnimal = new ComboBox();
            lblTipoAnimal = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnVolver = new Button();
            pnlFormAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDnPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnimal.Location = new Point(155, 29);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(261, 40);
            lblAnimal.TabIndex = 0;
            lblAnimal.Text = "Crear animales";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(82, 321);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(211, 58);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbDiet
            // 
            cmbDiet.FormattingEnabled = true;
            cmbDiet.Location = new Point(138, 204);
            cmbDiet.Margin = new Padding(3, 4, 3, 4);
            cmbDiet.Name = "cmbDiet";
            cmbDiet.Size = new Size(194, 33);
            cmbDiet.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 12);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 31);
            txtNombre.TabIndex = 11;
            // 
            // lblAlimentacion
            // 
            lblAlimentacion.AutoSize = true;
            lblAlimentacion.Location = new Point(5, 207);
            lblAlimentacion.Name = "lblAlimentacion";
            lblAlimentacion.Size = new Size(129, 25);
            lblAlimentacion.TabIndex = 10;
            lblAlimentacion.Text = "Alimentacion:  ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(5, 84);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(61, 25);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre: ";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(5, 145);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(58, 25);
            lblPeso.TabIndex = 15;
            lblPeso.Text = "Peso: ";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 558);
            splitter1.TabIndex = 17;
            splitter1.TabStop = false;
            // 
            // pnlFormAnimal
            // 
            pnlFormAnimal.Controls.Add(numUpDnPeso);
            pnlFormAnimal.Controls.Add(numUpEdad);
            pnlFormAnimal.Controls.Add(lblNombre);
            pnlFormAnimal.Controls.Add(lblEdad);
            pnlFormAnimal.Controls.Add(lblAlimentacion);
            pnlFormAnimal.Controls.Add(txtNombre);
            pnlFormAnimal.Controls.Add(lblPeso);
            pnlFormAnimal.Controls.Add(cmbDiet);
            pnlFormAnimal.Controls.Add(btnCrear);
            pnlFormAnimal.Location = new Point(84, 150);
            pnlFormAnimal.Name = "pnlFormAnimal";
            pnlFormAnimal.Size = new Size(382, 395);
            pnlFormAnimal.TabIndex = 19;
            // 
            // numUpDnPeso
            // 
            numUpDnPeso.Location = new Point(129, 139);
            numUpDnPeso.Name = "numUpDnPeso";
            numUpDnPeso.Size = new Size(111, 31);
            numUpDnPeso.TabIndex = 20;
            // 
            // numUpEdad
            // 
            numUpEdad.Location = new Point(129, 78);
            numUpEdad.Name = "numUpEdad";
            numUpEdad.Size = new Size(111, 31);
            numUpEdad.TabIndex = 19;
            // 
            // cmbTipoAnimal
            // 
            cmbTipoAnimal.FormattingEnabled = true;
            cmbTipoAnimal.Location = new Point(336, 99);
            cmbTipoAnimal.Name = "cmbTipoAnimal";
            cmbTipoAnimal.Size = new Size(182, 33);
            cmbTipoAnimal.TabIndex = 20;
            cmbTipoAnimal.SelectedValueChanged += cmbTipoAnimal_SelectedValueChanged;
            // 
            // lblTipoAnimal
            // 
            lblTipoAnimal.AutoSize = true;
            lblTipoAnimal.Location = new Point(31, 102);
            lblTipoAnimal.Name = "lblTipoAnimal";
            lblTipoAnimal.Size = new Size(299, 25);
            lblTipoAnimal.TabIndex = 21;
            lblTipoAnimal.Text = "Elija que tipo de animal desea crear: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(471, 13);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 36);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // AnimalUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 558);
            Controls.Add(btnVolver);
            Controls.Add(lblTipoAnimal);
            Controls.Add(cmbTipoAnimal);
            Controls.Add(pnlFormAnimal);
            Controls.Add(splitter1);
            Controls.Add(lblAnimal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnimalUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimalUI";
            pnlFormAnimal.ResumeLayout(false);
            pnlFormAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDnPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimal;
        private Button btnCrear;
        private ComboBox cmbDiet;
        private TextBox txtNombre;
        private Label lblAlimentacion;
        private Label lblEdad;
        private Label lblNombre;
        private Label lblPeso;
        private Splitter splitter1;
        private Panel pnlFormAnimal;
        private NumericUpDown numUpEdad;
        private ComboBox cmbTipoAnimal;
        private Label lblTipoAnimal;
        private ErrorProvider errorProvider1;
        private NumericUpDown numUpDnPeso;
        private Button btnVolver;
    }
}