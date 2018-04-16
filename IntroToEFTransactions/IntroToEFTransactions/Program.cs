using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEFTransactions.Data;

namespace IntroToEFTransactions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Query the database.
            var dbContext = new DataContext();

            var t1 = new EFTransactions
            {
                Timestamp = new DateTime(2008, 05, 24),
                Action = "Deposit",
                AccountNumber = 7775,
                AmountChanged = 300.30m,
                NewAmount = 555.65m
            };
            dbContext.EFTransactions.Add(t1);

            // save transactions to db.
            dbContext.SaveChanges();
        }
    }
}
