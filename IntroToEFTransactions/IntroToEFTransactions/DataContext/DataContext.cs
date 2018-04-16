using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEFTransactions.DataContext
{
    class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }
    }
}
