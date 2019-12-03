using GYMRecordApp.Models;
using GYMRecordApp.Models.Context;
using Microsoft.EntityFrameworkCore;
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
        GymContext db;
        public WorkSpace()
        {
            InitializeComponent();

            db = new GymContext();
            db.WeightModels.Load();
            dgWeight.ItemsSource = db.WeightModels.Local.ToBindingList();

            db.VRecs.Load();
            dgV.ItemsSource = db.VRecs.Local.ToBindingList();

            db.TrainCounts.Load();
            dgTC.ItemsSource = db.TrainCounts.Local.ToBindingList();

            ListViewHome.IsSelected = true;
        }

        private void ButtonPopUpExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
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

        private void ButtonWUpdate_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void ButtonWDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgWeight.SelectedItems != null)
            {
                for (int i=0; i<dgWeight.SelectedItems.Count;i++)
                {
                    WeightM weightM = dgWeight.SelectedItems[i] as WeightM;
                    if (weightM != null)
                    {
                        db.WeightModels.Remove(weightM);
                    }
                }
            }            
            db.SaveChanges();
        }       

        private void ButtonVUpdate_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void ButtonVDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgV.SelectedItems != null)
            {
                for (int i = 0; i < dgV.SelectedItems.Count; i++)
                {
                    VRecM vrecM = dgV.SelectedItems[i] as VRecM;
                    if (vrecM != null)
                    {
                        db.VRecs.Remove(vrecM);
                    }
                }
            }
            db.SaveChanges();
        }

        private void ButtonTCUpdate_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void ButtonTCDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgTC.SelectedItems != null)
            {
                for (int i = 0; i < dgTC.SelectedItems.Count; i++)
                {
                    TrainCountM trainCountM = dgTC.SelectedItems[i] as TrainCountM;
                    if (trainCountM != null)
                    {
                        db.TrainCounts.Remove(trainCountM);
                    }
                }
            }
            db.SaveChanges();
        }

        private void ListViewRecord_Selected(object sender, RoutedEventArgs e)
        {
            spRecCont.Visibility = Visibility.Visible;
            spHomeCont.Visibility = Visibility.Collapsed;
        }

        private void ListViewHome_Selected(object sender, RoutedEventArgs e)
        {
            spRecCont.Visibility = Visibility.Collapsed;
            spHomeCont.Visibility = Visibility.Visible;
        }
    }
}
