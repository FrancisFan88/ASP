using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> AllCategories => new List<Category> { 
            new Category {
                CategoryID=201,
                Name="Computer",
                Description="Desktop, Laptop"
            },
            new Category {
                CategoryID=301, 
                Name="Printer",
                Description="Printer, scanner, phone"
            },
            new Category {
                CategoryID=401,
                Name="Other",
                Description="Headset, Memory, HardDriver"
            }
        };
        
    }
}
