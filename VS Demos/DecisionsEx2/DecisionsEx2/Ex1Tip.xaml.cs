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
using System.Windows.Shapes;

namespace DecisionsEx2
{
    /// <summary>
    /// Interaction logic for Ex1Tip.xaml
    /// </summary>
    public partial class Ex1Tip : Window
    {
        public Ex1Tip()
        {
            InitializeComponent();
        }

        const decimal TIP_PERC_1 = 0.20m;
        const decimal TIP_PERC_2 = 0.15m;

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {

            //Converting textbox to decimal

            decimal bill1 = Convert.ToDecimal(txtBillAmount.Text);

            //Calculating tip
            
            if (bill1 == 0)
            {
                MessageBox.Show("The bill amount must be more than $0.00");
            }

            else if (bill1 < 1)
            {
                MessageBox.Show("Mininum amount for a tip is a $1.00 bill");
            }

            else if (bill1 <= 10)
            {
                decimal calc1 = bill1 * TIP_PERC_1;
                MessageBox.Show($"The tip amount is {calc1.ToString("c")}");
            }

            if (bill1 > 10)
            {
                decimal calc2 = bill1 * TIP_PERC_2;

                if (calc2 <= 5)
                {
                    MessageBox.Show("The tip amount is $5.00");
                }

                else if (calc2 > 5)
                {
                    MessageBox.Show($"The tip amount is {calc2.ToString("c")}");
                }
            }
        }
    }
}
