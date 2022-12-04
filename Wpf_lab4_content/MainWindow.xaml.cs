using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_lab4_content
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double res1Double = rateEuro * sumEuro;
            resSum1.Text = res1Double.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double res2Double = rateGrivna * sumGrivna;
            resSum2.Text = res2Double.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double res3Double = rateDrama * sumDrama;
            resSum3.Text = res3Double.ToString();
        }

        private void Button_Click_inch(object sender, RoutedEventArgs e)
        {
            double inches = Convert.ToDouble(inch.Text);
            meter.Text = Convert.ToString(inches * 0.0254);
        }

        private void Button_Click_feet(object sender, RoutedEventArgs e)
        {
            double feets = Convert.ToDouble(feet.Text);
            meterFeet.Text = Convert.ToString(feets /3.28084);
        }

        private void Button_Click_mile(object sender, RoutedEventArgs e)
        {
            double miles = Convert.ToDouble(mile.Text);
            meterMile.Text = Convert.ToString(miles * 1609.344);
        }

        private void Button_Click_verst(object sender, RoutedEventArgs e)
        {
            double versts = Convert.ToDouble(verst.Text);
            meterVerst.Text = Convert.ToString(versts * 1065);
        }
    }
}
