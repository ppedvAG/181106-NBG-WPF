using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung
{
    class AgeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
       {
            if(Decimal.TryParse(value.ToString(), NumberStyles.Any,cultureInfo,out decimal age))
            {
                age = Math.Floor(age);
                if (age > 0 && age <= 99)
                    return new ValidationResult(true, null);
                else
                    return new ValidationResult(false, null);
            }
            return new ValidationResult(false, null);
        }
    }
}
