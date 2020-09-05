using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PCShop.Models;

namespace PCShop.ViewModels
{
    public class ProductListVM
    {
        public IEnumerable<Product> Products { get; set; }
        public string SelectedCategoryName { get; set; }
    }
}
