using Models;
using System;

namespace ConsoleApp4ExtensionMethods
{
    class Program
    {
        /// <summary>
        /// extiende methods de una clase afuera de la clase, solo debe cumplir dos cosas
        /// la clase debe ser estatica
        /// un input parameter debe ser el objeto de esta manera: this Calculadora calculadora
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(10, 12);
            Console.WriteLine($"suma: {calc.Sum()}");
            Console.WriteLine($"mult: {calc.Mult()}");
        }
    }
}
