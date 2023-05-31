using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model.tipoAnimal
{
    internal class Aquatic : Animal
    {
        int id;
        private static int globalCount;
       

        public Aquatic(string nameSpecie, float weigth, int age, IDiet diet) : base(nameSpecie, weigth, age, diet)
        {
            this.id = ++globalCount;
        }

 
        public override void Feed(IFood food)
        {
            if (diet.CanEat(food))
            {
                UpdateEnergy(food.GetCalories());
                Console.WriteLine("mm que ricoo" + $"{diet}");
            }
            else
            {
                Console.WriteLine("No puedo comer eso soy " + $"{diet}");
            }
        }

        public override int GetAge()
        {
            return age;
        }

        public override IDiet GetDiet()
        {
            return diet;
        }

        public override string GetSpecie()
        {
            return nameSpecie;
        }

        public override float GetWeight()
        {
            return weight;
        }

        public override bool Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            UpdateEnergy(maxEnergy / 2);
        }

        private void UpdateEnergy(int energy)
        {
            if (energy + this.energy > maxEnergy)
            {
                this.energy = maxEnergy;
            }
            else this.energy = +energy;
        }

        public override string ToString()
        {
            return $"Id:{id}, nombre de especie: {nameSpecie}, peso: {weight}, edad: {age}, alimentacion: {diet}  ";
        }
    }
}
