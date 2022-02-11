namespace API.DTOs
{
    public class ClientDto
    {
         public int Id {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
        public string PersonalIdNumber {get; set;}
        public string Details {get; set;}

        public InvoiceDto Invoices {get; set; }
    }
}