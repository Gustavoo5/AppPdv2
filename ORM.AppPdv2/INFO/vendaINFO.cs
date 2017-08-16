using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class VendaINFO
    {
        public VendaINFO()
        {
                
        }

        public int IdVenda {get;set;}
        public int IdClie {get;set;}
        public decimal ValorTotal {get;set;}
        public DateTime DataVenda {get;set;}
        public int IdFormPag { get; set; }
        public int IdUserVenda { get; set; }
        public bool ativa { get; set; }
        public string status { get; set; }

        public int idFC { get; set; }

        public string NomeClie { get; set; } //inner
        public string NomeUser { get; set; } //inner
        public string DescPag { get; set; } //inner
        public string DescProd { get; set; }
        public int qtd { get; set; } //count
        public decimal total { get; set; } //count
    }
}
