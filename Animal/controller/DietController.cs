using animales.interfaces;
using animales.model;
using animales.model.diet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.controller
{
    internal class DietController: IController
    {
        private static readonly IController dietController = new DietController();

        private DietController() { }

        public static IController GetController()
        {
            return dietController;
        }


        public IDiet CreateCarnivorousDiet()
        {
            return new Carnivorous();
        }

        public IDiet CreateHerbivorousDiet()
        {
            return new Herbivorous();
        }

        public IDiet CreateOmnivoreDiet()
        {
            return new Omnivore();
        }
    }
}
