using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.classes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateIntegral();

        }
        private void CalculateIntegral()
        {
            double upperBound = Convert.ToDouble(tbUpperBound.Text);
            double lowerBound = Convert.ToDouble(tbLowerBound.Text);
            int count = Convert.ToInt32(tbCount.Text);

            INTEGRALCALCULATOR calculatorIntegral = GetCalculator();
            double answer = calculatorIntegral.Calculate(lowerBound, upperBound, count, x => 10 * x - Math.Log(14 * x));
            tbAnswer.Text = answer.ToString();
        }

        private INTEGRALCALCULATOR GetCalculator()
        {
            switch (cmbBoxIntegralType.SelectedIndex)
            {
                case 0:
                    return new RECTANGLECALCULATOR();
                case 1:
                    return new TRAPCALCULATOR();
                default:
                    return new RECTANGLECALCULATOR();
            }

        }
    }
}
