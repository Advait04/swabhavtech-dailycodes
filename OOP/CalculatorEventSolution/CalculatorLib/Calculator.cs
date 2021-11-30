using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public event Action<string, int, int, double> OnAddOperationComplete = null;
        public event Action<string, int, int, double> OnSubtractOperationComplete = null;

        public void AddNumber(int first, int second)
        {
            double sum = first + second;
            if (OnAddOperationComplete != null) OnAddOperationComplete("Addition", first, second, sum);
        }

        public void SubstractNumber(int first, int second)
        {
            double diff = first - second;
            if (OnSubtractOperationComplete != null) OnSubtractOperationComplete("Substraction", first, second, diff);
        }
    }
}
