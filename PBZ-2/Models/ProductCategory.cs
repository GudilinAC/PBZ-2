using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBZ_2.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
