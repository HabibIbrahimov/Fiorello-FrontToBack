using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.ViewsModels
{
    public class ProductReturn
    {
        public int Id { get; set; }
        [Required, MinLength(5)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
