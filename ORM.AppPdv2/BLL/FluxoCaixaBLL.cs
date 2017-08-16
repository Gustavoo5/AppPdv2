using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.BLL
{
    public class FluxoCaixaBLL
    {
        public FluxoCaixaBLL()
        {

        }
        FluxoCaixaDAL dal = new FluxoCaixaDAL();

        public FluxoCaixaINFO Salvar(FluxoCaixaINFO obj)
        {
            return dal.Salvar(obj);
        }
        public FluxoCaixaINFO Alterar(FluxoCaixaINFO obj)
        {
            return dal.Alterar(obj);
        }

        public List<FluxoCaixaINFO> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
        public List<FluxoCaixaINFO> Filtrar(DateTime dataini, DateTime datafim)
        {
            return dal.Filtrar(dataini, datafim);
        }
    }
}
