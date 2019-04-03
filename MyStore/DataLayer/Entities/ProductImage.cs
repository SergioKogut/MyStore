using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.DataLayer.Entities
{
    [Table("tblProductImages")]
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }
        public int Priority { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
