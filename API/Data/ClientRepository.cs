using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ClientRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }
        public async Task<bool> Delete(int id)
        {
            //throw new System.NotImplementedException();
            Client client = await _context.Clients.FirstOrDefaultAsync(c => c.Id == id);
            _context.Clients.Remove(client);
            var result = await _context.SaveChangesAsync();
            return result == 1 ? true : false;
        }

        public async Task<ClientDto> GetClientByNameAsync(string name)
        {
          //  throw new System.NotImplementedException();
             return await _context.Clients
            .Where(x => x.Name == name)
            .ProjectTo<ClientDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
        }

        public async Task<ICollection<ClientDto>> GetClientsAsync()
        {
            return await _context.Clients
            .ProjectTo<ClientDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }

        public Task<ClientDto> InsertClientAsync(ClientDto client)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
        }
    }
}