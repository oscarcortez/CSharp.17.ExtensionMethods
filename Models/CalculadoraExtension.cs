using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class CalculadoraExtension
    {
        public static int Mult (this Calculadora calculadora)
        {
            return calculadora.LeftValue * calculadora.RightValue;
        }       
    }
}
