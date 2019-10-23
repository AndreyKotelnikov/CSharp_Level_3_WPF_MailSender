using System;
using System.Collections;
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
    /// Логика взаимодействия для ListController.xaml
    /// </summary>
    public partial class ListController : UserControl
    {
        public ListController()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LabelNameProperty = DependencyProperty.Register(
            "LabelName",
            typeof(string),
            typeof(ListController),
            new PropertyMetadata("LabelName"));

        public string LabelName
        {
            get { return (string) GetValue(LabelNameProperty); }
            set { SetValue(LabelNameProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
            "ItemsSource",
            typeof(IEnumerable),
            typeof(ListController),
            new PropertyMetadata(Enumerable.Range(1, 10).Select(o => $"Name_{o}")));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable) GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty SelectedIndexProperty = DependencyProperty.Register(
            "SelectedIndex",
            typeof(int),
            typeof(ListController),
            new PropertyMetadata(default(int)));

        public int SelectedIndex
        {
            get { return (int) GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register(
            "ItemTemplate",
            typeof(DataTemplate),
            typeof(ListController),
            new PropertyMetadata(default(DataTemplate)));

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate) GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(
            "SelectedItem",
            typeof(object),
            typeof(ListController),
            new PropertyMetadata(default(object)));

        public object SelectedItem
        {
            get { return (object) GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }


        public static readonly DependencyProperty AddCommandProperty = DependencyProperty.Register(
            "AddCommand",
            typeof(ICommand),
            typeof(ListController),
            new PropertyMetadata(default(ICommand)));

        public ICommand AddCommand
        {
            get { return (ICommand) GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }


        public static readonly DependencyProperty EditCommandProperty = DependencyProperty.Register(
            "EditCommand",
            typeof(ICommand),
            typeof(ListController),
            new PropertyMetadata(default(ICommand)));

        public ICommand EditCommand
        {
            get { return (ICommand) GetValue(EditCommandProperty); }
            set { SetValue(EditCommandProperty, value); }
        }

        public static readonly DependencyProperty DeleteCommandProperty = DependencyProperty.Register(
            "DeleteCommand",
            typeof(ICommand),
            typeof(ListController),
            new PropertyMetadata(default(ICommand)));

        public ICommand DeleteCommand
        {
            get { return (ICommand) GetValue(DeleteCommandProperty); }
            set { SetValue(DeleteCommandProperty, value); }
        }

    }
}
