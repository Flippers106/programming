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

namespace SimpleCalculator
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber + secondNumber;
            tbAnswer.Text = answer.ToString();
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber2 = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber2 = Convert.ToDouble(txtSecondNumber.Text);
            double answer2 = firstNumber2 - secondNumber2;
            tbAnswer.Text = answer2.ToString();
        }

        private void BtnMultiple_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber3 = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber3 = Convert.ToDouble(txtSecondNumber.Text);
            double answer3 = firstNumber3 * secondNumber3;
            tbAnswer.Text = answer3.ToString();
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber4 = Convert.ToDecimal(txtFirstNumber.Text);
            decimal secondNumber4 = Convert.ToDecimal(txtSecondNumber.Text);
            decimal answer4 = firstNumber4 / secondNumber4;
            tbAnswer.Text = answer4.ToString();
        }

        private void BtnModulus_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber5 = Convert.ToDecimal(txtFirstNumber.Text);
            decimal secondNumber5 = Convert.ToDecimal(txtSecondNumber.Text);
            decimal answer5 = firstNumber5 % secondNumber5;
            tbAnswer.Text = answer5.ToString();
        }
    }
}
