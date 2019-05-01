using System;
using System.Collections.Generic;
using System.Text;

namespace PFM.EFCore
{
    public class Wallet
    {
        public int WalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateCreated { get; set; }
        public Category.KindOfTurnover Kind { get; set; }
        public string Comment { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
