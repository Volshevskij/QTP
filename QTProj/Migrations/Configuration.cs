namespace QTProj.Migrations
{
    using QTProj.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QTProj.Models.CustomersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "QTProj.Models.CustomersContext";
        }

        protected override void Seed(QTProj.Models.CustomersContext context)
        {
            if(!context.Customers.Any())
            {
                Customer customer = new Customer()
                {
                    FistName = "Mark",
                    Surname = "Smith",
                    Address = "Ent st.1",
                    Calls = new List<Call>
                {
                    new Call(){Number = "341414134", Index = "72" },
                    new Call(){Number = "865674364", Index = "73" },
                }
                };

                context.Customers.Add(customer);

                context.SaveChanges();
            }

            if (!context.Calls.Any())
            {             
                context.Calls.AddOrUpdate(
                    new Call() { Number = "341414134", Index = "72" },
                    new Call() { Number = "865674364", Index = "73" }
                    );

                context.SaveChanges();
            }
        }
    }
}
