using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBZ_2.Models
{
    public class Company
    {
        [Key]
        public string Name { get; set; }
        public int SK { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string FIOBoss { get; set; }
        public string positionBoss { get; set; }
        public string TelMD { get; set; }
        public string TelMDBoss { get; set; }
        public string FIOCP { get; set; }
        public string Town { get; set; }
        public DateTime Date { get; set; }

        public virtual List<PriceList> PriceLists { get; set; }
    }
}
