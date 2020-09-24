using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
<<<<<<< HEAD
  public  class Category
=======
    public class Category
>>>>>>> origin/bach
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Subcategory> Subcategories { get; set; }
    }
}
