using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class clienteBLL
    {
        public clienteBLL()
        {

        }

        ClienteDAL dal = new ClienteDAL();

        public List<ClienteINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public List<ClienteINFO> RetornaTableCod(int cod)
        {
            return dal.RetornaTableCod(cod);
        }

        public ClienteINFO Salvar(ClienteINFO obj)
        {
            return dal.Salvar(obj);
        }

        public ClienteINFO InserirRetornoId(ClienteINFO obj)
        {
            return dal.InserirRetornoId(obj);
        }
        

        public ClienteINFO Delete(ClienteINFO obj)
        {
            return dal.Delete(obj);
        }
        public List<ClienteINFO> TodosClientesAdicionados()
        {
            return dal.SQLTodosClientesAdicionados();
        }
        public List<ClienteINFO> FiltrarPorDatasGrafico(DateTime data)
        {
            return dal.FiltrarPorDatasGrafico(data);
        }
    }
}
