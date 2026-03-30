using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadEx
{
    internal class CalculadoraSalario
    {
        public double Calcular(double salarioBase, string cargo)
        {
            if (cargo == "Junior")
                return salarioBase + (salarioBase * 0.1);

            else if (cargo == "Pleno")
                return salarioBase + (salarioBase * 0.2);

            else if (cargo == "Senior")
                return salarioBase + (salarioBase * 0.3);

            throw new Exception("Cargo inválido");
        }
    }
}
