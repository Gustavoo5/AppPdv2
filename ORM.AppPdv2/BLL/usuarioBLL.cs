using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class usuarioBLL
    {
        public usuarioBLL()
        {

        }

        UsuarioDAL dal = new UsuarioDAL();

        public List<UsuarioINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public UsuarioINFO Salvar(UsuarioINFO obj)
        {
            return dal.Salvar(obj);
        }

        public UsuarioINFO Delete(UsuarioINFO obj)
        {
            return dal.Delete(obj);
        }
    }
}
