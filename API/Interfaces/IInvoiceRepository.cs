using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;

namespace API.Interfaces
{
    public interface IInvoiceRepository
    {
       
        Task <InvoiceDto> GetInvoiceAsync(int Number);
        Task<ICollection<InvoiceDto>>  GetInvoiceByDateAsync(DateTime date);
         Task<ICollection<InvoiceDto>> GetInvoicesNearlyExpiredAsync();
         Task<ICollection<InvoiceDto>> GetInvoicesAsync();
        Task<InvoiceDto> InsertInvoiceAsync(InvoiceDto invoice);
        void Update(InvoiceDto invoice);
        Task<bool> Delete(int id);
         
         
    }
}