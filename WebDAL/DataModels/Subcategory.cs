using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
<<<<<<< HEAD
   public class Subcategory
=======
    public class Subcategory
>>>>>>> origin/bach
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public byte type { get; set; }

        public virtual Category Category { get; set; }
    }
}
