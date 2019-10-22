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
    /// Interaction logic for IfElseDemo.xaml
    /// </summary>
    public partial class IfElseDemo : Window
    {
        public IfElseDemo()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, RoutedEventArgs e)
        {
            // if the user is older than 19, tell them that they are of legal age
            // otherwise, tell them that they are still underage

            int Age = Convert.ToInt32(txtAge.Text);
            
            if (Age >= 19)
            {
                MessageBox.Show("You are of legal age");
            }

            else
            {
                MessageBox.Show("You are NOT of legal age");
            }
        }
    }
}
