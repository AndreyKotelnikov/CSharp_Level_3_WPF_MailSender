﻿using MailSender.Components;
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


namespace MailSender
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

        private void TabController_LeftButtonClick(object sender, EventArgs e)
        {
            if(!(sender is TabController tabController)) { return; }

            if(tabController.IsLeftButtonVisible)
            {
                MainTabControl.SelectedIndex--;
            }

            tabController.IsLeftButtonVisible = MainTabControl.SelectedIndex > 0;
            tabController.IsRightButtonVisible = MainTabControl.SelectedIndex < MainTabControl.Items.Count - 1;
        }

        private void TabController_RightButtonClick(object sender, EventArgs e)
        {
            if (!(sender is TabController tabController)) { return; }

            if (tabController.IsRightButtonVisible)
            {
                MainTabControl.SelectedIndex++;
            }

            tabController.IsLeftButtonVisible = MainTabControl.SelectedIndex > 0;
            tabController.IsRightButtonVisible = MainTabControl.SelectedIndex < MainTabControl.Items.Count - 1;
        }

    }
}
