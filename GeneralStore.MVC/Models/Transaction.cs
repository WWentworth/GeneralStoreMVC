using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}