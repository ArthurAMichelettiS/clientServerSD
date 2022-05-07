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

            remedio.Route = "Remedio";
            remedio.NomeValor1 = "nome";
            remedio.NomeValor2 = "capacidadePilulas";

            efeitoColateral.Route = "EfeitoColateral";
            efeitoColateral.NomeValor1 = "nome";
            efeitoColateral.NomeValor2 = "ocorrenciaPercentual";

            relacaoRemedioEfeito.Route = "RelacaoRemedioEfeito";
            relacaoRemedioEfeito.NomeValor1 = "CodigoEfeito";
            relacaoRemedioEfeito.NomeValor2 = "CodigoRemedio";

            opcs = new DadosAPI[] { remedio, efeitoColateral, relacaoRemedioEfeito };

        }

        DadosAPI remedio = new DadosAPI();
        DadosAPI efeitoColateral = new DadosAPI();
        DadosAPI relacaoRemedioEfeito = new DadosAPI();

        DadosAPI[] opcs;
        HttpClient client;

        private void btnAPI_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(txtUrl.Text);
            client.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                switch (cbxAcao.SelectedIndex)
                {
                    case 0: //post
                        FazPost();
                        break;
                    case 1: //put
                        FazPut();
                        break;
                    case 2: //get
                        FazGet();
                        break;
                    case 3: //Delete
                        FazDelete();
                        break;
                    case 4: //get all
                        FazGetAll();
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
            }

        }

        public void FazPost()
        {
            if (!Valido())
                return;

            DadosAPI tabelaSelecionada = opcs[cbxTabela.SelectedIndex];
            string json = $"{{\"Codigo\":{txtCodigo.Value}, \"{tabelaSelecionada.NomeValor1}\":\"{txtVal1.Text}\", {tabelaSelecionada.NomeValor2}:{txtVal2.Text}}}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            System.Net.Http.HttpResponseMessage response =
            client.PostAsync($"api/{tabelaSelecionada.Route}/Cadastrar{tabelaSelecionada.Route}", httpContent).Result;
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
                txtDados.Text = "Erro de comunicação!!!";
            }
        }
        public bool Valido()
        {
            return txtVal1.Text.Trim() != string.Empty && txtVal2.Text.Trim() != string.Empty;
        }

        public void FazPut()
        {
            if (!Valido())
                return;

            DadosAPI tabelaSelecionada = opcs[cbxTabela.SelectedIndex];
            string json = $"{{\"Codigo\":{txtCodigo.Value}, \"{tabelaSelecionada.NomeValor1}\":\"{txtVal1.Text}\", {tabelaSelecionada.NomeValor2}:{txtVal2.Text}}}";
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            System.Net.Http.HttpResponseMessage response =
            client.PutAsync($"api/{tabelaSelecionada.Route}/Alterar{tabelaSelecionada.Route}", httpContent).Result;
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
                txtDados.Text = "Erro de comunicação!!!";
            }
        }

        public void FazGet()
        {

            DadosAPI tabelaSelecionada = opcs[cbxTabela.SelectedIndex];

            System.Net.Http.HttpResponseMessage response =
            client.GetAsync($"api/{tabelaSelecionada.Route}/Consultar{tabelaSelecionada.Route}PorCodigo/{txtCodigo.Value}").Result;
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
                txtDados.Text = "Erro de comunicação!!!";
            }
        }

        public void FazDelete()
        {
            DadosAPI tabelaSelecionada = opcs[cbxTabela.SelectedIndex];

            System.Net.Http.HttpResponseMessage response =
            client.DeleteAsync($"api/{tabelaSelecionada.Route}/Excluir{tabelaSelecionada.Route}/{txtCodigo.Value}").Result;
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
                txtDados.Text = "Erro de comunicação!!!";
            }
        }

        public void FazGetAll()
        {
            DadosAPI tabelaSelecionada = opcs[cbxTabela.SelectedIndex];

            System.Net.Http.HttpResponseMessage response =
            client.GetAsync($"api/{tabelaSelecionada.Route}/Consultar{tabelaSelecionada.Route}s").Result;
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
                txtDados.Text = "Erro de comunicação!!!";
            }
        }

        class DadosAPI
        {
            public string Route { get; set; }
            public string NomeValor1 { get; set; }
            public string NomeValor2 { get; set; }
        }

        private void cbxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAcao.Enabled = true;
            panelInput.Enabled = true;
            btnAPI.Enabled = true;
            cbxAcao.SelectedIndex = 0;
            lblVal1.Text = opcs[cbxTabela.SelectedIndex].NomeValor1;
            lblVal2.Text = opcs[cbxTabela.SelectedIndex].NomeValor2;
        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelValor.Enabled = true;
            panelInput.Enabled = true;
            if (cbxAcao.SelectedIndex == 2|| cbxAcao.SelectedIndex == 3)
            {
                panelValor.Enabled = false;
            }
            else if(cbxAcao.SelectedIndex == 4)
            {
                panelInput.Enabled = false;
            }
        }
    }
}
