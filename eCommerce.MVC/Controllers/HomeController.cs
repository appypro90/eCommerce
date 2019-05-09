using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerce.DAL.Repositories;
using System.Web.Mvc;
using eCommerce.DAL.Data;
using Unity;
using eCommerce.Models;

namespace eCommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        IBaseRepository<Product> baseRepository;
        public HomeController(IBaseRepository<Product> repository)
        {
           baseRepository = repository;
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
                       
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}