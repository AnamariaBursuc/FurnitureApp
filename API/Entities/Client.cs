namespace API.Entities
{
    public class Client
    {   
        public int Id {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
        public string PersonalIdNumber {get; set;}
        public string Details {get; set;}

        public Invoice Invoices {get; set; }
        
    }
}