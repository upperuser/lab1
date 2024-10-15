using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.classes
{
    public class RectandgleCalculate: IntehralCalculator
    {
        public double Calculate(double lower, double upper, int count, Func <double, double> func)

        {
            if (func == null)
            { throw new ArgumentException("не передана функция"); }
            if (upper < lower)
            { throw new ArgumentException("нижняя граница больше верхней границы"); }
            if (count < 0)
            { throw new ArgumentOutOfRangeException("негатиыный каунт"); }
            double h = (upper - lower) / count;
            double sum = 0.0;
            for (int i = 0; i < count; i++)
            {
                sum += func(lower + i * h);
            }
            return h * sum;
        }
    }
}
