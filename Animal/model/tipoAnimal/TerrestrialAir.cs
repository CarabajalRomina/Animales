using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model.tipoAnimal
{
    internal class TerrestrialAir : Animal
    {
        int Id;
        static int globalCount;
        readonly int MaxEnergy = 100;


        public TerrestrialAir(string nameSpecie, decimal weigth, int age, IDiet diet) : base(nameSpecie, weigth, age, diet)
        {
            Id = ++globalCount;
            NameSpecie = nameSpecie;
            Weight = weigth;
            Age = age;
            Diet = diet;
            Energy = MaxEnergy;
        }

        public override void Feed(IFood food)
        {
            if (Diet.CanEat(food))
            {
                UpdateEnergy(food.GetCalories());
                Console.WriteLine("mm que ricoo" + $"{Diet}");
            }
            else
            {
                Console.WriteLine("No puedo comer eso soy " + $"{Diet}");
            }
        }

     
        public override bool Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            UpdateEnergy(MaxEnergy / 2);
        }

        private void UpdateEnergy(int energy)
        {
            if (energy + Energy > MaxEnergy)
            {
                Energy = MaxEnergy;
            }
            else Energy =+ energy;
        }

        public override string ToString()
        {
            return $"Id:{Id}, tipo de animal: Aero-terrestre, nombre de especie: {NameSpecie}, peso: {Weight}, edad: {Age}, {Diet}  ";
        }
    }
}
