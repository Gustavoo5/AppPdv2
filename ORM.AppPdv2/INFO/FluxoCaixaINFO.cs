using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class FluxoCaixaINFO
    {
        public int idFC {get;set;}
        public DateTime dataAbertura {get;set;}
        public decimal saldoInicial {get;set;}
        public decimal saldoBruto {get;set;}
        public decimal saldoLiquido { get; set; }
        public bool situacao { get; set; }
        public int userFechamento { get; set; }
    }
}
