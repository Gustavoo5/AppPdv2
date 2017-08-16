using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class produtosBLL
    {
        public produtosBLL()
        {

        }

        ProdutosDAL dal = new ProdutosDAL();

        public List<ProdutosINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public ProdutosINFO Salvar(ProdutosINFO obj)
        {
            return dal.Salvar(obj);
        }

        public ProdutosINFO Delete(ProdutosINFO obj)
        {
            return dal.Delete(obj);
        }

    }
}
