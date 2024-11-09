using System.Security.Claims;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [Route("/")]
        public IActionResult RedirectToCustomerHome()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {



            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productList);
        }






        [Route("/details/{productId:int}")]
        public IActionResult Details(int productId)
        {
            ShoppingCart cart = new()
            {
                Product = _unitOfWork.Product.Get(u=>u.Id==productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId,
            };
            return View(cart);

        }



        [HttpPost]
        [Authorize]
        [Route("/details/{productId:int}")]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;


            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u=>u.ApplicationUserId == userId &&
                u.ProductId == shoppingCart.ProductId);

            if(cartFromDb!=null)
            {
                //shopping cart exists
                cartFromDb.Count+=shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.ShoppingCart.Add(shoppingCart);       //add cart 
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
                    _unitOfWork.ShoppingCart.GetAll(u=>u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated Successfully";

            
            return RedirectToAction(nameof(Index));
        }








        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
