using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class SerialBLL
    {
        public SerialBLL()
        {

        }

        SerialDAL dal = new SerialDAL();

        public SerialINFO Salvar(SerialINFO obj)
        {
            return dal.Salvar(obj);
        }

        public List<SerialINFO> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }

        public List<SerialINFO> SelecionarTodosAtivos()
        {
            return dal.SelecionarTodosAtivos();
        }

    }
}
