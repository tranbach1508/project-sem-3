using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    public class Feedback
    {
        [Key]
        public string Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual AccCustomer AccCustomer { get; set; }
        public string Content { get; set; }
    }
}
