using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.INFO
{
   public class AtivacaoINFO
    {
        public int DataId { get; set; }
        public DateTime DiaDaAtivacao { get; set; }
        public DateTime DiaDaExpiracao { get; set; }
        public int Contador { get; set; }
        public bool Ativo { get; set; }

        public int Serial { get; set; }
    }
}
