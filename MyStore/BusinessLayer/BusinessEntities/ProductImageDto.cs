using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.BusinessLayer.BusinessEntities
{
    public class ProductImageDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public int ProductId { get; set; }
    }
}
