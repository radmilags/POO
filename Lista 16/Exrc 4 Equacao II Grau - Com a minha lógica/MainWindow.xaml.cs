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

namespace Exrc_4_Equacao_II_Grau___Com_a_minha_lógica
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
            EquacaoIIGrau eq = new EquacaoIIGrau();
            eq.SetABC(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text));
            if (eq.RaizesReais())
            { txtD.Text = eq.Delta().ToString("0.00"); }
            txtX1.Text = eq.X1();
            txtX2.Text = eq.X2();
            MessageBox.Show("Pode não ser exatamente o que foi pedido, mas meus neurônios trabalharam mais e conseguiram chegar a um resultado.");
        }
    }
}
