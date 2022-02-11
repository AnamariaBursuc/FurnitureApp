using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
    public int Id { get; set; }
    public string Username { get;set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

    public DateTime DateOfBirth {get; set; }

    public string KnownAs {get; set;}

    public DateTime Created {get; set; } = DateTime.Now;
    public DateTime LastActive {get; set; } = DateTime.Now;
    public string Details {get; set;}     
    public string Role {get; set;}        

    public ICollection<Invoice> Invoices {get; set;}
    //  public int GetAge()
    //  {
    //      return DateOfBirth.CalculateAge();
    //  }
    
    }
}