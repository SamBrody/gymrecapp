using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GYMRecordApp.Models
{
    class VRecM
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
    }
}
