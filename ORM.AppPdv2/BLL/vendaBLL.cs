using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;

namespace ORM.AppPdv2.BLL
{
    public class vendaBLL
    {
        public vendaBLL()
        {

        }

        VendaDAL dal = new VendaDAL();

        public List<VendaINFO> RetornaTable()
        {
            return dal.RetornaTable();
        }

        public List<VendaINFO> RetornaTableCountTotalUserSelecionar()
        {
            return dal.RetornaTableCountTotalUserSelecionar();
        }

        public List<VendaINFO> RetornaTableCountDataNow(VendaINFO obj)
        {
            return dal.RetornaTableCountDataNow(obj);
        }
        public List<VendaINFO> Filtrar()
        {
            return dal.Filtrar();
        }

        public List<VendaINFO> RetornaTableCountTotalUser(string Nome)
        {
            return dal.RetornaTableCountTotalUser(Nome);
        }

        public List<VendaINFO> RetornaTablePorData(DateTime dataIni, DateTime dataFin)
        {
            return dal.RetornaTablePorData(dataIni, dataFin);
        }

        public List<VendaINFO> FiltrarPorDatasGrafico(DateTime dataIni, DateTime dataFin)
        {
            return dal.FiltrarPorDatasGrafico(dataIni, dataFin);
        }

        public VendaINFO Salvar(VendaINFO obj)
        {
            return dal.Salvar(obj);
        }
       
    }
}
