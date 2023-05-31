namespace animales.view
{
    partial class FoodUI
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
            label1 = new Label();
            lblNombre = new Label();
            lblCalorias = new Label();
            lblTipoAlim = new Label();
            txtNombre = new TextBox();
            txtCalorias = new TextBox();
            cmbTipoAlim = new ComboBox();
            btnCrear = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 45);
            label1.Name = "label1";
            label1.Size = new Size(253, 40);
            label1.TabIndex = 0;
            label1.Text = "Crear alimento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(51, 154);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCalorias
            // 
            lblCalorias.AutoSize = true;
            lblCalorias.Location = new Point(51, 241);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(83, 25);
            lblCalorias.TabIndex = 2;
            lblCalorias.Text = "Calorias: ";
            // 
            // lblTipoAlim
            // 
            lblTipoAlim.AutoSize = true;
            lblTipoAlim.Location = new Point(51, 325);
            lblTipoAlim.Name = "lblTipoAlim";
            lblTipoAlim.Size = new Size(155, 25);
            lblTipoAlim.TabIndex = 3;
            lblTipoAlim.Text = "Tipo de alimento: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 146);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtCalorias
            // 
            txtCalorias.Location = new Point(177, 234);
            txtCalorias.Margin = new Padding(3, 4, 3, 4);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.Size = new Size(224, 31);
            txtCalorias.TabIndex = 5;
            // 
            // cmbTipoAlim
            // 
            cmbTipoAlim.FormattingEnabled = true;
            cmbTipoAlim.Location = new Point(207, 314);
            cmbTipoAlim.Margin = new Padding(3, 4, 3, 4);
            cmbTipoAlim.Name = "cmbTipoAlim";
            cmbTipoAlim.Size = new Size(194, 33);
            cmbTipoAlim.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(121, 429);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(238, 58);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(424, 16);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 36);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FoodUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 522);
            Controls.Add(btnVolver);
            Controls.Add(btnCrear);
            Controls.Add(cmbTipoAlim);
            Controls.Add(txtCalorias);
            Controls.Add(txtNombre);
            Controls.Add(lblTipoAlim);
            Controls.Add(lblCalorias);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FoodUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alimentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblCalorias;
        private Label lblTipoAlim;
        private TextBox txtNombre;
        private TextBox txtCalorias;
        private ComboBox cmbTipoAlim;
        private Button btnCrear;
        private Button btnVolver;
    }
}