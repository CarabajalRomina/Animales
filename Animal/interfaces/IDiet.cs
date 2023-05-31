using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using animales.interfaces;

namespace animales.interfaces
{
    internal interface IDiet
    {
        bool CanEat(IFood food);

    }
}
