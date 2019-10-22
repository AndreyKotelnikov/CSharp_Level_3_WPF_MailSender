using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Additions
{
    public static class ExtensionMethods
    {

        public static void CopyValuePropertiesTo<T, TCopy>(this T obj, ref TCopy copyObj) 
        {
            
            PropertyInfo[] properties = obj?.GetType().GetProperties() 
                                        ?? throw new NullReferenceException($"Пустая ссылка {nameof(obj)}");

            PropertyInfo[] propertiesCloneObj = copyObj?.GetType().GetProperties() 
                                                ?? throw new NullReferenceException($"Пустая ссылка {nameof(copyObj)}"); ;

            foreach (var item in properties)
            {
                propertiesCloneObj.FirstOrDefault(i => i.Name == item.Name)
                    ?.SetValue(copyObj, item.GetValue(obj));
            }
        }
    }
}
