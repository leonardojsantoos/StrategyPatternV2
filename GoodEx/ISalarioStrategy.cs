using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEx
{
    public interface ISalarioStrategy
    {
        double Calcular(double salarioBase);
    }
}
