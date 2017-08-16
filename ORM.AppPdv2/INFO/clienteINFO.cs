using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class ClienteINFO
    {
        public ClienteINFO()
        {

        }

       public int IdClie {get;set;}
       public string NomeClie { get; set; }
       public DateTime DataCadastro { get; set; }
       public string telNumero { get; set; }
       public string CpfClie { get; set; }
       public string EndClie { get; set; }
       public string BairroClie { get; set; }
       public string CidadeClie { get; set; }
       public string ObsClie { get; set; }

        public int qtdClientes { get; set; } //count
    }
}
