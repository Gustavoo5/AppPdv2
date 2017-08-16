using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class categoriasBLL
    {
        public categoriasBLL()
        {

        }

        CategoriasDAL dal = new CategoriasDAL();

        public List<CategoriasINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public CategoriasINFO Salvar(CategoriasINFO obj)
        {
            return dal.Salvar(obj);
        }

        public CategoriasINFO Delete(CategoriasINFO obj)
        {
            return dal.Delete(obj);
        }

    }
}
