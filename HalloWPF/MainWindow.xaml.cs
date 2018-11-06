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

namespace HalloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBoxWerte.ItemsSource = new string[] {"Tom Ate", "Anna Nass", "Peter Silie", "Franz Ose", "Martha Pfahl", "Anna Bolika", "Frank N Stein"};
        }

        private void MeinButtonClick(object sender, RoutedEventArgs e)
        {
            #region Objektidentität prüfen
            //// if((sender as Button).Name == "button1")
            //// if(sender.GetHashCode() == meinKleinerButton.GetHashCode() )

            //if(sender is Button)
            //{
            //    // buttonlogik
            //}
            //else if (sender is TextBox)
            //{
            //    // ....
            //}
            //// Alternative:
            //switch (sender)
            //{
            //    case Button b:
            //        // b.Name // ..
            //        break;
            //    case TextBox t:
            //        // t.
            //        break;
            //} 
            #endregion
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            progressBarWert.Value = (sender as Slider).Value;
            #region Nullable und ??
            //var s1 = (Slider)sender;
            //var s2 = sender as TextBox ?? new TextBox();

            //// .NET Framework 2.0
            //// Nullable Value Types
            //int zahl1 = 5;
            //int? zahl2 = null;

            //zahl2 = 50;
            //// Null-Coalescing Operator
            //zahl1 = zahl2 ?? 0 ; 
            #endregion
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxWerte.Items.Add("Pause ???");
        }
    }
}
