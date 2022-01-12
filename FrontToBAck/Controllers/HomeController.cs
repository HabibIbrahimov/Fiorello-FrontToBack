using FrontToBAck.DAL;
using FrontToBAck.Models;
using FrontToBAck.ViewsModels;
using Microsoft.AspNetCore.Http;
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
            HttpContext.Session.SetString("person", "lorem");
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDesc sliderDesc = _context.SliderDescs.FirstOrDefault();
            List<Category> categories = _context.Categories.ToList();
            About about = _context.Abouts.FirstOrDefault();
            List<Expert>experts = _context.Experts.ToList();
            Subscribe subscribe = _context.Subscribes.FirstOrDefault();
            List<Blog> blogs = _context.Blog.ToList();
            List<BlogSlider> blogsliders = _context.BlogSliders.ToList();
            HomeVm homeVm = new HomeVm();
            homeVm.Sliders = sliders;
            homeVm.SliderDesc = sliderDesc;
            homeVm.Categories = categories;
            homeVm.About = about;
            homeVm.Experts = experts;
            homeVm.Subscribe = subscribe;
            homeVm.Blogs = blogs;
            homeVm.BlogSliders = blogsliders;

            return View(homeVm);
        }
        public IActionResult GetSession()
        {
            string session = HttpContext.Session.GetString("person");
            return Content(session);
        }
    }
}
