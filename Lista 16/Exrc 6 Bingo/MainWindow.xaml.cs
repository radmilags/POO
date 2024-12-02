﻿using System;
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

namespace Exrc_6_Bingo
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txt != null) txt.Text = slider.Value.ToString();
        }

        private Bingo b;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = new Bingo();
            b.Iniciar(int.Parse(txt.Text));
            txtNum.Text = "";
            txtNums.Text = "";
            btnSortear.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string n = b.Proximo();
            txtNum.Text = n.ToString();
            if (n != "Fim de Jogo")
            {
                txtNums.Text += n.ToString() + " ";
            }
        }
    }
}
