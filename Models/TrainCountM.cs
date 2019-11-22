using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GYMRecordApp.Models
{
    class TrainCountM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_train_counter { get; set; }
        public string Date_Begin { get; set; }
        public string Date_End { get; set; }
        public double Train_cur { get; set; }
    }
}
