﻿using System;
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
            Database.SetInitializer<ShopContext>(new UniDBInitializer<ShopContext>());
        }
      
        public virtual DbSet<AccAdmin> AccAdmins { get; set; }
        public virtual DbSet<AccCustomer> AccCustomers { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }

        private class UniDBInitializer<T>: DropCreateDatabaseAlways<ShopContext>
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
}

