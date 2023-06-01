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
        protected int[] Position { get; set; } = new int[2];
        protected int Energy { get; set; } = 100;
        protected string NameSpecie { get; set; }
        protected decimal Weight { get; set; }
        protected int Age { get; set; }
        protected IDiet Diet { get; set; }
        


        public Animal(string nameSpecie, decimal weigth, int age, IDiet diet)
        {
            Position[0] = 0;
            Position[1] = 0;
            NameSpecie = nameSpecie;
            Weight = weigth;
            Age = age;
            Diet = diet;
        }

        public abstract void Feed(IFood food);    
        public abstract bool Move(int x, int y);
        public abstract void Sleep();
    }
}
