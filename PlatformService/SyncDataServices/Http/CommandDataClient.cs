using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class CommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public CommandDataClient(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }
        public async Task SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _client.PostAsync($"{_config["CommandService"]}", httpContent);

            if(response.IsSuccessStatusCode)
                Console.WriteLine("---> Command call success");
            else
                Console.WriteLine("---> Command call Failed");


        }
    }
}