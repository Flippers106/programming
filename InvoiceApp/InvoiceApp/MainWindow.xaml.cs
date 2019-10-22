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

namespace InvoiceApp
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercentage = Convert.ToDecimal(tbDiscountPerc.Text);
            decimal discountAmt = subTotal * (discountPercentage/100);
            decimal total = subTotal - discountAmt;

            tbDiscount.Text = discountAmt.ToString("c");
            tbTotal.Text = total.ToString("c");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtSubTotal.Text = string.Empty;
            tbDiscount.Text = string.Empty;
            tbTotal.Text = string.Empty;
            txtSubTotal.Focus();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
