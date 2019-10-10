using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Data.LINQ2SQL
{
    public partial class Recipient : IDataErrorInfo
    {
        string IDataErrorInfo.Error => "";

        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        string IDataErrorInfo.this[string PropertyName]
        {
            get 
            {
                string msg = "";

                switch (PropertyName)
                {
                    case nameof(Name):
                        if(string.IsNullOrEmpty(Name)) { msg = "Пустая строка"; break; }
                        if (Name.Length < 5) { msg =   $"Имя \"{Name}\" должно быть больше 5-ти символов"; }
                        if (!char.IsUpper(Name[0])) { msg = $"Имя \"{Name}\" должно быть с заглавной буквы"; }
                        
                        break;
                }

                if (msg != "")
                {
                    if (ErrorCollection.ContainsKey(PropertyName))
                    {
                        ErrorCollection[PropertyName] = msg;
                    }
                    else
                    {
                        ErrorCollection.Add(PropertyName, msg);
                    }
                    
                    SendPropertyChanged(nameof(ErrorCollection));
                }
                else
                {
                    if (ErrorCollection.ContainsKey(PropertyName)) { ErrorCollection.Remove(PropertyName); }
                }
                
                return msg;
            }
        }

        private void ValidateProperty<T>(T value, string PropertyName)
        {
            Validator.ValidateProperty(value, new ValidationContext(this)
            {
                MemberName = PropertyName
            });
        }

        //partial void OnNameChanging(string value)
        //{
        //    if (value is null) throw new ArgumentNullException(nameof(value), "Передана пустая ссылка");

        //    if (value.Length <= 3) throw new InvalidOperationException("Строка имени должна быть больше 3-х символов");
        //}
    }
}
