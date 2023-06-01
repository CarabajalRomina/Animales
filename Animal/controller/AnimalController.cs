using animales.interfaces;
using animales.model.tipoAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.controller
{
    internal class AnimalController: IController
    {
        private static readonly IController animalController = new AnimalController();

        private AnimalController() { }
        public static IController GetController()
        {
            return animalController;
        }

        public IAnimal createAnimalTerrestial(string nombre, decimal weigth, int age, IDiet diet)
        {
            return new Terrestrial(nombre,weigth,age,diet);
        }

        public IAnimal createAnimalAeroTerrestre(string nombre, decimal weigth, int age, IDiet diet)
        {
            return new TerrestrialAir(nombre, weigth, age, diet);
        }

        public IAnimal createAnimalAquatic(string nombre, decimal weigth, int age, IDiet diet)
        {
            return new Aquatic(nombre, weigth, age, diet);
        }


    }
}
