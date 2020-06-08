using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kochka.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
   
        public string Person { get; set; }
       
        public string Eaddress { get; set; }
      
        public int TicketId { get; set; }
        public int Card { get; set; }
       
        public DateTime Date { get; set; }
    }
}