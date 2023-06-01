using animales.controller;
using animales.interfaces;
using animales.model;
using animales.model.tipoAnimal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animales.view
{
    public partial class AnimalUI : Form
    {

        IController DietControl = DietController.GetController();
        IController AnimalControl = AnimalController.GetController();
        IDiet Diet;
        IAnimal animal;
        List<string> listDiet = new List<string> { "Hervivoro", "Carnivoro", "Omnivoro " };
        List<string> listTipoAnimal = new List<string> { "Terrestre", "Acuatico", "Aero-terrestre" };


        public AnimalUI()
        {
            InitializeComponent();
            cargarComboBox(cmbTipoAnimal, listTipoAnimal);
            cargarComboBox(cmbDiet, listDiet);
            pnlFormAnimal.Visible = false;
        }


        private IDiet TipoDietaSelected()
        {
            switch (cmbDiet.SelectedItem.ToString())
            {
                case "Hervivoro":
                    Diet = ((DietController)DietControl).CreateHerbivorousDiet();
                    break;

                case "Carnivoro":
                    Diet = ((DietController)DietControl).CreateCarnivorousDiet();
                    break;

                case "Ovnivoro":
                    Diet = ((DietController)DietControl).CreateOmnivoreDiet();
                    break;
            }
            return Diet;
        }

        public void createAnimal()
        {   
            switch (cmbTipoAnimal.SelectedItem.ToString())
            {
                case "Terrestre":
                    animal = ((AnimalController)AnimalControl).createAnimalTerrestial(txtNombre.Text, numUpDnPeso.Value, Convert.ToInt32(numUpEdad.Value), TipoDietaSelected());
                    Console.WriteLine($" soy terreste {animal}");
                    break;

                case "Acuatico":
                    animal = ((AnimalController)AnimalControl).createAnimalAquatic(txtNombre.Text, numUpDnPeso.Value, Convert.ToInt32(numUpEdad.Value), TipoDietaSelected());
                    Console.WriteLine($" soy acuatico {animal}");
                    break;

                case "Aero-terrestre":
                    animal = ((AnimalController)AnimalControl).createAnimalAeroTerrestre(txtNombre.Text, numUpDnPeso.Value, Convert.ToInt32(numUpEdad.Value), TipoDietaSelected());
                    Console.WriteLine($" soy aeroterrestre {animal}");

                    break;
            }
        }

        private void cmbTipoAnimal_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlFormAnimal.Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            createAnimal();
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
