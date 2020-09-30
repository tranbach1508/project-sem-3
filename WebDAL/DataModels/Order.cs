using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public double Total { get; set; }
        public string createdAt { get; set; }
        public string AccCustomerId { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<AccCustomer> AccCustomers { get; set; }
    }
}
