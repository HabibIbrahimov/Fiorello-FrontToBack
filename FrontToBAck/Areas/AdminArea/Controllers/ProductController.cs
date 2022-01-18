using FrontToBAck.DAL;
using FrontToBAck.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductController : Controller
    {

        private readonly Context _context;
        public ProductController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(c=>c.Category).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            List<SelectListItem> categories = (from i in _context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.Id.ToString()
                                               }).ToList();
            ViewBag.dgr = categories;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Products.Any(p => p.Name.ToLower().Trim() == product.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda məhsul artıq mövcuddur");
                View();
            }
            Product newProduct = new Product
            {
                Category = product.Category,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId

            };
            await _context.AddAsync(newProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            if (id == null) return NotFound();
            Product dbProduct = await _context.Products.FindAsync(id);
            var cat = dbProduct;
            if (dbProduct == null) return NotFound();
            _context.Products.Remove(dbProduct);
            await _context.SaveChangesAsync();
            return View(cat);

        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Product dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null) return NotFound();
            return View(dbProduct);
        }
    }
}
