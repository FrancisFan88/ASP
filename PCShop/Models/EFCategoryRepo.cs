using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class EFCategoryRepo : ICategoryRepo
    {
        private readonly AppDBContext appDBContext;
        public EFCategoryRepo(AppDBContext appDBContext )
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Category> AllCategories => appDBContext.Categories;
    }
}
