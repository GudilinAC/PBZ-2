using System;
using System.ComponentModel.DataAnnotations;

namespace PBZ_2.Models
{
    public class PriceList
    {
        [Key]
        public int Id { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
