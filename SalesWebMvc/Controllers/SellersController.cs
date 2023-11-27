using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController(SellerService sellerService) : Controller
    {
        private readonly SellerService _sellerService = sellerService;
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
