using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("name=ShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShopContext, Migrations.Configuration>("ShopContext"));
        }

        public  DbSet<AccAdmin> AccAdmins { get; set; }
        public  DbSet<AccCustomer> AccCustomers { get; set; }
        public  DbSet<Author> Authors { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Faq> Faqs { get; set; }
        public  DbSet<Feedback> Feedbacks { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Publisher> Publishers { get; set; }
        public  DbSet<Subcategory> Subcategories { get; set; }
        
    }
    class UniDBInitializer<T> : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            IList<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                Id = "B001",
                Name = "Sach Giao Khoa"
            });
            foreach (Category category in categories)
                context.Categories.Add(category);
            base.Seed(context);
        }
    }
}

