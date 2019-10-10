using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Additions
{
    public static class StringEncryptor
    {
        public static string Encrypt(this string str, int key = 1) => new string(str.Select(s => (char)(s + key)).ToArray());

        public static string Decrypt(this string str, int key = 1) => new string(str.Select(s => (char)(s - key)).ToArray());
    }
}
