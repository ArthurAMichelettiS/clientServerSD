using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remedioClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            remedio.Route = "remedio";
            remedio.NomeValor1 = "nome";
            remedio.NomeValor2 = "capacidadePilulas";

            efeitoColateral.Route = "efeitoColateral";
            efeitoColateral.NomeValor1 = "nome";
            efeitoColateral.NomeValor2 = "ocorrenciaPercentual";

            relacaoRemedioEfeito.Route = "relacaoRemedioEfeito";
            relacaoRemedioEfeito.NomeValor1 = "CodigoEfeito";
            relacaoRemedioEfeito.NomeValor2 = "CodigoRemedio";

            opcs = new DadosAPI[] { remedio, efeitoColateral, relacaoRemedioEfeito };

        }

        DadosAPI remedio = new DadosAPI();
        DadosAPI efeitoColateral = new DadosAPI();
        DadosAPI relacaoRemedioEfeito = new DadosAPI();

        DadosAPI[] opcs;

        private void btnAPI_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56236/");
            client.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            //todo swich case baseado na ação
            

            System.Net.Http.HttpResponseMessage response =
            client.GetAsync("api/remedio/ConsultarRemedios").Result;
            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {//pegando o cabeçalho
                Uri usuarioUri = response.Headers.Location;
                //Pegando os dados do Rest e armazenando na variável usuários
                var usuarios = response.Content.ReadAsStringAsync().Result;
                txtDados.Text = usuarios.ToString();

            }
            else
            {
                Console.WriteLine("Erro de comunicação!!!");
            }
            System.Console.ReadLine();
        }

        class DadosAPI
        {
            public string Route { get; set; }
            public string NomeValor1 { get; set; }
            public string NomeValor2 { get; set; }
        }

        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVal1.Text = opcs[cbxTabela.SelectedIndex].NomeValor1;
            lblVal2.Text = opcs[cbxTabela.SelectedIndex].NomeValor2;
        }
    }
}
