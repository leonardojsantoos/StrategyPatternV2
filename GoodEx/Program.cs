using System;
using GoodEx;

namespace StrategyPatternEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa com estratégia Junior
            var calculadora = new CalculadoraSalario(new SalarioJunior());
            Console.WriteLine("Junior: " + calculadora.Calcular(3000));

            // Troca para Pleno
            calculadora.SetStrategy(new SalarioPleno());
            Console.WriteLine("Pleno: " + calculadora.Calcular(3000));

            // Troca para Senior
            calculadora.SetStrategy(new SalarioSenior());
            Console.WriteLine("Senior: " + calculadora.Calcular(3000));
        }
    }
}