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
        PlantFood plantfood =  new PlantFood();
        FoodUI food;
        public AnimalUI()
        {
            InitializeComponent();
            
        }

        public void createAnimal()
        {
            switch(cmbAlimentacion.SelectedItem.ToString())
            {
                case "Terrestre":
                    break;
            }
        }
    }
}
