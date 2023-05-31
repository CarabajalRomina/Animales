using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace animales.model
{
    internal class Omnivore : IDiet
    {
        static int id = 3;
        public bool CanEat(IFood food)
        {
            bool aux;
            if (food != null && food is AnimalFood || food is PlantFood)
            {
                aux = true;
            }
            else aux = false;

            return aux;
        }

        public override string ToString()
        {
            return $"Id:{id}, alimentacion:Omnivoro ";
        }
    }
}
