using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class MockProductRepo: IProductRepo
    {
        private readonly ICategoryRepo categoryRepo;
        public IEnumerable<Product> AllProducts => new List<Product>
        {
            new Product{
            ProductId = 1, ProductName="HP Laptop",ProductDescription="HP Laptop A000",ProductPrice=1000, ProductActive=true,
            Category=categoryRepo.AllCategories.ToList()[0]
            },
            new Product{
            ProductId = 2, ProductName="Cannon Printer",ProductDescription="Cannon Printer B100",ProductPrice=800, ProductActive=true,
            Category=categoryRepo.AllCategories.ToList()[0]
            },
            new Product{
            ProductId = 3, ProductName="Mouse",ProductDescription="Logi Mouse M325",ProductPrice=100, ProductActive=true,
            Category=categoryRepo.AllCategories.ToList()[0]}
        };
        public IEnumerable<Product> PromoteProducts { get; }
        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(c => c.ProductId == productId); 
        }
    }
}
