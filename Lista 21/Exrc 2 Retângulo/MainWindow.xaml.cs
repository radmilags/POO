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

namespace Exrc_2_Retangulo
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
            try
            {
                Retangulo r = new Retangulo(double.Parse(txtB.Text), double.Parse(txtH.Text));
                txtA.Text = r.AreaRet().ToString();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}