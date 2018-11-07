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

namespace Ressourcen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush color = (sender as Button).FindResource("DefaultButtonColor") as LinearGradientBrush;
            color.GradientStops[0].Color = Colors.MediumPurple;
        }

        private void buttonDynamic_Click(object sender, RoutedEventArgs e)
        {
            buttonDynamic.Resources["DefaultButtonColor"] = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            // stackPanelContainer.Resources["DefaultButtonColor"] = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //    (sender as Button).Style = gridAlles.Resources["Style1"] as Style;

            //    (sender as Button).Style = gridAlles.Resources["Style2"] as Style;

            SolidColorBrush color = (sender as Button).FindResource("Farbe") as SolidColorBrush;
            color.Color = Colors.MediumPurple;

            // (gridAlles.Resources["Farbe"] as SolidColorBrush).Color = Colors.MediumPurple;
        }
    }
}
