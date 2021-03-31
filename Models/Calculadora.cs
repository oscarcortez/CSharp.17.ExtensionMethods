using System;

namespace Models
{
    public class Calculadora
    {
        public int LeftValue { get; set; }
        public int RightValue { get; set; }

        public Calculadora(int leftValue, int rightValue)
        {
            LeftValue = leftValue;
            RightValue = rightValue;
        }

        public Calculadora()
        {
        }

        public int Sum()
        {
            return LeftValue + RightValue;
        }

    }
}
