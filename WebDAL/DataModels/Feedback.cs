using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
   public class Feedback
    {
        [Key]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string Content { get; set; }
        public string AccCustomerId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("AccCustomerId")]
        public virtual AccCustomer AccCustomer { get; set; }
    }
}
