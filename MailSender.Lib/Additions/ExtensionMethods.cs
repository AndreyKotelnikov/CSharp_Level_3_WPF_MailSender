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
        public static T Copy<T>(this T obj) where T : class, new()
        {
            if (obj == null) { return null; }
            T copyObj = new T();
            obj.CloneTo(ref copyObj);
            return copyObj;
        }

        public static void CloneTo<T, TClone>(this T obj, ref TClone cloneObj) 
        {
            if(cloneObj == null) { throw new NullReferenceException($"Пустая ссылка {nameof(cloneObj)}"); }
            
            PropertyInfo[] properties =
                obj?.GetType().GetProperties() ?? throw new NullReferenceException($"Пустая ссылка {nameof(obj)}");

            PropertyInfo[] propertiesCloneObj = cloneObj.GetType().GetProperties();

            foreach (var item in properties)
            {
                propertiesCloneObj.FirstOrDefault(i => i.Name == item.Name)?.SetValue(cloneObj, item.GetValue(obj));
            }
        }
    }
}
