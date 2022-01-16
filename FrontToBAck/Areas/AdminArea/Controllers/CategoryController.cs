using FrontToBAck.DAL;
using FrontToBAck.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
       
        private readonly Context _context;
        public CategoryController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Category dbCategory = await _context.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();
            return View(dbCategory);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            bool isExist=_context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adla kateqoriya movcuddur!");
                return View();
            }
            Category newCategory = new Category
            {
                Name = category.Name,
                Description = category.Description
            };

            await _context.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
