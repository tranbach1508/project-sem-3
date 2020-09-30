namespace WebDAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebDAL.DataModels;

    internal sealed class Configuration : DbMigrationsConfiguration<WebDAL.DataModels.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "WebDAL.DataModels.ShopContext";
        }

        protected override void Seed(WebDAL.DataModels.ShopContext context)
        {
            /*IList<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                Id = "B00010",
                Name = "Book"
            });
            categories.Add(new Category()
            {
                Id = "B00002",
                Name = "Magazines"
            });
            categories.Add(new Category()
            {
                Id = "B00003",
                Name = "Files"
            });
            categories.Add(new Category()
            {
                Id = "B00004",
                Name = "CDs"
            });
            categories.Add(new Category()
            {
                Id = "B00005",
                Name = "DVDs"
            });
            categories.Add(new Category()
            {
                Id = "B00006",
                Name = "Utilities"
            });
            foreach (Category category in categories)
                context.Categories.Add(category);
            base.Seed(context);*/
        }
    }
}
