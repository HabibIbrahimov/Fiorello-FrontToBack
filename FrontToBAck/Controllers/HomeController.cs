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
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDesc sliderDesc = _context.SliderDescs.FirstOrDefault();
            List<Category> categories = _context.Categories.ToList();
            List<Product> products = _context.Products.Include(x=>x.Category).ToList();
            HomeVm homeVm = new HomeVm();
            homeVm.Sliders = sliders;
            homeVm.SliderDesc = sliderDesc;
            homeVm.Categories = categories;
            homeVm.Products = products;
            return View(homeVm);
        }
    }
}
