using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animales.model
{
    internal abstract class Animal : IAnimal
    {
        protected int[] position { get; set; } = new int[2];
        protected int energy { get; set; } = 100;
        protected string nameSpecie { get; set; }
        protected float weight { get; set; }
        protected int age { get; set; }
        protected IDiet diet { get; set; }

        public Animal(string nameSpecie, float weigth, int age, IDiet diet)
        {
            this.position[0] = 0;
            this.position[1] = 0;
            this.nameSpecie = nameSpecie;
            this.weight = weigth;
            this.age = age;
            this.energy = 100;
            this.diet = diet;
            int maxEnergy = 100;
            int minEnergy = 0;
        }


            

        public abstract void Feed(IFood food);
        public abstract int GetAge();
        public abstract IDiet GetDiet();
        public abstract string GetSpecie();
        public abstract float GetWeight();
        public abstract bool Move(int x, int y);
        public abstract void Sleep();
    }
}
