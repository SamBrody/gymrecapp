using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace GYMRecordApp.Models
{
    public class TrainCountM //: INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_train_counter { get; set; }
        public string Date_Begin { get; set; }
        public string Date_End { get; set; }
        public double Train_cur { get; set; }

        /*public int _id_train_counter
        {
            get { return ID_train_counter; }
            set { ID_train_counter = value; OnPropertyChanged("ID_Train_counter"); }
        }
        public string _date_begin
        {
            get { return Date_Begin; }
            set { Date_Begin = value; OnPropertyChanged("Date_Begin"); }
        }
        public string _date_end
        {
            get { return Date_End; }
            set { Date_End = value; OnPropertyChanged("Date_End"); }
        }

        public double _train_cur
        {
            get { return Train_cur; }
            set { Train_cur = value; OnPropertyChanged("Train_cur"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }*/
    }
}
