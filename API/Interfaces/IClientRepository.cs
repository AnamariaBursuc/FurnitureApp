using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IClientRepository
    {
        Task<ICollection<ClientDto>> GetClientsAsync();
        Task<ClientDto> GetClientByNameAsync(string name);
        Task<ClientDto> InsertClientAsync(ClientDto client);
        void Update(Client client);
        Task<bool> Delete(int id);
        
    }
}