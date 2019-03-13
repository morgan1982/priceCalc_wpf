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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace On_off
{
    /// <summary>
    /// Interaction logic for ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        Thickness Leftside = new Thickness(-93, 0, 0, 0);
        Thickness Rightside = new Thickness(0, 0, -96, 0);

        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(234, 87, 87));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(86, 234, 126));

        DropShadowEffect DotShadow = new DropShadowEffect();
        
        

        bool isToggled = false;

        public bool IsToggled { get => isToggled; set => isToggled = value; }

        public ToggleButton()
        {
            InitializeComponent();
            Background.Fill = Off;
            Dot.Margin = Leftside;
            //Dot.Effect = DotShadow;
            isToggled = false;
        }
        private void HandleToggle() // use this to control the toggle
        {
            if (!isToggled)
            {
                Background.Fill = On;
                isToggled = true;
                Dot.Margin = Rightside;
            }
            else
            {
                Background.Fill = Off;
                isToggled = false;
                Dot.Margin = Leftside;

            }
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HandleToggle();
        }

        private void Background_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HandleToggle();
        }
    }
}
