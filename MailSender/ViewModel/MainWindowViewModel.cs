using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.Lib.Data.LINQ2SQL;
using MailSender.Lib.Services.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRecipientsDataService _RecipientsDataService;


        public string _Title = "Рассыльщик почты";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        public string _Status = "Готов!";

        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        public MainWindowViewModel(IRecipientsDataService recipientsDataService)
        {
            _RecipientsDataService = recipientsDataService;
            //UpdateData();
        }
        
        private ObservableCollection<Recipient> _Recipients;

        public ObservableCollection<Recipient> Recipients
        {
            get => _Recipients;
            set => Set(ref _Recipients, value);
        }

        private void UpdateData()
        {
            _Recipients = new ObservableCollection<Recipient>(_RecipientsDataService.GetAll());
        }

        public ICommand UpdateDataCommand => new RelayCommand(UpdateData, true);
        
    }
}
