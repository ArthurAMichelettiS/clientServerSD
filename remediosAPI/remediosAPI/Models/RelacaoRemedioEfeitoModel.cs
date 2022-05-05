using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace remediosAPI.Models
{
    public class RelacaoRemedioEfeitoModel
    {
        private int codigo
;
        private int codigoRemedio;
        private int codigoEfeito;
        public RelacaoRemedioEfeitoModel() { }
        public RelacaoRemedioEfeitoModel(int codigo, int codigoRemedio, int codigoEfeito)
        {
            this.Codigo = codigo;
            this.CodigoRemedio = codigoRemedio;
            this.CodigoEfeito = codigoEfeito;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int CodigoRemedio
        {
            get { return codigoRemedio; }
            set { codigoRemedio = value; }
        }
        public int CodigoEfeito
        {
            get
            { return codigoEfeito; }
            set { codigoEfeito = value; }
        }
    }
}