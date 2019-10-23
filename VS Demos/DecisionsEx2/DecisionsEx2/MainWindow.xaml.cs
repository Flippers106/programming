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

namespace DecisionsEx2
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

        private void btnEx1_Click(object sender, RoutedEventArgs e)
        {
            Ex1Tip w = new Ex1Tip();
            w.Show();
        }

        private void btnEx2_Click(object sender, RoutedEventArgs e)
        {
            Ex2Pencils w = new Ex2Pencils();
            w.Show();
        }

        private void btnEx3_Click(object sender, RoutedEventArgs e)
        {
            Ex3TwoNumbers w = new Ex3TwoNumbers();
            w.Show();
        }

        private void btnEx4_Click(object sender, RoutedEventArgs e)
        {
            Ex4FruitStand w = new Ex4FruitStand();
            w.Show();
        }
    }
}
