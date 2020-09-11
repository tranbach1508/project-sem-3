using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("name=ShopContext")
        {

        }
    }
}
