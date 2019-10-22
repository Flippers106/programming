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

namespace FieldDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int total;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            //int total = 0;
            int num = Convert.ToInt32(txtRun.Text);
            total += num;
            txtRun.Text = string.Empty;
            txtRun.Focus();
           // MessageBox.Show(total.ToString());
        }

        private void BtnTotal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(total.ToString());
        }
    }
}
