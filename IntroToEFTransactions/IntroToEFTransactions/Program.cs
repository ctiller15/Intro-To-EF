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

            var t2 = new EFTransactions
            {
                Timestamp = DateTime.Now,
                Action = "Withdraw",
                AccountNumber = 8765,
                AmountChanged = 4332.11m,
                NewAmount = 2554.43m
            };
            var t3 = new EFTransactions
            {
                Timestamp = DateTime.Now,
                Action = "Withdraw",
                AccountNumber = 8767,
                AmountChanged = 90.01m,
                NewAmount = 10000.99m
            };
            var t4 = new EFTransactions
            {
                Timestamp = DateTime.Now,
                Action = "Withdraw",
                AccountNumber = 8768,
                AmountChanged = 1250.23m,
                NewAmount = 854.42m
            };
            var t5 = new EFTransactions
            {
                Timestamp = DateTime.Now,
                Action = "Withdraw",
                AccountNumber = 8761,
                AmountChanged = 578.92m,
                NewAmount = 1111.86m
            };

            var t6 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 12),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t7 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 13),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t8 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 14),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t9 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 15),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t10 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 16),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t11 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 17),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };
            var t12 = new EFTransactions
            {
                Timestamp = new DateTime(2012, 10, 18),
                Action = "Deposit",
                AccountNumber = 66441,
                AmountChanged = 778.42m,
                NewAmount = 99975.43m
            };



            //dbContext.EFTransactions.Add(t1);
            //dbContext.EFTransactions.Add(t2);
            //dbContext.EFTransactions.Add(t3);
            //dbContext.EFTransactions.Add(t4);
            //dbContext.EFTransactions.Add(t5);
            //dbContext.EFTransactions.Add(t6);
            //dbContext.EFTransactions.Add(t7);
            //dbContext.EFTransactions.Add(t8);
            //dbContext.EFTransactions.Add(t9);
            //dbContext.EFTransactions.Add(t10);
            //dbContext.EFTransactions.Add(t11);
            dbContext.EFTransactions.Add(t12);

            // save transactions to db.
            //dbContext.SaveChanges();
            dbContext.SaveChanges();

            // SELECT

            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var TodayTransactions = dbContext.EFTransactions.Where( date => today < date.Timestamp && tomorrow > date.Timestamp);

            //foreach (var transaction in TodayTransactions)
            //{
            //    Console.WriteLine(transaction.Timestamp);
            //    Console.WriteLine(DateTime.Today);
            //    Console.WriteLine(transaction.Timestamp > DateTime.Today);
            //}



            Console.WriteLine("All transactions for today are...");
            foreach (var transaction in TodayTransactions)
            {
                Console.WriteLine(transaction.Timestamp);
            }
            Console.ReadLine();

            var TenMostRecent = dbContext.EFTransactions.Where(transaction => transaction.Timestamp < tomorrow && transaction.AccountNumber == 66441).OrderByDescending(item => item.Timestamp).Take(10);
            foreach (var transaction in TenMostRecent)
            {
                Console.WriteLine(transaction.Timestamp);
            }
            Console.ReadLine();

        }
    }
}
