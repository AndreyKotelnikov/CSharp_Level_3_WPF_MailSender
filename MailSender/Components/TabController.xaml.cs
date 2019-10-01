using System;
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

namespace MailSender.Components
{
    /// <summary>
    /// Логика взаимодействия для TabController.xaml
    /// </summary>
    public partial class TabController : UserControl
    {
        public TabController()
        {
            InitializeComponent();
        }

        public event EventHandler LeftButtonClick;

        public event EventHandler RightButtonClick;

        public bool IsLeftButtonVisible
        {
            get => MoveLeft.Visibility == Visibility.Visible;
            set => MoveLeft.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        public bool IsRightButtonVisible
        {
            get => MoveRight.Visibility == Visibility.Visible;
            set => MoveRight.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) { return; }

            switch (button.Name)
            {
                case "MoveLeft":
                    LeftButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
                case "MoveRight":
                    RightButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
    }
}
