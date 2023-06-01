using animales.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model
{
    internal class PlantFood : IFood
    {
        int Id;
        string Name { get; set; }
        int Calories { get; set; }
        private static int globalCount;
        
        public PlantFood()
        {

        }

        public PlantFood(string name , int calories)
        {
            Id = ++globalCount;
            NAME = name;
            CALORIES = calories;   
        }

        public string NAME
        {
            set
            {
                if (value.Length >= 2 && value != null)
                {
                    Name = value;
                }
                else Console.WriteLine("EL NOMBRE TIENE QUE TENER DOS O MAS LETRAS");
            }
        }

        public int CALORIES
        {
            set
            {
                if (value > 0)
                {
                    Calories = value;
                }
                else Console.WriteLine("LAS CALORIAS NO PUEDEN SER INFERIOR A 0 VUELVA A INTENTAR");

            }
        }

        public int GetCalories()
        {
            return Calories;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Name}, calorias: {Calories}";
        }
    }
}
