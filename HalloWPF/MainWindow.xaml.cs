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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo Welt");
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("LabelMouseDown");
            e.Handled = true; // kein weiteres bubbling
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("GridMouseDown");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("GridPReviewMouseDown");
        }

        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("LabelPreviewMouseDown");
        }
    }
}
