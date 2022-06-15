using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IInvoiceItemRepository
    {
         Task<ICollection<InvoiceItemDto>> GetByInvoiceNumberAsync (string number);
          Task<InvoiceItemDto> GetByIdAsync (int id);
          Task<InvoiceItemDto> GetByNameAsync (string name);
          Task<InvoiceItemDto> Insert (InvoiceItem item);
             Task<InvoiceItemDto> Update (InvoiceItem item);
                Task<InvoiceItemDto> Delete (int id);

         
    }
}