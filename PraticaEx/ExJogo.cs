using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExJogo
{
    internal class Personagem
    {
        public void Atacar(string tipoAtaque)
        {
            if (tipoAtaque == "Espada")
            {
                Console.WriteLine("Ataque com espada! Dano físico.");
            }
            else if (tipoAtaque == "Arco")
            {
                Console.WriteLine("Ataque com arco! Dano à distância.");
            }
            else if (tipoAtaque == "Magia")
            {
                Console.WriteLine("Ataque mágico! Dano elemental.");
            }
            else if (tipoAtaque == "Punho")
            {
                Console.WriteLine("Ataque com punho! Dano básico.");
            }
            else
            {
                throw new Exception("Tipo de ataque inválido");
            }
        }
    }
}

