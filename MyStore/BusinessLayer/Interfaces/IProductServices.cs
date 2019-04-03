using MyStore.BusinessLayer.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.BusinessLayer.Interfaces
{
    /// <summary>
    /// Product Service Contract
    /// </summary>
    public interface IProductServices
    {
        ProductDto GetProductById(int productId);
        IEnumerable<ProductDto> GetAllProducts();
        int CreateProduct(ProductDto productEntity);
        bool UpdateProduct(int productId, ProductDto productEntity);
        bool DeleteProduct(int productId);
    }
}
