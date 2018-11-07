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

namespace BindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBoxPersonen.ItemsSource = new List<Person>()
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100.55m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=400.55m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=1210.55m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-12300.55m}
            };
        }
    }
}
