using animales.controller;
using animales.interfaces;
using animales.model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animales.view
{
    public partial class FoodUI : Form
    {
        IController FoodControl = FoodController.GetController();
        List<string> listTipoAlimento = new List<string> { "Vegetal", "Animal" };


        public FoodUI()
        {
            InitializeComponent();
            cargarComboBox(cmbTipoAlim, listTipoAlimento);

        }


        public void CreateFood()
        {
            switch (cmbTipoAlim.SelectedItem.ToString())
            {
                case "Vegetal":
                    ((FoodController)FoodControl).CreateFoodVegetal(txtNombre.Text, Convert.ToInt32(txtCalorias.Text));
                    break;

                case "Animal":
                    ((FoodController)FoodControl).CreateFoodAnimal(txtNombre.Text, Convert.ToInt32(txtCalorias.Text));
                    break;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CreateFood();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            InicioView inicioView = new InicioView();
            inicioView.Show();
        }

        public void cargarComboBox(ComboBox cmb, List<string> listTipoAlimento)
        {
            foreach (var e in listTipoAlimento)
            {
                cmb.Items.Add(e);
            }
        }

    }
}
