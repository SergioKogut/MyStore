using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStore.DataLayer.Entities
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 1000)]
        public string Description { get; set; }

        [Required]
        public decimal Discount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Product> Images { get; set; }
    }
}