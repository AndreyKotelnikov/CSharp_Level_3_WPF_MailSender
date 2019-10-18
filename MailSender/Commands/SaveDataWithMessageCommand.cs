using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using MailSender.Lib.MVVM;

namespace MailSender.Commands
{
    public class SaveDataWithMessageCommand : LamdaCommand
    {
        public SaveDataWithMessageCommand() : base(p => MessageBox.Show("Сохраняем"), p => p != null) { }
       
    }
}
