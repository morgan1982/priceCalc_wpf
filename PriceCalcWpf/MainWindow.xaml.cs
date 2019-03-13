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

namespace PriceCalcWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(234, 87, 87));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(86, 234, 126));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleButton_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButton_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void LcSwitch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(LcSwitch.IsToggled)
            {
                  Balloon.Fill = On;
            }
            else
            {
                Balloon.Fill = Off;
            }
        }

        private void TestToggle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(testToggle.IsToggled)
            {
                TotalTextBlock.Text = "einai?";
            }
            else
            {
                TotalTextBlock.Text = "den einai";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TotalTextBlock.Text += ((CheckBox)sender).Content;
        }

        private void RepairOneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TotalTextBlock.Text = ((TextBox)sender).Text;
        }
    }
}
