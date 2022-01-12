﻿using FrontToBAck.DAL;
using FrontToBAck.Models;
using FrontToBAck.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Controllers
{
    public class BasketController : Controller
    {
        private readonly Context _context;
        public BasketController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>AddBasket(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Error");
            Product product = await _context.Products.FindAsync(id);
            if(product==null) return RedirectToAction("Index", "Error");
            string basket = Request.Cookies["basket"];
            List<BasketProduct> basketProductList;
            if (basket== null)
            {
                basketProductList = new List<BasketProduct>();
            }
            else
            {
                basketProductList = JsonConvert.DeserializeObject<List<BasketProduct>>(basket);
            }

            BasketProduct isExistProduct = basketProductList.Find(p => p.Id == product.Id);
            if (isExistProduct == null)
            {
                BasketProduct basketProduct = new BasketProduct
                {
                    Id=product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Count = 1
                };
                basketProductList.Add(basketProduct);
            }
            else
            {
                isExistProduct.Count++;
            }
           
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProductList), new Microsoft.AspNetCore.Http.CookieOptions { MaxAge = TimeSpan.FromMinutes(14) });
            return RedirectToAction("Index","Home");
        }
        public IActionResult ShowBasket()
        {
            string basket = Request.Cookies["basket"];
            List<BasketProduct> products = new List<BasketProduct>();
            if (basket != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketProduct>>(basket);
            }
            return View(products);
        }
    }
}