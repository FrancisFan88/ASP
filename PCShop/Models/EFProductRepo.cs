using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PCShop.Models
{
    public class EFProductRepo : IProductRepo
    {
        private readonly AppDBContext appDBContext;
        public EFProductRepo(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Product> AllProducts 
        { 
            get
            {
                return appDBContext.Products.Include(c => c.Category) ;
            }
        }

        public IEnumerable<Product> PromoteProducts => throw new NotImplementedException();

        public Product GetProductById(int productId)
        {
            return appDBContext.Products.Include(c => c.Category).FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
