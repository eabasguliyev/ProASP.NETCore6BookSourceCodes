// using LanguageFeatures.Models;
// using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController: Controller{
    public ViewResult Index(){
        Product?[] products = Product.GetProducts();

        return View(new string[] {
            products[2]?.Name ?? "No value"
        });
    }
}