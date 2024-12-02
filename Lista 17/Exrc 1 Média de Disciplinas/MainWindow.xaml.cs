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

namespace Exrc_1_Média_de_Disciplinas
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

        private void InserirS(object sender, RoutedEventArgs e)
        {
            DisciplinaSemestral x = new DisciplinaSemestral(
            sNome.Text, int.Parse(s1bim.Text), int.Parse(s2bim.Text),
            int.Parse(sFinal.Text));
            listar.Items.Add(x);
        }

        private void InserirA(object sender, RoutedEventArgs e)
        {
            DisciplinaAnual x = new DisciplinaAnual(
            aNome.Text, int.Parse(a1bim.Text), int.Parse(a2bim.Text),
            int.Parse(a3bim.Text), int.Parse(a4bim.Text),
            int.Parse(afinal.Text));
            listar.Items.Add(x);
        }

        private void Media(object sender, RoutedEventArgs e)
        {
            IMedia x = listar.SelectedItem as IMedia;
            txtMedia.Text = $"Média = {x.GetMedia().ToString()}";
        }
    }
}
