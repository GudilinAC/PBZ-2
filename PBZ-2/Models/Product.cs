using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBZ_2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ProductCategory Category { get; set; }

        public virtual List<PriceList> PriceList { get; set; }
    }
}
