using remediosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace remediosAPI.Controllers
{
    [RoutePrefix("api/Remedio")]
    public class RemedioController : ApiController
    {
        private static List<RemedioModel> listaRemedios = new
        List<RemedioModel>();

        public RemedioController()
        {
            if (listaRemedios.Count == 0)
                CarregarRemedios();
        }

        [AcceptVerbs("POST")]
        [Route("CadastrarRemedio")]
        public string CadastrarUsuario(RemedioModel remedio)
        {
            listaRemedios.Add(remedio);
            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarRemedio")]
        public string AlterarUsuario(RemedioModel remedio)
        {
            listaRemedios.Where(n => n.Codigo ==
            remedio.Codigo)
            .Select(s =>
            {
                s.Codigo = remedio.Codigo;
                s.CapacidadePilulas = remedio.CapacidadePilulas;
                s.Nome = remedio.Nome;
                return s;
            }).ToList();
            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirRemedio/{codigo}")]
        public string ExcluirRemedio(int codigo)
        {
            try
            {
                RemedioModel remedio = listaRemedios.Where(n => n.Codigo == codigo)
                .Select(n => n)
                .First();
                listaRemedios.Remove(remedio);
                return "Registro excluido com sucesso!";
            }
            catch
            {
                return "Inexistente";
            }
           
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarRemedioPorCodigo/{codigo}")]
        public RemedioModel ConsultarRemedioPorCodigo(int codigo)
        {
            RemedioModel remedio = listaRemedios.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .FirstOrDefault();
            return remedio;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarRemedios")]
        public List<RemedioModel> ConsultarRemedios()
        {
            //CarregarRemedios();
            return listaRemedios;
        }

        private void CarregarRemedios()
        {
            listaRemedios.Clear();
            listaRemedios.Add(new RemedioModel(1, "Parasetamol", 20));
            listaRemedios.Add(new RemedioModel(2, "Dorflex", 12));
            listaRemedios.Add(new RemedioModel(3, "Ritalina", 30));
            listaRemedios.Add(new RemedioModel(4, "Aradois", 30));
        }
    }
}
