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

namespace Exrc_3_Retângulo
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

        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            Retangulo r = new Retangulo();
            r.SetAltura(double.Parse(txtH.Text));
            r.SetBase(double.Parse(txtB.Text));
            txtA.Text = r.CalcArea().ToString("0.00");
            txtD.Text = r.CalcDiagonal().ToString("0.00");
        }
    }
}
