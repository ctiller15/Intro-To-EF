using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEFTransactions
{
    class EFTransactions
    {
        /*
         ID (PK)
         Timestamp (DateTime)
         Action (String)
         AccountNumber(Int)
         AmountChanged(decimal)
         newAmount(decimal)
         */

        public int ID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
        public int AccountNumber { get; set; }
        public decimal AmountChanged { get; set; }
        public decimal NewAmount { get; set; }
    }
}
