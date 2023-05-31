using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model
{
    internal class AnimalFood : IFood
    {
        int id;
        private static int globalCount;
        string name;
        int calories;

        public AnimalFood(string name, int calories)
        {
            id = ++globalCount;
            this.name = name;   
            this.calories = calories;
        }

        public int GetCalories()
        {
            return calories;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return $"Id: {id}, nombre: {name}, calorias: {calories}";
        }
    }
}
