using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class fornecedorBLL
    {
        public fornecedorBLL()
        {

        }

        FornecedorDAL dal = new FornecedorDAL();

        public List<FornecedorINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public FornecedorINFO Salvar(FornecedorINFO obj)
        {
            return dal.Salvar(obj);
        }

        public FornecedorINFO Delete(FornecedorINFO obj)
        {
            return dal.Delete(obj);
        }
    }
}
