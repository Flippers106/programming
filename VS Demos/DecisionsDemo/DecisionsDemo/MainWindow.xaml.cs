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

namespace DecisionsDemo
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

        private void btnIfElseString_Click(object sender, RoutedEventArgs e)
        {
            IfElseStringDemo w = new IfElseStringDemo();
            w.Show();
        }

        private void btnIf_Click(object sender, RoutedEventArgs e)
        {
            IfDemo w = new IfDemo();
            w.Show();
        }

        private void btnIfElse_Click(object sender, RoutedEventArgs e)
        {
            IfElseDemo w = new IfElseDemo();
            w.Show();
        }

        private void btnIfElseIfElse_Click(object sender, RoutedEventArgs e)
        {
            IfElseIfElseDemo w = new IfElseIfElseDemo();
            w.Show();
        }
    }
}
