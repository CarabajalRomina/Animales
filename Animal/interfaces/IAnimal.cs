﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales.interfaces
{
    internal interface IAnimal
    {
        void Sleep();
        void Feed(IFood food);
        string GetSpecie();
        float GetWeight();
        int GetAge();
        IDiet GetDiet();
        bool Move(int x, int y);
    }
}
