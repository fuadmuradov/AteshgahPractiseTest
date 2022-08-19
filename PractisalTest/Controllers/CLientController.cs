using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractisalTest.Controllers
{
    public class CLientController : Controller
    {

        private readonly IClientService clientService;

        public CLientController(IClientService clientService)
        {
            this.clientService = clientService;
        }
        public async Task<IActionResult> Index()
        {
           List<ClientGetDto> clients = await clientService.GetAllClient();
            return View(clients);
        }

        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClient(ClientPostDto postDto)
        {
            clientService.CreateClientAsync(postDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
