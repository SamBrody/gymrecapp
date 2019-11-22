using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GYMRecordApp.Models
{
    class WeightM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_weight { get; set; }
        public string Date { get; set; }
        public double Weight { get; set; }
    }
}
