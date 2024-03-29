﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSender.View
{
    /// <summary>
    /// Логика взаимодействия для RecipientInfoEditor.xaml
    /// </summary>
    public partial class RecipientInfoEditor : UserControl
    {
        public RecipientInfoEditor()
        {
            InitializeComponent();
        }

        private void OnDataValidationError(object sender, ValidationErrorEventArgs e)
        {
            var errorControl = (Control)e.OriginalSource;
            if(e.Action == ValidationErrorEventAction.Added)
            {
                errorControl.ToolTip = e.Error.ErrorContent.ToString();
            }
            else
            {
                errorControl.ToolTip = DependencyProperty.UnsetValue;
            }
        }
    }
}
