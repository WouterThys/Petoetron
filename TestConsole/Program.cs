using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<PetoetronContext>());

            using (var ctx = new PetoetronContext())
            {
                var customers = ctx.Customers.ToList();

                foreach (var c in customers)
                {
                    Console.WriteLine($"Customer: {c.Code}");
                }
            }
        }
    }
}
