using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="bos qoyma..")]
        public string Name { get; set; }
        [MaxLength(100,ErrorMessage ="100-den az olmalidir..")]
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
