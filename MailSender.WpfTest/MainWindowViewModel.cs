using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using MailSender.Lib.MVVM;

namespace MailSender.WpfTest
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "TestApplication";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private double _Position;

        public double Position
        {
            get => _Position;
            set => Set(ref _Position, value);
        }

        private double _Angle;

        public double Angle
        {
            get => _Angle;
            set => Set(ref _Angle, value);
        }

        private DateTime _Time = DateTime.Now;

        public DateTime Time
        {
            get => _Time;
            set => Set(ref _Time, value);
        }


        private readonly DispatcherTimer _Timer;

        public MainWindowViewModel()
        {
            _Timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(0.2),
                IsEnabled = true
            };

            _Timer.Tick += (s, e) => Time = DateTime.Now;
        }
    }
}
