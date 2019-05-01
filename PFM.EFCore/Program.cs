using System;

namespace PFM.EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new PFMContext())
                {
                    Category salary = new Category
                    {
                        Title = "Salary",
                        Kind = Category.KindOfTurnover.Incoming
                    };

                    Category fuel = new Category
                    {
                        Title = "Fuel",
                        Kind = Category.KindOfTurnover.Outgoing
                    };

                    Wallet wallet1 = new Wallet
                    {
                        Amount = 1000,
                        Category = fuel,
                        Kind = fuel.Kind,
                        Date = DateTime.UtcNow,
                        DateCreated = DateTime.UtcNow                        
                    };

                    db.Categories.Add(salary);
                    db.Categories.Add(fuel);
                    db.Wallets.Add(wallet1);
                    db.SaveChanges();
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}
