namespace API.DTOs
{
    public class InvoiceItemDto
    {
        public int InvoiceNumber {get; set;}
        public string Name {get; set;}
        public string  Description {get; set;}
        public decimal Price {get; set;}
        public int ItemNumber {get; set;}
    }
}