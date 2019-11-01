using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender.Lib.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRecipientsDataService _recipientsDataService;
        private readonly ISendersDataService _sendersDataService;
        private readonly IServersDataService _serversDataService;
        private readonly IMailMessagesDataService _mailMessagesDataService;
        private readonly IMailSenderService _mailSenderService;


        private string _title = "Рассыльщик почты";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _status = "Готов!";

        public string Status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        public MainWindowViewModel(
            IRecipientsDataService recipientsDataService,
            ISendersDataService sendersDataService,
            IServersDataService serversDataService,
            IMailMessagesDataService mailMessagesDataService,
            IMailSenderService mailSenderService
            )
        {
            _recipientsDataService = recipientsDataService;
            _sendersDataService = sendersDataService;
            _serversDataService = serversDataService;
            _mailMessagesDataService = mailMessagesDataService;
            _mailSenderService = mailSenderService; 

            UpdateDataCommand = new RelayCommand(UpdateData, CanExecute);
            CreateDataCommand = new RelayCommand(OnCreateDataCommandExcuted, CanExecute);
            SaveDataCommand = new RelayCommand<Recipient>(o => _recipientsDataService.Update(o.Id, o), CanSave, true);
            //UpdateData();
        }
        
        private ObservableCollection<Recipient> _recipients;

        public ObservableCollection<Recipient> Recipients
        {
            get => _recipients;
            set => Set(ref _recipients, value);
        }

        private ObservableCollection<Sender> _senders;

        public ObservableCollection<Sender> Senders
        {
            get => _senders;
            set => Set(ref _senders, value);
        }

        private ObservableCollection<Server> _servers;

        public ObservableCollection<Server> Servers
        {
            get => _servers;
            set => Set(ref _servers, value);
        }

        private ObservableCollection<MailMessage> _mailMessages;

        public ObservableCollection<MailMessage> MailMessages
        {
            get => _mailMessages;
            set => Set(ref _mailMessages, value);
        }


        private void UpdateData()
        {
            Recipients = new ObservableCollection<Recipient>(_recipientsDataService.GetAll());
            Senders = new ObservableCollection<Sender>(_sendersDataService.GetAll());
            Servers = new ObservableCollection<Server>(_serversDataService.GetAll());
            MailMessages = new ObservableCollection<MailMessage>(_mailMessagesDataService.GetAll());
        }

        public ICommand UpdateDataCommand { get; }

        private bool CanExecute() => true;

        private Recipient _currentRecipient;
        
        public Recipient CurrentRecipient
        {
            get => _currentRecipient;
            set => Set(ref _currentRecipient, value);
        }

        public ICommand SaveDataCommand { get; }

        private bool CanSave(Recipient recipient)
        {
            return CurrentRecipient != null;
            //return CurrentRecipient != null && CurrentRecipient.ErrorCollection.Count == 0;
        }

        public ICommand CreateDataCommand { get; }

        private void OnCreateDataCommandExcuted()
        {
            Recipient newRecipient = new Recipient()
            {
                Id = 0,
                Name = string.Empty,
                Adress = string.Empty
            };
            _recipientsDataService.Create(newRecipient);
            Recipients.Add(newRecipient);
            CurrentRecipient = newRecipient;
        }

    }
}
