using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
   public class ShopDBInitializer : DropCreateDatabaseAlways<ShopContext>
    {
       

        protected override void Seed(ShopContext context)
        {
            IList<Category> category = new List<Category>();
            category.Add(new Category() { Name = "abc" });
            context.Categories.AddRange(category);

            base.Seed(context);
        }
    }
}
