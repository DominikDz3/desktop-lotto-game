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


namespace LottoGame
{
    /// <summary>
    /// Logika interakcji dla klasy CheckLuckyNumbers.xaml
    /// </summary>
    public partial class CheckLuckyNumbers : Page
    {
        public CheckLuckyNumbers()
        {
            InitializeComponent();
        }
        public void OnLoad(object sender, RoutedEventArgs e)
        {
            Number1.Text = Globals.playerNumbers[0].ToString(); 
        }
    }

}
