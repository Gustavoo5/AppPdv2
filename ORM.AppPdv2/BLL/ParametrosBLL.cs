using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;

namespace ORM.AppPdv2.BLL
{
  public class ParametrosBLL
    {
        parametrosDAL dal = new parametrosDAL();

        public parametrosINFO Salvar(parametrosINFO obj)
        {
            return dal.Salvar(obj);
        }

        public List<parametrosINFO> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
        public parametrosINFO Selecionar(int Codigo)
        {
            return dal.Selecionar(Codigo);
        }
        public bool Excluir(int ParametrosId)
        {
            return dal.Excluir(ParametrosId);
        }
    }
}
