using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class ProdutosINFO
    {
        public ProdutosINFO()
        {

        }

        public int IdProd { get; set; }
        //public int idForn{get;set;}
        public int IdCateg { get; set; }
        public string DescProd { get; set; }
        public double QtdProd { get; set; }
        public decimal ValorProd { get; set; }
        public string DescCateg { get; set; }
        //public string razao_social { get; set; }

    }
}
