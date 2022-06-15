using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClientController : BaseApiController
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;

        }
         [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetClients()
        {
            var clients = await _clientRepository.GetClientsAsync();

            return Ok(clients);

        }

    }
}