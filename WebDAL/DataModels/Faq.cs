using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
<<<<<<< HEAD
   public class Faq
=======
    public class Faq
>>>>>>> origin/bach
    {
        [Key]
        public string Id { get; set; }
        public string Query { get; set; }
        public string Answer { get; set; }
    }
}
