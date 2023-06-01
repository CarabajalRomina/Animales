using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model.diet
{
    internal class Herbivorous : IDiet
    {
        static int id = 2;
        public bool CanEat(IFood food)
        {
            bool aux;
            if (food != null && food is PlantFood)
            {
                aux = true;
            }
            else aux = false;

            return aux;
        }

        public override string ToString()
        {
            return $"Dieta: Hervivoro ";
        }
    }
}
