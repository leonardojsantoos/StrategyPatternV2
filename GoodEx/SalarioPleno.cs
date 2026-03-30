using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEx
{
    public class SalarioPleno : ISalarioStrategy
    {
        public double Calcular(double salarioBase)
        {
            return salarioBase * 1.2;
        }
    }
}
