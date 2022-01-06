﻿using FrontToBAck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.ViewsModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public SliderDesc SliderDesc { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}