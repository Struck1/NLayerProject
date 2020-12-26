using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IProductService : IServices<Product>
    {
        //veri tabanı işlemleri ile lazım olan diğer metodlar servis katmanında yazılır
        // bool ControlInnerBarcode(Product product);
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
