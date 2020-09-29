using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
  public  class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        public string OrderId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
