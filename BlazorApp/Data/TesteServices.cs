using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TesteServices : ComponentBase
    {
        public List<Teste> Teste { get; set; }
        public bool Loading { get; set; }

        HttpClient Cliente = new HttpClient();
        
        public TesteServices()
        {
            Cliente.BaseAddress = new Uri("http://hetosoft.ddns.com.br:8086/api/Geral/GetSACSistemas");
        }

        protected async override Task OnInitializedAsync()
        {
            await Task.Run(GetDataAsync);
        }

        public async Task<List<Teste>> GetDataAsync()
        {
            Thread.Sleep(5000);

            HttpResponseMessage response = await Cliente.GetAsync(Cliente.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                Teste = JsonConvert.DeserializeObject<List<Teste>>(dados);
                return Teste;
            }

            return null;
        }

    }
}
