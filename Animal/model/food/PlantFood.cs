using animales.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model
{
    internal class PlantFood : IFood
    {
        int id;
        string name;
        int calories;
        private static int globalCount;
        
        public PlantFood()
        {

        }
        public PlantFood(string name , int calories)
        {
            this.id = ++globalCount;
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
            return $"Id: {id}, Nombre: {name}, calorias: {calories}";
        }
    }
}
