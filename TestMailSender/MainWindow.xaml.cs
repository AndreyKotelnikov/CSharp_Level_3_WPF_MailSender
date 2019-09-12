using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace TestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var client = new SmtpClient("smtp.yandex.ru", 25)
                {
                    Credentials = new NetworkCredential(UserNameEdit.Text, PasswordEdit.SecurePassword),
                    EnableSsl = true
                })
                {
                    using (var msg = new MailMessage()
                    {
                        From = new MailAddress("dragon@yandex.ru", "Ха-ха"),
                        To = { new MailAddress("dragon@gmail.com", "Получатель") },
                        Subject = "Тема письма 1",
                        Body = "Тестовое письмо"
                    })
                    {
                        client.Send(msg);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка при отправке письма", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Письмо успешно отправлено", "Отправка письма", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
