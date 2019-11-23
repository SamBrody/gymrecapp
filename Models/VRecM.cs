using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace GYMRecordApp.Models
{
    public class VRecM //: INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_V { get; set; }
        public string Date { get; set; }
        public string V_gr { get; set; }
        public string V_tal { get; set; }
        public string V_b { get; set; }
        public string V_l_b { get; set; }
        public string V__r_b { get; set; }
        public string V_r_pl { get; set; }
        public string V_l_pl { get; set; }
        public string b_sp { get; set; }

       /* public int _id_v
        {
            get { return ID_V; }
            set { ID_V = value; OnPropertyChanged("ID_V"); }
        }
        public string _date
        {
            get { return Date; }
            set { Date = value; OnPropertyChanged("Date"); }
        }
        public string _v_gr
        {
            get { return V_gr; }
            set { V_gr = value; OnPropertyChanged("V_gr"); }
        }
        public string _v_tal
        {
            get { return V_tal; }
            set { V_tal = value; OnPropertyChanged("V_tal"); }
        }
        public string _v_b
        {
            get { return V_b; }
            set { V_b = value; OnPropertyChanged("V_b"); }
        }
        public string _v_l_b
        {
            get { return V_l_b; }
            set { V_l_b = value; OnPropertyChanged("V_l_b"); }
        }
        public string _v_r_b
        {
            get { return V__r_b; }
            set { V__r_b = value; OnPropertyChanged("V_r_b"); }
        }
        public string _v_r_pl
        {
            get { return V_r_pl; }
            set { V_r_pl = value; OnPropertyChanged("V_r_pl"); }
        }
        public string _v_l_pl
        {
            get { return V_l_pl; }
            set { V_l_pl = value; OnPropertyChanged("V_l_pl"); }
        }
        public string _b_sp
        {
            get { return b_sp; }
            set { b_sp = value; OnPropertyChanged("b_sp"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }*/
    }
}
