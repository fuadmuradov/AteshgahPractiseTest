using BusinessLayer.DTOs.ClientDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IClientService
    {
        Task CreateClientAsync(ClientPostDto clientPostDto);
        Task<List<ClientGetDto>> GetAllClient();
        Task<ClientGetDto> GetClientAsync(string id);
    }
}
