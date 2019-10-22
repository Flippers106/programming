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

namespace DecisionsDemo
{
    /// <summary>
    /// Interaction logic for IfDemo.xaml
    /// </summary>
    public partial class IfDemo : Window
    {
        private const int HIGH_SCORE = 90;
        private const int NUM_SCORES = 5;

        public IfDemo()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Calculate the average and display it in the label

            decimal Avg1 = Convert.ToDecimal(txtScore1.Text);
            decimal Avg2 = Convert.ToDecimal(txtScore2.Text);
            decimal Avg3 = Convert.ToDecimal(txtScore3.Text);
            decimal Avg4 = Convert.ToDecimal(txtScore4.Text);
            decimal Avg5 = Convert.ToDecimal(txtScore5.Text);

            decimal Ans1 = Avg1 + Avg2 + Avg3 + Avg4 + Avg5;
            decimal Ans2 = Ans1 / NUM_SCORES;

            // Show a congratulations message to the user if they get a high score

            if (Ans1 >= HIGH_SCORE)
            {
                MessageBox.Show("Congrgulations! You have a high score!");
            }
        }
    }
}
