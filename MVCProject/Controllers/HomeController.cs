using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.DAL.Data;
using eCommerce.DAL.Repositories;


namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           CustomerRepository customerRepository = new CustomerRepository(new DataContext());
           ProductRepository productRepository = new ProductRepository(new DataContext());
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
