using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace kochka.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class TicketContext : DbContext
    {
        public TicketContext() : base("conn")
        { }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
    public class TicketDbInitializer : DropCreateDatabaseAlways<TicketContext>
    {
        protected override void Seed(TicketContext db)
        {
            db.Tickets.Add(new Ticket { Name = "Разовое посещение", Price = 220 });
            db.Tickets.Add(new Ticket { Name = "12 занятий/месяц ", Price = 1350 });
            db.Tickets.Add(new Ticket { Name = "30 занятий/месяц", Price = 2500 });

            base.Seed(db);
        }
    }
}