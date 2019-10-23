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
    /// Interaction logic for Ex2Pencils.xaml
    /// </summary>
    public partial class Ex2Pencils : Window
    {
        public Ex2Pencils()
        {
            InitializeComponent();
        }

        //Consts
        const decimal SMALL_ORDER = 0.25m;
        const decimal LARGE_ORDER = 0.20m;

        private void BtnPlaceOrder_Click(object sender, RoutedEventArgs e)
        {

            //Converting Textbox
            decimal order = Convert.ToDecimal(txtNumPencils.Text);

            //Calculating Order Prices
            if (order < 100)
            {
                decimal smOrd1 = order * SMALL_ORDER;
                tbDisplay.Text = (smOrd1.ToString("c"));
            }
            else if (order >= 100)
            {
                decimal lgOrd1 = order * LARGE_ORDER;
                tbDisplay.Text = (lgOrd1.ToString("c"));
            }

        }
    }
}
