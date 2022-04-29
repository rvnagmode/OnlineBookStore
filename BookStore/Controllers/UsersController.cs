using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace BookStore.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(Users users)
        {
          
            var result = _context.users.Where(u => u.EmailId == users.EmailId && u.Passwords == users.Passwords).SingleOrDefault();
            if(result!=null)
            {
                if(result.RoleId==1)
                {
                    //ViewBag.msg1 = "Admin";
                    return RedirectToAction("Index", "Admin");
                }
                else if(result.RoleId==2)
                {
                    HttpContext.Session.SetInt32("UserId",result.UserId);
                    //ViewBag.msg2 = "User";
                    return RedirectToAction("Index", "Customer");
                }
            }
                return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users users)
        {
            try
            {
                users.RoleId = 1;
                _context.Add(users);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Login","Users");
        }
    }
}
