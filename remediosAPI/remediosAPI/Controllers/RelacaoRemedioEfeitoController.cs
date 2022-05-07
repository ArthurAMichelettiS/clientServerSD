using remediosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace remediosAPI.Controllers
{
    [RoutePrefix("api/RelacaoRemedioEfeito")]
    public class RemedioEfeitoEfeitoController : ApiController
    {
        private static List<RelacaoRemedioEfeitoModel> listaRelacaoRemedioEfeitos = new
        List<RelacaoRemedioEfeitoModel>();

        public RemedioEfeitoEfeitoController()
        {
            if (listaRelacaoRemedioEfeitos.Count == 0)
                CarregarRelacaoRemedioEfeitos();
        }

        [AcceptVerbs("POST")]
        [Route("CadastrarRelacaoRemedioEfeito")]
        public string CadastrarUsuario(RelacaoRemedioEfeitoModel RelacaoRemedioEfeito)
        {
            listaRelacaoRemedioEfeitos.Add(RelacaoRemedioEfeito);
            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarRelacaoRemedioEfeito")]
        public string AlterarUsuario(RelacaoRemedioEfeitoModel RelacaoRemedioEfeito)
        {
            listaRelacaoRemedioEfeitos.Where(n => n.Codigo ==
            RelacaoRemedioEfeito.Codigo)
            .Select(s =>
            {
                s.Codigo = RelacaoRemedioEfeito.Codigo;
                s.CodigoEfeito = RelacaoRemedioEfeito.CodigoEfeito;
                s.CodigoRemedio = RelacaoRemedioEfeito.CodigoRemedio;
                return s;
            }).ToList();
            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirRelacaoRemedioEfeito/{codigo}")]
        public string ExcluirRelacaoRemedioEfeito(int codigo)
        {
            try
            { 
                RelacaoRemedioEfeitoModel RelacaoRemedioEfeito = listaRelacaoRemedioEfeitos.Where(n => n.Codigo == codigo)
                .Select(n => n)
                .First();
                listaRelacaoRemedioEfeitos.Remove(RelacaoRemedioEfeito);
                return "Registro excluido com sucesso!";
            }
            catch
            {
                return "Inexistente";
            }
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarRelacaoRemedioEfeitoPorCodigo/{codigo}")]
        public RelacaoRemedioEfeitoModel ConsultarRelacaoRemedioEfeitoPorCodigo(int codigo)
        {
            RelacaoRemedioEfeitoModel RelacaoRemedioEfeito = listaRelacaoRemedioEfeitos.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .FirstOrDefault();
            return RelacaoRemedioEfeito;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarRelacaoRemedioEfeitos")]
        public List<RelacaoRemedioEfeitoModel> ConsultarRelacaoRemedioEfeitos()
        {
            //CarregarRelacaoRemedioEfeitos();
            return listaRelacaoRemedioEfeitos;
        }

        private void CarregarRelacaoRemedioEfeitos()
        {
            listaRelacaoRemedioEfeitos.Clear();
            listaRelacaoRemedioEfeitos.Add(new RelacaoRemedioEfeitoModel(1, "1", 3));
            listaRelacaoRemedioEfeitos.Add(new RelacaoRemedioEfeitoModel(2, "1", 2));
            listaRelacaoRemedioEfeitos.Add(new RelacaoRemedioEfeitoModel(3, "3", 1));
            listaRelacaoRemedioEfeitos.Add(new RelacaoRemedioEfeitoModel(4, "3", 4));
        }
    }
}
