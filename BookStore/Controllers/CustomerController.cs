using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BookStore.Data;
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;
        //public static Orders ord;
        //List<Orders> li = new List<Orders>();
        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var l = context.Book.ToList();
            ViewBag.Books = l;
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Order(int BookId)
        {
            var p = context.Book.Where(p => p.BookId == BookId).SingleOrDefault();
            return View(p);
        }
        [HttpPost]
        public IActionResult Order(int qty, int id)
        {

            var prod = context.Book.Where(p => p.BookId == id).SingleOrDefault();
            Orders ord = new Orders();
            if (prod != null)
            {

                ord.BookName = prod.BookName;
                ord.BookId = prod.BookId;
                ord.BookQuantity = qty;
                ord.BookPrice = prod.BookPrice;
                ord.BookTotalBill = ord.BookTotalBill * ord.BookTotalBill;
                // ViewBag.Order=od;
                HttpContext.Session.SetString("data", JsonConvert.SerializeObject(ord));

                return RedirectToAction("Cart");
            }
            return RedirectToAction("Cart");
            //return View();
        }

        [HttpGet]
        public IActionResult Cart()
        {
            var data = HttpContext.Session.GetString("data");
            Orders o = JsonConvert.DeserializeObject<Orders>(data);
            return View(o);
        }
        [HttpPost]
        public IActionResult Cart(Orders ord)
        {
            ord.UserId = (int)HttpContext.Session.GetInt32("UserId");
            context.ord.Add(ord);
            int r = context.SaveChanges();

            if (r == 1)
            {
                ViewBag.OrderPlaced = "<script> alert('Order Placed!') </script>";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.OrderPlaced = "<script> alert('Failed to placed!') </script>";
                return View();
            }

        }
        [HttpPost]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
