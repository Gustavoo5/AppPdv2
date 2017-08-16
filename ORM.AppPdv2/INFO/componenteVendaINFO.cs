using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class ComponenteVendaINFO
    {
        public ComponenteVendaINFO()
        {

        }

        public int IdCompVenda {get;set;}
        public int IdVenda {get;set;}
        public int IdProd { get; set; }
        public string DescVenda { get; set; }
        public int QtdProd { get; set; }
        public decimal ValorItem { get; set; } //Criar na Tabela
        public int IdUserVenda { get; set; }

        public string DescProd { get; set; }  //Inner
        public decimal ValorProd { get; set; } //Inner
        public int IdClie { get; set; }
        public int qtd { get; set; } //count para grafico
        public int IdCateg { get; set; }
    }
}
