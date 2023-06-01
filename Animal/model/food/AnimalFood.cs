using animales.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.model
{
    internal class AnimalFood : IFood
    {
        int Id;
        private static int GlobalCount;
        string Name { get; set; }
        int Calories { get; set; }

        public AnimalFood() { }

        public AnimalFood(string name, int calories)
        {
            Id = ++GlobalCount;
            NAME = name;
            CALORIES = calories;
        }

        public string NAME
        {
            set
            {
                if (value.Length > 1)
                {
                    Console.WriteLine("Entro en la validacion name");
                    Name = value;
                }
                else Console.WriteLine("EL NOMBRE TIENE QUE TENER DOS O MAS LETRAS");

            }
        }

        public int CALORIES
        {
            set
            {
                if(value > 0)
                {
                    Calories = value;
                }
                else Console.WriteLine("EL NOMBRE TIENE QUE TENER DOS O MAS LETRAS");

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
            return $"Id: {Id}, nombre: {Name}, calorias: {Calories}";
        }
    }
}
