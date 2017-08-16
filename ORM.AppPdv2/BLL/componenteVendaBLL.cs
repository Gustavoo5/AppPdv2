using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class componenteVendaBLL
    {
        public componenteVendaBLL()
        {
                
        }

        ComponenteVendaDAL dal = new ComponenteVendaDAL();

        public List<ComponenteVendaINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public List<ComponenteVendaINFO> RetornaTableGraficoCons(ComponenteVendaINFO obj)
        {
            return dal.RetornaTableGraficoCons(obj);
        }

        public List<ComponenteVendaINFO> RetornaTableItensClie(ComponenteVendaINFO obj)
        {
            return dal.RetornaTableItensClie(obj);
        }

        public List<ComponenteVendaINFO> RetornaTableGraficoModel(ComponenteVendaINFO obj)
        {
            return dal.RetornaTableGraficoModel(obj);
        }

        public List<ComponenteVendaINFO> RetornaTableItensUser(ComponenteVendaINFO obj)
        {
            return dal.RetornaTableItensUser(obj);
        }

        public ComponenteVendaINFO Salvar(ComponenteVendaINFO obj)
        {
            return dal.Salvar(obj);
        }

        public ComponenteVendaINFO Delete(ComponenteVendaINFO obj)
        {
            return dal.Delete(obj);
        }

        

    }
}
