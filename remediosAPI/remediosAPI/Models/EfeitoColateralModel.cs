using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace remediosAPI.Models
{
    public class EfeitoColateralModel
    {
        private int codigo
;
        private string nome;
        private double ocorrenciaPercentual;
        public EfeitoColateralModel() { }
        public EfeitoColateralModel(int codigo, string nome, double ocorrenciaPercentual)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.OcorrenciaPercentual = ocorrenciaPercentual;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double OcorrenciaPercentual
        {
            get
            { return ocorrenciaPercentual; }
            set { ocorrenciaPercentual = value; }
        }
    }
}