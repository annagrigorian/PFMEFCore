using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace PFM.EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            using (var db = new PFMContext())
            {
                db.Database.EnsureCreated();
            }

            using (var db = new PFMContext())
            {
                var categories = new Category[]
                {
                    new Category
                    {
                        Title = "Salary",
                        Kind = Category.KindOfTurnover.Incoming
                    },
                    new Category
                    {
                        Title = "Fuel",
                        Kind = Category.KindOfTurnover.Outgoing
                    },
                    new Category
                    {
                        Title = "Entertainment",
                        Kind = Category.KindOfTurnover.Outgoing
                    },
                    new Category
                    {
                        Title = "Food",
                        Kind = Category.KindOfTurnover.Outgoing
                    }
                };

                db.Categories.AddRange(categories);

                db.SaveChanges();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; i < 1000; i++)
                    {
                        var category = categories[rd.Next(0, categories.Length - 1)];
                        db.Wallets.Add(new Wallet
                        {
                            Amount = rd.Next(5,200) * 100,
                            Category = category,
                            Kind = category.Kind,
                            Date = DateTime.UtcNow,
                            DateCreated = DateTime.UtcNow
                        });
                    }
                    db.SaveChanges();
                }
                db.SaveChanges();
            }
        }
    }
}
