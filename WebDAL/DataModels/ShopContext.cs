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

        private class UniDBInitializer<T> : DropCreateDatabaseAlways<ShopContext>
        {
            protected override void Seed(ShopContext context)
            {
                // Category
                //IList<Category> categories = new List<Category>();
                //categories.Add(new Category()
                //{
                //    Id = "B00001",
                //    Name = "Book"
                //});
                //categories.Add(new Category()
                //{
                //    Id = "B00002",
                //    Name = "Magazines"
                //});
                //categories.Add(new Category()
                //{
                //    Id = "B00003",
                //    Name = "Files"
                //});
                //categories.Add(new Category()
                //{
                //    Id = "B00004",
                //    Name = "CDs"
                //});
                //categories.Add(new Category()
                //{
                //    Id = "B00005",
                //    Name = "DVDs"
                //});
                //categories.Add(new Category()
                //{
                //    Id = "B00006",
                //    Name = "Utilities"
                //});
                //foreach (Category category in categories)
                //    context.Categories.Add(category);

                //// Author
                //IList<Author> authors = new List<Author>();
                //authors.Add(new Author()
                //{
                //    Id = "A000001",
                //    Name = "Nguyen Binh",
                //    Info = "Nguyen Binh (born May 7, 1955) is a Vietnamese author who writes for teenagers and adults."
                //});
                //authors.Add(new Author()
                //{
                //    Id = "A000002",
                //    Name = "Tran Bach",
                //    Info = "Tran Bach (born May 7, 1955) is a Vietnamese author who writes for teenagers and adults."
                //});
                //foreach (Author author in authors)
                //    context.Authors.Add(author);

                ////Publisher
                //IList<Publisher> publishers = new List<Publisher>();
                //publishers.Add(new Publisher()
                //{
                //    Id = "P000001",
                //    Name = "Oxford University Press",
                //    Info = "Oxford University Press(OUP) is one of the largest university publishers in the world."
                //});
                //publishers.Add(new Publisher()
                //{
                //    Id = "P000002",
                //    Name = "Cambridge University Press",
                //    Info = "Cambridge University Press(CUP) is a Cambridge University Press."
                //});
                //foreach (Publisher publisher in publishers)
                //    context.Publishers.Add(publisher);

                ////Subcategory
                //IList<Subcategory> subcategories = new List<Subcategory>();
                //subcategories.Add(new Subcategory()
                //{
                //    Id = "SB00001",
                //    Name = "Dictionaries & Languages",
                //    CategoryId = "B00001"
                //});
                //subcategories.Add(new Subcategory()
                //{
                //    Id = "SB00002",
                //    Name = "Children's Books",
                //    CategoryId = "B00001"
                //});
                //foreach (Subcategory subcategory in subcategories)
                //    context.Subcategories.Add(subcategory);

                ////Product
                //IList<Product> products = new List<Product>();
                //products.Add(new Product()
                //{
                //    Id = "P000001",
                //    Name = "The Little Prince",
                //    Image = "",
                //    Price = 2000000,
                //    Quantity = 2,
                //    Description = "The Little Prince, written in New York, was first published in New York in 1943",
                //    CategoryId = "B00001",
                //    AuthorId = "A000001",
                //    PublisherId = "P000001",
                //    SubcategoryId = "SB00001",
                //});
                //products.Add(new Product()
                //{
                //    Id = "P000002",
                //    Name = "Harry Potter and the Philosopher's Stone",
                //    Image = "",
                //    Price = 230000,
                //    Quantity = 2,
                //    Description = "The Little Prince, written in New York, was first published in New York in 1943",
                //    CategoryId = "B00001",
                //    AuthorId = "A000002",
                //    PublisherId = "P000002",
                //    SubcategoryId = "SB00002",
                //});
                //foreach (Product product in products)
                //    context.Products.Add(product);


                ////Faq
                //IList<Faq> faqs = new List<Faq>();
                //faqs.Add(new Faq()
                //{
                //    Id = "F000001",
                //    Query = "",
                //    Answer = "I want to order when it is not available to receive?"
                //});
                //faqs.Add(new Faq()
                //{
                //    Id = "F000002",
                //    Query = "",
                //    Answer = "Is there a discount for more bookings?"
                //});
                //foreach (Faq faq in faqs)
                //    context.Faqs.Add(faq);

                //// AccCustomer
                //IList<AccCustomer> accCustomers = new List<AccCustomer>();
                //accCustomers.Add(new AccCustomer()
                //{
                //    Id = "AC00001",
                //    FirstName = "Lee",
                //    LastName = "jun Che",
                //    Email = "junche@gmail.com",
                //    Password = "123",
                //    Phone = "09865433",
                //    Country = "Korea",
                //    Address = "Seoul, Korea",

                //});
                //foreach (AccCustomer accCustomer in accCustomers)
                //    context.AccCustomers.Add(accCustomer);

                ////Feadback
                //IList<Feedback> feedbacks = new List<Feedback>();
                //feedbacks.Add(new Feedback()
                //{
                //    Id = "FB00001",
                //    Content = "Good",
                //    ProductId = "P000002",
                //    AccCustomerId = "AC00001"


                //});

                //foreach (Feedback feedback in feedbacks)
                //    context.Feedbacks.Add(feedback);

                ////Order
                //IList<Order> orders = new List<Order>();
                //orders.Add(new Order()
                //{
                //    Id = "C000001",
                //    AccCustomerId = "AC00001",
                //    createdAt = Convert.ToDateTime("2020-09-30"),
                //    Status = true,
                //    Total = 200000
                //});
                //orders.Add(new Order()
                //{
                //    Id = "C000002",
                //    AccCustomerId = "AC00001",
                //    createdAt = Convert.ToDateTime("2020-09-30"),
                //    Status = true,
                //    Total = 200000
                //});

                //foreach (Order order in orders)
                //    context.Orders.Add(order);


                ////OrderDetail
                //IList<OrderDetail> orderDetails = new List<OrderDetail>();
                //orderDetails.Add(new OrderDetail()
                //{
                //    Id = "D000001",
                //    OrderId = "C000001",
                //    Quantity = 1,
                //    ProductId = "P000002"
                //});

                //foreach (OrderDetail orderDetail in orderDetails)
                //    context.OrderDetails.Add(orderDetail);
                //base.Seed(context);


            }
        }
    }
}

