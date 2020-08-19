using System;
using System.Windows.Controls;

namespace TextBox.Validation
{
    public class OverThirteenValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value != null)
            {
                int age = 0;
                try
                {
                    age = Convert.ToInt32(value);
                }
                catch
                {
                    return new ValidationResult(false, "You must be older than 13!");
                }

                if (age > 13)
                    return ValidationResult.ValidResult;
            }
            return new ValidationResult(false, "You must be older than 13!");
        }
    }
}