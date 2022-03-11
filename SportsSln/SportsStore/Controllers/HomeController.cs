using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers;

public class HomeController:Controller{
    private readonly IStoreRepository repository;
    public int PageSize = 4;
    public HomeController(IStoreRepository repo)
    {
        repository = repo;
    }
    public IActionResult Index(int productPage = 1){
        var vm = new ProductsListViewModel();

        vm.Products = repository
                    .Products
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize);
        vm.PagingInfo = new PagingInfo{
            CurrentPage = productPage,
            ItemsPerPage = PageSize,
            TotalItems = repository.Products.Count(),
        };

        return View(vm);
    }
}