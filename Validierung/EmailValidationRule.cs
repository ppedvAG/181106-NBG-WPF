using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung
{
    class EmailValidationRule : ValidationRule
    {
        Regex r = new Regex(@"[a-zA-Z0-9.]+@[a-zA-Z]+\.[a-zA-Z]{2,3}");
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string eingabe = (string)value;
            var result = r.Match(eingabe);
            if (result.Success)
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false, "Ungültige Mailadresse");
        }
    }
}
