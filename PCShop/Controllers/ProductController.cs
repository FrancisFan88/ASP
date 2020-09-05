using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCShop.Models;
using PCShop.ViewModels;

namespace PCShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo productRepo;
        private readonly ICategoryRepo categoryRepo;
        public ProductController(IProductRepo productRepo,
                                 ICategoryRepo categoryRepo)
        {
            this.productRepo = productRepo;
            this.categoryRepo = categoryRepo;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public ViewResult List()
        {
            /*
            ViewBag.SelectedCategory = categoryRepo.AllCategories.ToList()[2].Name; 
            return View(productRepo.AllProducts);
            */
            ProductListVM productListVM = new ProductListVM() {
                Products = productRepo.AllProducts,
                SelectedCategoryName = categoryRepo.AllCategories.ToList()[2].Name
            };
            return View(productListVM);
        }
        public IActionResult Details(int id)
        {
            var product = productRepo.GetProductById(id);
            return View(product);
        }
    }
}
