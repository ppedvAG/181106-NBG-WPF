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
    }
}
