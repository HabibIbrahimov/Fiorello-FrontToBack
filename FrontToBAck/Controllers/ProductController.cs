using FrontToBAck.DAL;
using FrontToBAck.Models;
using FrontToBAck.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;
        public ProductController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Product = _context.Products.Count();
            List<Product> products = _context.Products.Include(p=>p.Category).Take(8).ToList();
            return View(products);
        }

        public IActionResult LoadMore(int skip)
        {
            IEnumerable<Product> products = _context.Products.Include(c=>c.Category).Skip(skip).Take(8).ToList();
            return PartialView("_ProductPartial",products);
        }



        public IActionResult Search(string search)
        {
            IEnumerable<Product> products = _context.Products
                .Include(c => c.Category)
                .Where(p => p.Name.ToLower().Contains(search.ToLower()))
                .OrderByDescending(p => p.Id)
                .Take(10)
                .ToList();
            return PartialView("_Searchpartial", products);
        }
        public IActionResult Detail(int id)
        {
            Product product = _context.Products
                .Include(c => c.Category)
                .FirstOrDefault(p => p.Id == id);
            return View(product);
                
        }
        //public IActionResult LoadMore()
        //{

        //    //return Json(_context.Products.Select(p => new ProductReturn
        //    //{
        //    //    Id = p.Id,
        //    //    Name = p.Name,
        //    //    Price = p.Price,
        //    //    ImageUrl = p.ImageUrl,
        //    //    Category = p.Category.Name

        //    //}).Take(8).ToList());

        //}
    }
}
