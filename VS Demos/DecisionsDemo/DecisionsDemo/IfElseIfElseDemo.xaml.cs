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
    /// Interaction logic for IfElseIfElseDemo.xaml
    /// </summary>
    public partial class IfElseIfElseDemo : Window
    {
        private const int NUM_SCORES = 5;

        public IfElseIfElseDemo()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double score1 = Convert.ToDouble(txtScore1.Text);
            double score2 = Convert.ToDouble(txtScore2.Text);
            double score3 = Convert.ToDouble(txtScore3.Text);
            double score4 = Convert.ToDouble(txtScore4.Text);
            double score5 = Convert.ToDouble(txtScore5.Text);

            double average = (score1 + score2 + score3 + score4 + score5) / NUM_SCORES;

            tbDisplay.Text = Math.Round(average,2).ToString();

            // DISPLAY THE LETTER GRADE TO THE USER
            // 90 and above A
            // 80-89 B
            // 70-79 C
            // 60-69 D
            // Below 60 F

            if (average >= 90)
            {
                tbDisplay.Text="A";
            }

            else if (average >= 80)
            {
                tbDisplay.Text = "B";
            }

            else if (average >= 70)
            {
                tbDisplay.Text = "C";
            }

            else if (average >= 60)
            {
                tbDisplay.Text = "D";
            }

            else if (average <= 60)
            {
                tbDisplay.Text = "F";
            }
        }
    }
    
}
