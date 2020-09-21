using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    class ShopContext : DbContext
    {
        public ShopContext() : base("name=ShopContext")
        {
            Database.SetInitializer<ShopContext>(new ShopDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*//Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new CategoryConfigurations());

            modelBuilder.Entity<Category>()
                .ToTable("TeacherInfo");

            modelBuilder.Entity<Category>()
                .MapToStoredProcedures();*/
        }

        public DbSet<AccAdmin> AccAdmins { get; set; }
        public DbSet<AccCustomer> AccCustomers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; } 
    }
    }

