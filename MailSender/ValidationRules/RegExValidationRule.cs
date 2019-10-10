using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MailSender.ValidationRules
{
    public class RegExValidationRule : ValidationRule
    {
        private Regex _RegEx;
        
        public string Pattern
        {
            get => _RegEx?.ToString();

            set => _RegEx = string.IsNullOrEmpty(value) ? null : new Regex(value);
        }

        public bool AllowNull { get; set; }

        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is null)
            {
                return AllowNull ? ValidationResult.ValidResult : new ValidationResult(false, "Пустая ссылка");
            }

            if (_RegEx is null) { return ValidationResult.ValidResult; }

            if (!(value is string str)) { str = value.ToString(); }

            return _RegEx.IsMatch(str) ? ValidationResult.ValidResult :
                new ValidationResult(false, string.IsNullOrEmpty(ErrorMessage) ? $"Строка {str} не соответсвует регулярному выражению {Pattern}!" : ErrorMessage);
        }
    }
}
