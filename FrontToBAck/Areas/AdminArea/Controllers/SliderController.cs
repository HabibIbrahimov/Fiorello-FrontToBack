using FrontToBAck.DAL;
using FrontToBAck.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(Context context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                ModelState.AddModelError("Photo", "Don't empty");
            }

            if (!slider.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "only image");
                return View();
            }
            if (slider.Photo.Length / 1024 > 500)
            {
                ModelState.AddModelError("Photo", "300-den yuxari ola bilmez!");
                return View();
            }

            string fileName = Guid.NewGuid() + slider.Photo.FileName;

            string path = Path.Combine(_env.WebRootPath, "img", fileName);

            FileStream fileStream = new FileStream(path, FileMode.Create);
            await slider.Photo.CopyToAsync(fileStream);
            Slider newSlider = new Slider();
            newSlider.ImageUrl = fileName;
           await _context.Sliders.AddAsync(newSlider);
           await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}
