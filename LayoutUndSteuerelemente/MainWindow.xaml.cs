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

namespace LayoutUndSteuerelemente
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
            listBoxPersonen.Items.Add(new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100m });
            listBoxPersonen.Items.Add(new Person { Vorname = "Anna", Nachname = "Nass", Alter = 20, Kontostand = 200m });
            listBoxPersonen.Items.Add(new Person { Vorname = "Peter", Nachname = "Silie", Alter = 30, Kontostand = 3.99m });
            listBoxPersonen.Items.Add(new Person { Vorname = "Franz", Nachname = "Ose", Alter = 40, Kontostand = 100m });
        }
    }
}
