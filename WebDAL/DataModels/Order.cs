using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
   public class Order
    {
        [Key]
        public string Id { get; set; }
        public bool Status { get; set; }
        public string AccCustomerId { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [ForeignKey("AccCustomerId")]
        public virtual AccCustomer AccCustomers { get; set; }
    }
}
