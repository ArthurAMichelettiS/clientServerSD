using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace remedioClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56236/");
            client.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            System.Net.Http.HttpResponseMessage response =
            client.GetAsync("api/remedio/ConsultarRemedios").Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var usuarios = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(usuarios.ToString());
            }
            else
            {
                Console.WriteLine("Erro de comunicação!!!");
            }
            System.Console.ReadLine();
        }
    }
}
