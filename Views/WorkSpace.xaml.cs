using GYMRecordApp.Models;
using GYMRecordApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GYMRecordApp.Views
{
    /// <summary>
    /// Interaction logic for WorkSpace.xaml
    /// </summary>
    public partial class WorkSpace : Page
    {
        public WorkSpace()
        {
            InitializeComponent();
        }

        private void ButtonPopUpExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        GymContext gymContextdb = new GymContext();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var weightDB = gymContextdb.WeightModels.ToList();
            var vrecDB = gymContextdb.VRecs.ToList();
            var traincountDB = gymContextdb.TrainCounts.ToList();
            dgWeight.ItemsSource = weightDB;
            dgV.ItemsSource = vrecDB;
            dgTC.ItemsSource = traincountDB;
        }
    }
}
