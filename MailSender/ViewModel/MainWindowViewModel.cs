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
        private readonly ICRUDDataService _RecipientsDataService;


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

        public MainWindowViewModel(ICRUDDataService recipientsDataService)
        {
            _RecipientsDataService = recipientsDataService;
            UpdateDataCommand = new RelayCommand(UpdateData, CanExecute);
            CreateDataCommand = new RelayCommand(OnCreateDataCommandExcuted, CanExecute);
            SaveDataCommand = new RelayCommand<Recipient>(o => _RecipientsDataService.Update(o), CanSave, true);
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
            Recipients = new ObservableCollection<Recipient>(_RecipientsDataService.GetAll());
        }

        public ICommand UpdateDataCommand { get; }

        private bool CanExecute() => true;

        private Recipient _CurrentRecipient;
        
        public Recipient CurrentRecipient
        {
            get => _CurrentRecipient;
            set => Set(ref _CurrentRecipient, value);
        }

        public ICommand SaveDataCommand { get; }

        private bool CanSave(Recipient recipient)
        {
            return CurrentRecipient != null && CurrentRecipient.ErrorCollection.Count == 0;
        }

        public ICommand CreateDataCommand { get; }

        private void OnCreateDataCommandExcuted()
        {
            Recipient newRecipient = new Recipient()
            {
                Name = string.Empty,
                Adress = string.Empty
            };
            _RecipientsDataService.Create(newRecipient);
            Recipients.Add(newRecipient);
            CurrentRecipient = newRecipient;
        }

    }
}
