using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class pagamentoBLL
    {
        public pagamentoBLL()
        {

        }

        pagamentoDAL dal = new pagamentoDAL();

        public List<pagamentoINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public pagamentoINFO Salvar(pagamentoINFO obj)
        {
            return dal.Salvar(obj);
        }

        public pagamentoINFO Delete(pagamentoINFO obj)
        {
            return dal.Delete(obj);
        }
    }
}
