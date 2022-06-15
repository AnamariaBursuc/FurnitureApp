using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{

    public class InvoiceRepository : IInvoiceRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public InvoiceRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceDto> GetInvoiceAsync(int Number)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<InvoiceDto>> GetInvoiceByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<InvoiceDto>> GetInvoicesAsync()
        {
          
            return await _context.Invoices
            .ProjectTo<InvoiceDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }

        public Task<ICollection<InvoiceDto>> GetInvoicesNearlyExpiredAsync()
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceDto> InsertInvoiceAsync(InvoiceDto invoice)
        {
            throw new NotImplementedException();
        }

        public void Update(InvoiceDto invoice)
        {
            throw new NotImplementedException();
        }
    }
}