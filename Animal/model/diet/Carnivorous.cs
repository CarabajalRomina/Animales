using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using animales;
using animales.interfaces;

namespace animales.model.diet
{
    internal class Carnivorous : IDiet
    {
        static int id = 1;
        public bool CanEat(IFood food)
        {
            bool aux;
            if (food != null && food is AnimalFood)
            {
                aux = true;
            }
            else aux = false;

            return aux;
        }

        public override string ToString()
        {
            return $"Dieta: Carnivoro ";
        }
    }

   
}
