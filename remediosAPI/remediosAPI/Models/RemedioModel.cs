using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace remediosAPI.Models
{
    public class RemedioModel
    {
        private int codigo
;
        private string nome;
        private int capacidadePilulas;
        public RemedioModel() { }
        public RemedioModel(int codigo, string nome, int capacidadePilulas)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CapacidadePilulas = capacidadePilulas;
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
        public int CapacidadePilulas
        {
            get
            { return capacidadePilulas; }
            set { capacidadePilulas = value; }
        }
    }
}