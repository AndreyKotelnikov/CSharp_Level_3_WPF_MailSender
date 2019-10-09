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

        public static void CloneTo<T>(this T obj, ref T cloneObj) where T : class
        {
            PropertyInfo[] properties = obj?.GetType().GetProperties();
            foreach (var item in properties)
            {
                item.SetValue(cloneObj, item.GetValue(obj));
            }
        }
    }
}
