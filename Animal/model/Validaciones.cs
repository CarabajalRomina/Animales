using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace animales.model
{
    internal class Validaciones
    {
        private static readonly Validaciones validaciones = new Validaciones();

        private Validaciones() { }

        public static Validaciones GetValidaciones() {  return validaciones; }


        public bool ValidarCadena(string cadena)
        {
            return Regex.IsMatch(cadena, @"^[a-zA-Z\s]+$");
        }

        public bool ValidarNumero(string numero)
        {
            return Regex.IsMatch(numero, @"^[0-1,]+$");
        }

      

    }
}
