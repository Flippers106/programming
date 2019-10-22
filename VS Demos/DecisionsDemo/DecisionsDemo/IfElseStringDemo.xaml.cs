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
    /// Interaction logic for IfElseStringDemo.xaml
    /// </summary>
    public partial class IfElseStringDemo : Window
    {
        public IfElseStringDemo()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer.Text == "yes")
            {
                MessageBox.Show("Of course you do");
            }

            else if (txtAnswer.Text == "no")
            {
                MessageBox.Show("???");
            }
            
            else
            {
                MessageBox.Show("I dont understand your response");
            }
        }
    }
}
