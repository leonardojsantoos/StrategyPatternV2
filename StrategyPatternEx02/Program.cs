using System;
using BadEx;

namespace StrategyPatternEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculadoraSalario();
            var salario = calc.Calcular(3000, "Senior");

            Console.WriteLine(salario);
        }
    }
}