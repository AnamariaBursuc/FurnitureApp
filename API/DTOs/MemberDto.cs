using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
                 public int Id { get; set; }
    public string Username { get;set; }
      public string PhotoUrl { get;set; }

    public int Age {get; set; }

    public string KnownAs {get; set;}

    public DateTime Created {get; set; } = DateTime.Now;
    public DateTime LastActive {get; set; } = DateTime.Now;
    public string Details {get; set;}     
    public string Role {get; set;}      
    public Photo Photo {get; set;}
    public ICollection<InvoiceDto> Invoices {get; set;}  

    }
}