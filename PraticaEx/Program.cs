using System;
using ExJogo;

namespace PraticaEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personagem = new Personagem();

            Console.WriteLine("Escolha o ataque: Espada, Arco, Magia, Punho");
            string tipo = Console.ReadLine();

            personagem.Atacar(tipo);
        }
    }
}
//Aplique o Strategy pattern como no GoodEx, com interface, estrategias concretas e contexto
