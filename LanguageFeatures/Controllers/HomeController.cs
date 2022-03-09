// using LanguageFeatures.Models;
// using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController: Controller{
    public ViewResult Index(){
        Product?[] products = Product.GetProducts();

        ShoppingCart cart = new(){
            Products = products
        };

        decimal cartTotal = cart.TotalPrices();

        return View(new string[] {
            $"Total: {cartTotal:C2}"
        });
    }
}