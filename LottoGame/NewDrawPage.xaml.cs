using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Logika interakcji dla klasy NewDrawPage.xaml
    /// </summary>
    public partial class NewDrawPage : Page
    {
        public NewDrawPage()
        {
            InitializeComponent();
        }

        string[] pickednumbers = new string[6];
        int pickednumbersindex = 0;
        bool wasCleared;
        TextBlock? textblock;
        TextBlock clickedtextblock;
        Button? clickedButton;
        int clearIndex;
        string isInArray;
        int latestIndex;
        BrushConverter bc = new BrushConverter();

        public void SelectNumbers(string number)
        {
            textblock = FindName("SelectedPreview" + (pickednumbersindex + 1)) as TextBlock;
            clickedButton = FindName("ButtonNumber" + (number)) as Button;
            
            if (pickednumbersindex <= pickednumbers.Length)
            {
                isInArray = Array.Find(pickednumbers, element => element == number);
                if (isInArray != number) {
                    try
                    {
                        pickednumbers[pickednumbersindex] = number;
                        textblock.Text = pickednumbers[pickednumbersindex].ToString();
                        clickedButton.Background = (Brush)bc.ConvertFrom("#ffffff");
                        pickednumbersindex += 1;
                    }
                    catch
                    {
                        MessageBox.Show("Wybrano wszystkie liczby", "Ostrzeżenie", MessageBoxButton.OK);
                    };
                }
              else
                {
                    MessageBox.Show("Ta liczba już jest wybrana", "Ostrzeżenie", MessageBoxButton.OK);
                }
            }
            if(pickednumbersindex == 6)
            {
                StartDraw.Content = "10 PLN";
            }
        }

        public void ClearSelected(object sender, RoutedEventArgs e)
        {
            clickedtextblock = (TextBlock)sender;
            clearIndex = Array.IndexOf(pickednumbers, clickedtextblock.Text);
            clickedtextblock.Text = "";
            pickednumbersindex = clearIndex;
            clickedButton.Background = (Brush)bc.ConvertFrom("#FF252525");
        }

        private void ButtonNumber1_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("1");
        }

        private void ButtonNumber2_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("2");
        }

        private void ButtonNumber3_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("3");
        }

        private void ButtonNumber4_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("4");
        }

        private void ButtonNumber5_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("5");
        }

        private void ButtonNumber6_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("6");
        }

        private void ButtonNumber7_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("7");
        }

        private void ButtonNumber8_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("8");
        }

        private void ButtonNumber9_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("9");
        }

        private void ButtonNumber10_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("10");
        }

        private void ButtonNumber11_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("11");
        }

        private void ButtonNumber12_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("12");
        }
        private void ButtonNumber13_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("13");
        }

        private void ButtonNumber14_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("14");
        }

        private void ButtonNumber15_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("15");
        }

        private void ButtonNumber16_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("16");
        }

        private void ButtonNumber17_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("17");
        }

        private void ButtonNumber18_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("18");
        }

        private void ButtonNumber19_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("19");
        }

        private void ButtonNumber20_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("20");
        }

        private void ButtonNumber21_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("21");
        }

        private void ButtonNumber22_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("22");
        }

        private void ButtonNumber23_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("23");
        }

        private void ButtonNumber24_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("24");
        }
        private void ButtonNumber25_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("25");
        }

        private void ButtonNumber26_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("26");
        }

        private void ButtonNumber27_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("27");
        }

        private void ButtonNumber28_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("28");
        }

        private void ButtonNumber29_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("29");
        }

        private void ButtonNumber30_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("30");
        }

        private void ButtonNumber31_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("31");
        }

        private void ButtonNumber32_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("32");
        }

        private void ButtonNumber33_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("33");
        }

        private void ButtonNumber34_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("34");
        }

        private void ButtonNumber35_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("35");
        }

        private void ButtonNumber36_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("36");
        }

        private void ButtonNumber37_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("37");
        }

        private void ButtonNumber38_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("38");
        }

        private void ButtonNumber39_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("39");
        }

        private void ButtonNumber40_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("40");
        }

        private void ButtonNumber41_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("41");
        }

        private void ButtonNumber42_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("42");
        }

        private void ButtonNumber43_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("43");
        }

        private void ButtonNumber44_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("44");
        }

        private void ButtonNumber45_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("45");
        }

        private void ButtonNumber46_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("46");
        }

        private void ButtonNumber47_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("47");
        }

        private void ButtonNumber48_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("48");
        }

        private void ButtonNumber49_Click(object sender, RoutedEventArgs e)
        {
            SelectNumbers("49");
        }

        private void StartDraw_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                Globals.playerNumbers[i] = Convert.ToInt32(pickednumbers[i]);
            }

            CheckLuckyNumbers checkluckynumbers = new CheckLuckyNumbers();
            MainWindow mainwindow = new MainWindow();
            mainwindow.NewDrawFrame.Navigate(checkluckynumbers);
        }
    }
}
