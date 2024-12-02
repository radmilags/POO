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

namespace Exrc_2_Sequências
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

        PA p;
        Fibonacci f;

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            p = new PA(int.Parse(txtPa.Text));
            ListPA.Items.Add(p.Iniciar());
            ButtonIniciar.IsEnabled = false;
            f = new Fibonacci();
            ListFibo.Items.Add(f.Iniciar());
        }

        private void Button_Proximo(object sender, RoutedEventArgs e)
        {
            ListPA.Items.Add(p.Proximo());
            ListFibo.Items.Add(f.Proximo());
        }
    }
}
