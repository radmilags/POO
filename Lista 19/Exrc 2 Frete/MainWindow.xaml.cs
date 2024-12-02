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

namespace Exrc_2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            if (txtS.Text == "")
            {
                Frete f = new Frete(double.Parse(txtD.Text), double.Parse(txtP.Text));
                txtF.Text = f.CalcFrete().ToString();
            }
            else
            {
                FreteExpresso fe = new FreteExpresso(double.Parse(txtD.Text), double.Parse(txtP.Text), Convert.ToDecimal(txtS.Text));
                txtF.Text = fe.CalcFrete().ToString();
            }
        }
    }
}