using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
    public class UsuarioINFO
    {
        public UsuarioINFO()
        {

        }

        public int IdUser {get;set;}
        public string NomeUser {get;set;}
        public string LoginUser {get;set;}
        public int AcessoUser { get; set; }
        public string Senha { get; set; }
        public string img { get; set; }
        
        

    }
}
