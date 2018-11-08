using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace UserControlDemo
{
    /// <summary>
    /// Interaction logic for LabledTextBox.xaml
    /// </summary>
    public partial class LabledTextBox : DockPanel
    {
        public LabledTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private Regex r = new Regex(@"\D+");
        // propdp - Dependency-Property erstellen
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(LabledTextBox), new PropertyMetadata(string.Empty));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(LabledTextBox), new PropertyMetadata(string.Empty));

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = r.Match((sender as TextBox).Text);
            if(result.Success) // Es wurden buchstaben eingegeben !
                textBlockValidationError.Visibility = Visibility.Visible;
            else
                textBlockValidationError.Visibility = Visibility.Hidden;
        }
    }
}
