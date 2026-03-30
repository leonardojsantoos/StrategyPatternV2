using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEx
{
    public class CalculadoraSalario
    {
        private ISalarioStrategy _strategy;

        public CalculadoraSalario(ISalarioStrategy strategy)
        {
            _strategy = strategy;
        }

        // Permite trocar a estratégia em tempo de execução
        public void SetStrategy(ISalarioStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Calcular(double salarioBase)
        {
            return _strategy.Calcular(salarioBase);
        }
    }
}
