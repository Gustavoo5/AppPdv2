using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class componenteProdBLL
    {
        public componenteProdBLL()
        {

        }

        ComponenteProdDAL dal = new ComponenteProdDAL();

        public List<ComponenteProdINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public ComponenteProdINFO Salvar(ComponenteProdINFO obj)
        {
            return dal.Salvar(obj);
        }

        public ComponenteProdINFO Delete(ComponenteProdINFO obj)
        {
            return dal.Delete(obj);
        }

    }
}
