using System;
using System.Collections.Generic;
using System.Text;

namespace PFM.EFCore
{
    public class Category
    {
        public enum KindOfTurnover
        {
            Incoming = 1,
            Outgoing = 0
        }

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public KindOfTurnover Kind { get; set; }

        List<Wallet> Wallets { get; set; }
    }
}
