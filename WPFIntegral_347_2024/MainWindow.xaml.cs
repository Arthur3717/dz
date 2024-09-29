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
using WPFIntegral_347_2024.Classes;

namespace WPFIntegral_347_2024
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

            ICalculatorIntegral calculatorIntegral = GetCalculator();
            double answer = calculatorIntegral.Calculate(lowerBound, upperBound, count, x => 7 * x - Math.Log(7 * x) + 8);
            tbAnswer.Text = answer.ToString();
        }

        private ICalculatorIntegral GetCalculator()
        {
            switch (cmbBoxIntegralType.SelectedIndex)
            {
                case 0:
                    return new MidpointRectangleCalculator();
                case 1:
                    return new TrapCalculator();
                default:
                    return new MidpointRectangleCalculator();
            }

        }
    }
}