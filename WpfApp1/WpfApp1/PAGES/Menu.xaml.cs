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
using static WpfApp1.View_model.Items;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Page1Menu.xaml
    /// </summary>
    public partial class Page1Menu : Page
    {
        public Page1Menu()
        {
            InitializeComponent();           
            WpfApp1.View_model.Items cars = new View_model.Items();
            var lst = cars.Refresh();
            DG.ItemsSource = lst;
        }
        

    }

}
