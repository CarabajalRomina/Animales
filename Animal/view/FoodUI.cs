using animales.controller;
using animales.interfaces;
using animales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace animales.view
{
    public partial class FoodUI : Form
    {
        IController FoodControl = FoodController.GetController();

        public FoodUI()
        {
            InitializeComponent();
            cmbTipoAlim.Items.Add("Vegetal");
            cmbTipoAlim.Items.Add("Animal");
        }


        private void CreateAlimento()
        {
            switch (cmbTipoAlim.SelectedItem.ToString())
            {

                case "Vegetal":

                    if (((FoodController)FoodControl).ValidarCadena(txtNombre.Text) && ((FoodController)FoodControl).ValidarNumero(txtCalorias.Text))
                    {

                    }
                    food = new PlantFood(txtNombre.Text, Convert.ToInt32(txtCalorias.Text));
                    Console.WriteLine(food.ToString());
                    break;

                case "Animal":
                    food = new AnimalFood(txtNombre.Text, Convert.ToInt32(txtCalorias.Text));
                    Console.WriteLine(food.ToString());
                    break;
            }
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            CreateAlimento();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioView inicioView = new InicioView();
            inicioView.Show();

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ErrorProvider.SetError(txtNombre, "Debe introducir el nombre");
            }
        }
    }
}
