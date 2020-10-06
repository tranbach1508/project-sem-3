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
            IList<AccAdmin> admins = new List<AccAdmin>();
            admins.Add(new AccAdmin()
            {
                Id = "Ad00001",
                Username = "admin",
                Password = "123456"
            });
            foreach (AccAdmin ad in admins)
                context.AccAdmins.AddOrUpdate(ad);
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
                Image = "https://salt.tikicdn.com/cache/w390/ts/product/b0/42/7f/0e4207cd679280e55d3d74b81f85b5d2.jpg",
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
                Image = "https://m.media-amazon.com/images/I/61hXbkcoxGL.jpg",
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
                Image = "https://salt.tikicdn.com/cache/w390/ts/product/c8/ad/76/0a07da53aee62229bb65e9e7dd6127de.jpg",
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
                Image = "data:image/jpeg;base64,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",
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
                Image = "data:image/jpeg;base64,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",
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
                Image = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/book-fair-poster-design-template-49af2ee3b6ba00470d21b469de198418_screen.jpg?ts=1561403015",
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
                Image = "https://png.pngtree.com/templates/20190520/ourlarge/pngtree-creative-minimal-world-reading-day-charity-poster-book-daypublic-postersposterpublic-image_194231.jpg",
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
                Image = "https://salt.tikicdn.com/cache/w1200/ts/product/98/db/d1/2da6ad5486f1b1f138da6628a4f095b6.jpg",
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
            accCustomers.Add(new AccCustomer()
            {
                Id = "AC00007",
                FirstName = "Tran",
                LastName = "Bach",
                Email = "tranbach2000@gmail.com",
                Password = "tranbach123",
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
