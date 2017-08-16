using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class ComponenteProdINFO
    {
        public ComponenteProdINFO()
        {

        }
           public int IdCompProd {get;set;}
           public int IdProd {get;set;}
           public int IdProdComp {get;set;}
           public double QtdComp { get; set; }
           public string DescProd { get; set; }

    }
}
