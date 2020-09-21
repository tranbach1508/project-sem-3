using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    public class Publisher
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
