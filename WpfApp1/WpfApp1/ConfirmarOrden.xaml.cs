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
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para ConfirmarOrden.xaml
    /// </summary>
    public partial class ConfirmarOrden : Window
    {
        public ConfirmarOrden()
        {
            InitializeComponent();
        }

        private void BtnConfrmOrdn_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
        
        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
