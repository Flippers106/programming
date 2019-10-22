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

namespace EventsDemo
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

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TbThankYou_Loaded(object sender, RoutedEventArgs e)
        {
            tbThankYou.Visibility = Visibility.Hidden;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Clicked the OK button");
            MessageBox.Show("Happy Tuesday!");
        }

        private void TxtLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtLastName.FontWeight = FontWeights.Bold;
            tbThankYou.Visibility = Visibility.Visible;
        }

        private void TxtLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = txtLastName.Text;
            txtLastName.Text = string.Empty;
        }

        private void TbThankYou_MouseEnter(object sender, MouseEventArgs e)
        {
            tbThankYou.Foreground = Brushes.Red;
        }

        private void TbThankYou_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Black;
        }

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show(txtFirstName.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Bisque;
            tbThankYou.Visibility = Visibility.Visible;
        }

    }
}
