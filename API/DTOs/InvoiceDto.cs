using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class InvoiceDto
    {
         public string Id {get; set; }
        public string Seria {get; set; }
        public int Number {get; set; }
        public DateTime InvoiceDate {get; set; } = DateTime.Now;
        public ClientDto Client {get; set; }
        public int  ClientId {get; set; }
        
        public decimal Sum {get; set; }

        public decimal TotalSum {get; set; }
        public bool IsPaid {get; set; }
        public ICollection<InvoiceItemDto> Items {get; set;}
        
    }
}