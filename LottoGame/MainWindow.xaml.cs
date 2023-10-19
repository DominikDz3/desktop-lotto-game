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

namespace LottoGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public void OnLoad(object sender, RoutedEventArgs e)
        {
            Username.Text = Globals.username;
            Balance.Text = Globals.balance.ToString() + " PLN";
        }

        private void NewDrawButton_Click(object sender, RoutedEventArgs e)
        {
            NewDrawPage newdrawpage = new NewDrawPage();
            NewDrawFrame.Navigate(newdrawpage);

            ///BrushConverter bc = new BrushConverter();
            ///BrushConverter fg = new BrushConverter();
            ///NewDrawButton.Background = (Brush)bc.ConvertFrom("#FF2B2B2B");
            ///NewDrawButton.Foreground = (Brush)fg.ConvertFrom("#8C8C8C");
        }

        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {
            Credits credits = new Credits();
            NewDrawFrame.Navigate(credits);

            ///BrushConverter bc = new BrushConverter();
            ///CreditsButton.Background = (Brush)bc.ConvertFrom("#FF2B2B2B");

        }
    }
}
