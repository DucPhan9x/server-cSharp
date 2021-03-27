
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SuperMarket.Core.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}