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
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            FoodUI foodUI = new FoodUI();
            foodUI.ShowDialog();

        }
    }
}
