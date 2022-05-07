using remediosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace remediosAPI.Controllers
{
    [RoutePrefix("api/EfeitoColateral")]
    public class EfeitoColateralController : ApiController
    {
        private static List<EfeitoColateralModel> listaEfeitoColateral = new
        List<EfeitoColateralModel>();

        public EfeitoColateralController()
        {
            if(listaEfeitoColateral.Count==0)
                CarregarEfeitoColateral();
        }

        [AcceptVerbs("POST")]
        [Route("CadastrarEfeitoColateral")]
        public string CadastrarEfeito(EfeitoColateralModel EfeitoColateral)
        {
            listaEfeitoColateral.Add(EfeitoColateral);
            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarEfeitoColateral")]
        public string AlterarEfeito(EfeitoColateralModel efeitoColateral)
        {
            listaEfeitoColateral.Where(n => n.Codigo ==
            efeitoColateral.Codigo)
            .Select(s =>
            {
                s.Codigo = efeitoColateral.Codigo;
                s.OcorrenciaPercentual = efeitoColateral.OcorrenciaPercentual;
                s.Nome = efeitoColateral.Nome;
                return s;
            }).ToList();
            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirEfeitoColateral/{codigo}")]
        public string ExcluirEfeitoColateral(int codigo)
        {
            try
            {
                EfeitoColateralModel efeitoColateral = listaEfeitoColateral.Where(n => n.Codigo == codigo)
                .Select(n => n)
                .First();
                listaEfeitoColateral.Remove(efeitoColateral);
                return "Registro excluido com sucesso!";
            }
            catch
            {
                return "Inexistente";
            }
            
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarEfeitoColateralPorCodigo/{codigo}")]
        public EfeitoColateralModel ConsultarEfeitoColateralPorCodigo(int codigo)
        {
            EfeitoColateralModel efeitoColateral = listaEfeitoColateral.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .FirstOrDefault();
            return efeitoColateral;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarEfeitoColaterals")]
        public List<EfeitoColateralModel> ConsultarEfeitoColateral()
        {
            return listaEfeitoColateral;
        }

        private void CarregarEfeitoColateral()
        {
            listaEfeitoColateral.Clear();
            listaEfeitoColateral.Add(new EfeitoColateralModel(1, "Náusea", 10));
            listaEfeitoColateral.Add(new EfeitoColateralModel(2, "Vômito", 15));
            listaEfeitoColateral.Add(new EfeitoColateralModel(3, "Diarreia", 5));
            listaEfeitoColateral.Add(new EfeitoColateralModel(4, "Tontura", 0.1));
        }
    }
}
