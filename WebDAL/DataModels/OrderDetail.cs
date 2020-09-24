using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
<<<<<<< HEAD
  public  class OrderDetail
=======
    public class OrderDetail
>>>>>>> origin/bach
    {
        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
