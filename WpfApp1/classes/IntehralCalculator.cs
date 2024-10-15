using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.classes
{
    public interface IntehralCalculator
    {
        double Calculate(double lower, double upper, int count, Func<double, double> func);

    }
}
