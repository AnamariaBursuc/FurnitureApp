using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  [Table("Facturi")]
    public class Invoice
  
      {
      
        public string Id {get; set; }
        public string Seria {get; set; }
        public int Number {get; set; }
        public DateTime InvoiceDate {get; set; } = DateTime.Now;
        public Client Client {get; set; }
        public int  ClientId {get; set; }
        
        public decimal Sum {get; set; }

        public decimal TotalSum {get; set; }
        public bool IsPaid {get; set; }
        
public ICollection<InvoiceItem> Items {get; set;}

        

    }
}