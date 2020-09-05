using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCShop.Models;

namespace PCShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepo productRepo;
        private readonly ShoppingCart shoppingCart;
        public ShoppingCartController(IProductRepo productRepo, ShoppingCart cart)
        {
            this.productRepo = productRepo;
            this.shoppingCart = cart;
        }
        public IActionResult Index()
        {
            shoppingCart.ShoppingCartItems = shoppingCart.GetShoppingCartItems();
            return View(shoppingCart);
        }
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = productRepo.GetProductById(productId);
            shoppingCart.AddItemToCart(selectedProduct, selectedProduct.ProductPrice);
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = productRepo.GetProductById(productId);
            shoppingCart.RemoveItemFromCart(selectedProduct);
            return RedirectToAction("Index");
        }
    }
}
