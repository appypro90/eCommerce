using eCommerce.DAL.Repositories;
using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.MVC.Controllers
{
    public class AdminController : Controller
    {
        IBaseRepository<Product> productRepository;
        IBaseRepository<Customer> customerRepository;

        public AdminController(IBaseRepository<Product> ProductRepository, IBaseRepository<Customer> CustomerRepository)
        {
            productRepository = ProductRepository;
            customerRepository = CustomerRepository;
        }
        public ActionResult Index()
        {
            return View();
        }

        //return all product list.
        public ActionResult ProductList()
        {
            var model = productRepository.GetAll();
            return View(model);
        }

        //An empty view for creating product.
        public ActionResult CreateProduct()
        {
            var model = new Product();
            return View(model);
        }

        //Post an product.
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
                productRepository.Insert(product);
            return RedirectToAction("ProductList");
        }

        //Returns view for updating a product.
        public ActionResult EditProduct(int Id)
        {
            var model = productRepository.GetById(Id);
            return View(model);
        }

        //Post an edited product.
        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            productRepository.Update(product);
         
            return RedirectToAction("ProductList");

        }

        
        public ActionResult DeleteProduct(int id)
        {
            productRepository.DeleteById(id);                                           
            return RedirectToAction("ProductList");
        }
    }
}