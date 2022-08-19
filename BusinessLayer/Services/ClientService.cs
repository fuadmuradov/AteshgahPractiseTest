using AutoMapper;
using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.Interfaces;
using PractisalTest.Core;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private static Random random = new Random();
        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task CreateClientAsync(ClientPostDto clientPostDto)
        {
            Client client = mapper.Map<Client>(clientPostDto);
            client.ClientUniqueId = RandomString(8);
            await unitOfWork.ClientRepository.AddAsync(client);
            await unitOfWork.ClientRepository.SaveDbAsync();
        }

       

        public async Task<List<ClientGetDto>> GetAllClient()
        {
            List<Client> clients = unitOfWork.ClientRepository.GetAll(x => x.ClientUniqueId != "").ToList();
            List<ClientGetDto> clientGets = mapper.Map<List<Client>, List<ClientGetDto>>(clients);

            return clientGets;
        }

        public async Task<ClientGetDto> GetClientAsync(string id)
        {
            Client client = await unitOfWork.ClientRepository.GetAsync(x => x.ClientUniqueId == id);
            return mapper.Map<ClientGetDto>(client);
        }



       

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
