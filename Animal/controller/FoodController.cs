using animales.interfaces;
using animales.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace animales.controller
{
    internal class FoodController: IController
    {
        private readonly static IController FoodContr = new FoodController();

        private FoodController(){}

        public static IController GetController()
        {
            return FoodContr;
        }

        public void CreateFood(string name, string calories)
        {

        }

 

        public bool ValidarNumero(string num)
        {
            return Regex.IsMatch(num, @"^[0-1,]+$");
        }

    }
}
