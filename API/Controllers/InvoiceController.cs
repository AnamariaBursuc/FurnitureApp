using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   
    [Authorize]

    public class InvoiceController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceController(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _mapper = mapper;
            _invoiceRepository = invoiceRepository;


        }
        
    
      [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDto>>> GetInvoices()
        {
            var invoices = await _invoiceRepository.GetInvoicesAsync();

            return Ok(invoices);

        }
    }
}