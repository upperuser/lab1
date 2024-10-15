using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.classes
{
    public class TrapCalculate : IntehralCalculator
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            if (func== null)
            { throw new ArgumentException("не передана функция"); }
            if (upper < lower)
            { throw new ArgumentException("нижняя граница больше верхней границы"); }
            if (count < 0)
            { throw new ArgumentOutOfRangeException("негатиыный каунт"); }
            double partlength = (upper - lower) / count;
            double answer = 0;
            double x0 = lower;
            for (int i = 0; i < count; i++)
            {
                x0 += partlength;
                answer += func(x0);
            }
            answer += (func(upper) - func(lower)) / 2;
            answer *= partlength;
            return answer;
        }
    }
}
