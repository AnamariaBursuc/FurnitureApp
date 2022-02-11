namespace API.Entities
{
    public class InvoiceItem
    {
        public int Id {get; set; }
        public int InvoiceNumber {get; set;}
        public string Name {get; set;}
        public string  Description {get; set;}
        public decimal Price {get; set;}
        public int ItemNumber {get; set;}
        public Invoice Invoice {get; set;}
    }
}