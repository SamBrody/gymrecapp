using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GYMRecordApp.Models
{
    public class WeightM //: INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_weight { get; set; }
        public string Date { get; set; }
        public double Weight { get; set; }

       /*public int _id_weight
        {
            get { return ID_weight; }
            set { ID_weight = value; OnPropertyChanged("ID_Weight"); }
        }

        public string _date
        {
            get { return Date; }
            set { Date = value; OnPropertyChanged("Date"); }
        }

        public double _weight
        {
            get { return Weight; }
            set { Weight = value; OnPropertyChanged("Weight"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }*/
    }
}
