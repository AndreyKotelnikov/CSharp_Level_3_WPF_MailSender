/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MailSender"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System.Data.Entity;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.Lib.Data;
using MailSender.Lib.Data.LINQ2SQL;
using MailSender.Lib.Services.InMemory;
using MailSender.Lib.Services.Interfaces;
using MailSender.Lib.Services.Linq2SQL;
using MaterialDesignThemes.Wpf;
using System.Data.Linq;
using MailSender.Lib.EF;

namespace MailSender.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            if (!SimpleIoc.Default.IsRegistered<DataContext>())
            {
                SimpleIoc.Default.Register(() => new MailSenderDBContext() as DataContext);
                //SimpleIoc.Default.Register(() => new MailSenderDB() as DbContext);
            }

            var services = SimpleIoc.Default;

            //services.Register<IRecipientsDataService, RecipientsDataServiceEF>();
            services.Register<IRecipientsDataService, RecipientsDataServiceLinq2SQL>();
            //services.Register<IRecipientsDataService, RecipientsDataServiceInMemory>();
            services.Register<ISendersDataService, SendersDataServiceInMemory>();
            services.Register<IServersDataService, ServersDataServiceInMemory>();
            services.Register<IMailMessagesDataService, MailMessagesDataServiceInMemory>();

            services.Register<IMailSenderService, SmtpMailSenderService>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MainWindowViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public MainWindowViewModel MainWindowViewModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}