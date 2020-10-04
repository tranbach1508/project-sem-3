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
            IList<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                Id = "B00001",
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
                context.Categories.AddOrUpdate(category);

            // Author
            IList<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                Id = "A000001",
                Name = "Nguyen Binh",
                Info = "Nguyen Binh (born May 7, 1955) is a Vietnamese author who writes for teenagers and adults."
            });
            authors.Add(new Author()
            {
                Id = "A000002",
                Name = "Tran Bach",
                Info = "Tran Bach (born May 7, 1955) is a Vietnamese author who writes for teenagers and adults."
            });
            authors.Add(new Author()
            {
                Id = "A000003",
                Name = "Truong Giang",
                Info = "Tran Bach (born June 10th, 1940) is a great poet in America during the 90s."
            });
            authors.Add(new Author()
            {
                Id = "A000004",
                Name = "William Shakespeare",
                Info = "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English playwright, poet, and actor, widely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's national poet and the Bard of Avon (or simply the Bard)."
            });
            authors.Add(new Author()
            {
                Id = "A000005",
                Name = "Ernest Hemingway",
                Info = "Ernest Miller Hemingway (July 21, 1899 – July 2, 1961) was an American journalist, novelist, short-story writer, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations."
            });
            authors.Add(new Author()
            {
                Id = "A000006",
                Name = "Leo Tolstoy",
                Info = "Lev Nikolayevich Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time.[3] He received multiple nominations for the Nobel Prize in Literature every year from 1902 to 1906 and nominations for the Nobel Peace Prize in 1901, 1902, and 1910, and that he never won is a major controversy."
            });
            authors.Add(new Author()
            {
                Id = "A000007",
                Name = "Johann Sebastian Bach",
                Info = "Johann Sebastian Bach (31 March [O.S. 21 March] 1685 – 28 July 1750) was a German composer and musician of the Baroque period. He is known for instrumental compositions such as the Brandenburg Concertos and the Goldberg Variations, and for vocal music such as the St Matthew Passion and the Mass in B minor. Since the 19th-century Bach Revival he has been generally regarded as one of the greatest composers of all time."
            });
            authors.Add(new Author()
            {
                Id = "A000008",
                Name = "Wolfgang Amadeus Mozart",
                Info = "Wolfgang Amadeus Mozart[a] (27 January 1756 – 5 December 1791), baptised as Johannes Chrysostomus Wolfgangus Theophilus Mozart, was a prolific and influential composer of the Classical period."
            });
            authors.Add(new Author()
            {
                Id = "A0000010",
                Name = "Wilhelm Richard Wagner",
                Info = "Wilhelm Richard Wagner (/ˈvɑːɡnər/ VAHG-nər, German: [ˈʁɪçaʁt ˈvaːɡnɐ] (About this soundlisten); 22 May 1813 – 13 February 1883) was a German composer, theatre director, polemicist, and conductor who is chiefly known for his operas (or, as some of his mature works were later known, music dramas)."
            });
            authors.Add(new Author()
            {
                Id = "A000009",
                Name = "Johannes Brahms",
                Info = "Johannes Brahms (German: [joˈhanəs ˈbʁaːms]; 7 May 1833 – 3 April 1897) was a German composer, pianist, and conductor of the Romantic period. Brahms composed for symphony orchestra, chamber ensembles, piano, organ, and voice and chorus. A virtuoso pianist, he premiered many of his own works. "
            });
            foreach (Author author in authors)
                context.Authors.AddOrUpdate(author);

            //Publisher
            IList<Publisher> publishers = new List<Publisher>();
            publishers.Add(new Publisher()
            {
                Id = "P000001",
                Name = "Oxford University Press",
                Info = "Oxford University Press(OUP) is one of the largest university publishers in the world."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000002",
                Name = "Cambridge University Press",
                Info = "Cambridge University Press(CUP) is a Cambridge University Press."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000003",
                Name = "Cambridge University Press",
                Info = "Cambridge University Press(CUP) is a Cambridge University Press."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000004",
                Name = "RELX Group (Reed Elsevier)",
                Info = "Today Elsevier is considered the largest scientific publication in the world. Elsevier sells mainly literary books and dictionaries. By 1930, Elsevier expanded into various publications."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000005",
                Name = "Pearson",
                Info = "Pearson Education is known as a book publisher specializing in English books to help readers practice and improve each skill such as writing, spelling, using, thesaurus, IELTS, Toeic, ELT,. .."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000006",
                Name = "ThomsonReuters",
                Info = "Thomson Reuters provides important industry insights to top managers in finance, accounting, science, law, tax, healthcare, markets, media ..."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000007",
                Name = "Bertelsmann",
                Info = "Bertelsmann was founded by Carl Bertelsmann as a publisher in 1835. After World War II, Bertelsmann, under the leadership of Reinhard Mohn, went from a midsize business to a large corporation, not just supplying books. but also television, radio, music, magazines and services."
            });
            publishers.Add(new Publisher()
            {
                Id = "P000008",
                Name = "Wolters Kluwer",
                Info = "The company is active in more than 150 countries. About 74% of Wolters Kluwer's revenue came from online, software and services in 2013. The US medical publishing business is now run by Wolters Kluwer Health."
            });
            foreach (Publisher publisher in publishers)
                context.Publishers.AddOrUpdate(publisher);

            //Subcategory
            IList<Subcategory> subcategories = new List<Subcategory>();
            subcategories.Add(new Subcategory()
            {
                Id = "SB00001",
                Name = "Dictionaries & Languages",
                CategoryId = "B00001"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00002",
                Name = "Children's Books",
                CategoryId = "B00001"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00003",
                Name = "Erbauliche Monaths Unterredungen",
                CategoryId = "B00002"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00004",
                Name = "Children's Books",
                CategoryId = "B00003"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00005",
                Name = "Children's Books",
                CategoryId = "B00004"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00006",
                Name = "Children's Books",
                CategoryId = "B00005"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00007",
                Name = "Children's Books",
                CategoryId = "B00006"
            });
            subcategories.Add(new Subcategory()
            {
                Id = "SB00008",
                Name = "Children's Books",
                CategoryId = "B00006"
            });
            foreach (Subcategory subcategory in subcategories)
                context.Subcategories.AddOrUpdate(subcategory);

            //Product
            IList<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = "P000001",
                Name = "The Little Prince",
                Image = "",
                Price = 2000000,
                Quantity = 2,
                Description = "The Little Prince, written in New York, was first published in New York in 1943",
                CategoryId = "B00001",
                AuthorId = "A000001",
                PublisherId = "P000001",
                SubcategoryId = "SB00001"
            });
            products.Add(new Product()
            {
                Id = "P000002",
                Name = "Harry Potter and the Philosopher's Stone",
                Image = "",
                Price = 230000,
                Quantity = 2,
                Description = "The Little Prince, written in New York, was first published in New York in 1943",
                CategoryId = "B00002",
                AuthorId = "A000002",
                PublisherId = "P000002",
                SubcategoryId = "SB00002"
            });
            products.Add(new Product()
            {
                Id = "P000003",
                Name = "I'm talented, so are you - Adam Khoo.",
                Image = "",
                Price = 220000,
                Quantity = 5,
                Description = "The author shares the secrets of his success with readers in simple and clear terms, with exercises to help train others in his techniques. It takes the reader on an exhilarating journey of self-discover and it is not just about learning, but stretching and realising one's potential",
                CategoryId = "B00003",
                AuthorId = "A000003",
                PublisherId = "P000003",
                SubcategoryId = "SB00003"
            });
            products.Add(new Product()
            {
                Id = "P000004",
                Name = "How to Win Friends and Influence People",
                Image = "",
                Price = 260000,
                Quantity = 2,
                Description = "Since its release in 1936, How to Win Friends and Influence People has sold more than 15 million copies. Dale Carnegie's first book is a timeless bestseller, packed with rock-solid advice that has carried thousands of now famous people up the ladder of success in their business and personal lives.",
                CategoryId = "B00004",
                AuthorId = "A000004",
                PublisherId = "P000004",
                SubcategoryId = "SB00004"
            });
            products.Add(new Product()
            {
                Id = "P000005",
                Name = "This book contains proven steps and strategies ",
                Image = "",
                Price = 230000,
                Quantity = 2,
                Description = "The Little Prince, written in New York, was first published in New York in 1943. on how to seek your personal legend; to follow your dreams, and along the journey learn lessons only you and the soul of the world would know.",
                CategoryId = "B00005",
                AuthorId = "A000005",
                PublisherId = "P000005",
                SubcategoryId = "SB00005"
            });
            products.Add(new Product()
            {
                Id = "P000006",
                Name = "Capturing the Devil",
                Image = "",
                Price = 278000,
                Quantity = 2,
                Description = "Audrey Rose Wadsworth and Thomas Cresswell have landed in America, a bold, brash land unlike the genteel streets of London they knew. But like London, the city of Chicago hides its dark secrets well. When the two attend the spectacular World's Fair, they find the once-in-a-lifetime event tainted with reports of missing people and unsolved murders",
                CategoryId = "B00006",
                AuthorId = "A000006",
                PublisherId = "P000006",
                SubcategoryId = "SB00006"
            });
            products.Add(new Product()
            {
                Id = "P000007",
                Name = "Changepower!: 37 Secrets to Habit Change Success",
                Image = "",
                Price = 230000,
                Quantity = 2,
                Description = "Selig helps habit-changers move beyond willpower and succeed with changepower - the synergy that comes from combining willpower with other resources, useful outside supports, and wise strategies. In Changepower!, she shows habit-changers how to beef up both their willpower and their changepower to achieve habit change success. The key is revving up motivation. Selig reveals the most powerful motivators for change - pain motivators, the Eight Great Motivators, and even not-so-noble motivators.",
                CategoryId = "B00006",
                AuthorId = "A000007",
                PublisherId = "P000007",
                SubcategoryId = "SB00006"
            });
            products.Add(new Product()
            {
                Id = "P000008",
                Name = "Success And Happiness: 7 Habits To A Fulfilling Life ",
                Image = "",
                Price = 230000,
                Quantity = 2,
                Description = "I have been studying personal development and success for 10 years. After trying thousands of methods to increase my happiness and success I finally found the magic formula that actually works. It consists of 7 powerful habits. These 7 habits are used by successful people, top companies, and millions of other individuals who are living an enjoyable life.",
                CategoryId = "B00005",
                AuthorId = "A000008",
                PublisherId = "P000008",
                SubcategoryId = "SB00005"
            });
            foreach (Product product in products)
                context.Products.AddOrUpdate(product);


            //Faq
            IList<Faq> faqs = new List<Faq>();
            faqs.Add(new Faq()
            {
                Id = "F000001",
                Query = "",
                Answer = "I want to order when it is not available to receive?"
            });
            faqs.Add(new Faq()
            {
                Id = "F000002",
                Query = "",
                Answer = "Is there a discount for more bookings?"
            });
            faqs.Add(new Faq()
            {
                Id = "F000003",
                Query = "",
                Answer = "I can't find the book I want?"
            });
            faqs.Add(new Faq()
            {
                Id = "F000004",
                Query = "",
                Answer = "How can I contact the store ? "
            });
            foreach (Faq faq in faqs)
                context.Faqs.AddOrUpdate(faq);

            // AccCustomer
            IList<AccCustomer> accCustomers = new List<AccCustomer>();
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00001",
                FirstName = "Lee",
                LastName = "jun Che",
                Email = "junche@gmail.com",
                Password = "123456",
                Phone = "09865433",
                Country = "Korea",
                Address = "Seoul, Korea",

            });
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00002",
                FirstName = "Han",
                LastName = "Kyou Yi",
                Email = "Anch123@gmail.com",
                Password = "123456",
                Phone = "0986541432",
                Country = "Korea",
                Address = "Seoul, Korea",

            });
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00003",
                FirstName = "DO",
                LastName = "Van Cu",
                Email = "vancu435@gmail.com",
                Password = "7764521",
                Phone = "096893317",
                Country = "VietNam",
                Address = "Ha Noi, Viet Nam",

            });
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00004",
                FirstName = "Binh",
                LastName = "Binh Do",
                Email = "dothibinh@gmail.com",
                Password = "abc78965",
                Phone = "098665412",
                Country = "VietNam",
                Address = "Ha Noi, Viet Nam",

            });
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00005",
                FirstName = "Vu",
                LastName = "Song Vu",
                Email = "VuSongvu123@gmail.com",
                Password = "VuSong24s$",
                Phone = "090967884",
                Country = "VietNam",
                Address = "Ha Noi, Viet Nam",
            });
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00006",
                FirstName = "Kinh",
                LastName = "You Kinh",
                Email = "junche14w@gmail.com",
                Password = "junche14w",
                Phone = "0986535430",
                Country = "VietNam",
                Address = "Ha Noi, Viet Nam",
            });
            foreach (AccCustomer accCustomer in accCustomers)
                context.AccCustomers.AddOrUpdate(accCustomer);

            //Feadback
            IList<Feedback> feedbacks = new List<Feedback>();
            feedbacks.Add(new Feedback()
            {
                Id = "FB00001",
                Content = "Thanks, I really like it",
                ProductId = "P000001",
                AccCustomerId = "AC00001"


            });
            feedbacks.Add(new Feedback()
            {
                Id = "FB00002",
                Content = "very good",
                ProductId = "P000002",
                AccCustomerId = "AC00002"


            });
            feedbacks.Add(new Feedback()
            {
                Id = "FB00003",
                Content = "extremely good",
                ProductId = "P000002",
                AccCustomerId = "AC00003"


            });
            feedbacks.Add(new Feedback()
            {
                Id = "FB00004",
                Content = "extremely good",
                ProductId = "P000004",
                AccCustomerId = "AC00004"


            });
            feedbacks.Add(new Feedback()
            {
                Id = "FB00005",
                Content = "Very pleased",
                ProductId = "P000004",
                AccCustomerId = "AC00004"


            });

            foreach (Feedback feedback in feedbacks)
                context.Feedbacks.AddOrUpdate(feedback);

            //Order
            IList<Order> orders = new List<Order>();
            orders.Add(new Order()
            {
                Id = "C000001",
                AccCustomerId = "AC00001",
                createdAt = Convert.ToDateTime("2020-09-27"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000002",
                AccCustomerId = "AC00002",
                createdAt = Convert.ToDateTime("2020-09-20"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000003",
                AccCustomerId = "AC00003",
                createdAt = Convert.ToDateTime("2020-09-10"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000004",
                AccCustomerId = "AC00004",
                createdAt = Convert.ToDateTime("2020-09-30"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000005",
                AccCustomerId = "AC00005",
                createdAt = Convert.ToDateTime("2020-09-15"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000006",
                AccCustomerId = "AC00006",
                createdAt = Convert.ToDateTime("2020-09-01"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000007",
                AccCustomerId = "AC00004",
                createdAt = Convert.ToDateTime("2020-09-22"),
                Status = true,
            });
            orders.Add(new Order()
            {
                Id = "C000008",
                AccCustomerId = "AC00002",
                createdAt = Convert.ToDateTime("2020-09-21"),
                Status = true,
            });

            foreach (Order order in orders)
                context.Orders.AddOrUpdate(order);


            //OrderDetail
            IList<OrderDetail> orderDetails = new List<OrderDetail>();
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000001",
                OrderId = "C000001",
                Quantity = 1,
                ProductId = "P000002"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000002",
                OrderId = "C000003",
                Quantity = 1,
                ProductId = "P000002"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000003",
                OrderId = "C000003",
                Quantity = 1,
                ProductId = "P000003"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000004",
                OrderId = "C000004",
                Quantity = 1,
                ProductId = "P000004"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000005",
                OrderId = "C000005",
                Quantity = 1,
                ProductId = "P000005"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000006",
                OrderId = "C000006",
                Quantity = 1,
                ProductId = "P000006"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000007",
                OrderId = "C000006",
                Quantity = 1,
                ProductId = "P000006"
            });
            orderDetails.Add(new OrderDetail()
            {
                Id = "D000008",
                OrderId = "C000005",
                Quantity = 1,
                ProductId = "P000005"
            });
            foreach (OrderDetail orderDetail in orderDetails)
                context.OrderDetails.AddOrUpdate(orderDetail);
            base.Seed(context);
        }
    }
}
