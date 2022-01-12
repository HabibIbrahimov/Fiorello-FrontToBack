﻿using FrontToBAck.DAL;
using FrontToBAck.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly Context _context;
        public ProductsViewComponent(Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = _context.Products
                .Include(p => p.Category)
                .Take(8)
                .ToList();
            return View (await Task.FromResult(products));

        }
    }
}