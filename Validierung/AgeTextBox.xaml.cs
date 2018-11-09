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

namespace Validierung
{
    /// <summary>
    /// Interaction logic for AgeTextBox.xaml
    /// </summary>
    public partial class AgeTextBox : TextBox
    {
        public AgeTextBox()
        {
            InitializeComponent();
            this.DataContext = this;

            var binding = new Binding("Age");
            binding.Source = this;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Mode = BindingMode.TwoWay;

            binding.ValidationRules.Add(new AgeValidationRule());

            BindingOperations.SetBinding(this, TextBox.TextProperty, binding);
        }

        public string Age
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(string), typeof(AgeTextBox), new PropertyMetadata(string.Empty));
    }
}
