using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public interface IProductRepo
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> PromoteProducts { get; }

        Product GetProductById(int productId);
    }
}
