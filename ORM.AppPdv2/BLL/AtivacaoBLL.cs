using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.AppPdv2.DAL;
using ORM.AppPdv2.INFO;
using System.Data.SqlClient;

namespace ORM.AppPdv2.BLL
{
  public class AtivacaoBLL
    {
        AtivacaoDAL dal = new AtivacaoDAL();

        public AtivacaoINFO Salvar(AtivacaoINFO obj)
        {
            return dal.Salvar(obj);
        }
        public AtivacaoINFO Alterar(AtivacaoINFO obj)
        {
            return dal.Alterar(obj);
        }
        public AtivacaoINFO AlterarContador(AtivacaoINFO obj)
        {
            return dal.AlterarContador(obj);
        }
        public List<AtivacaoINFO> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
        public AtivacaoINFO Selecionar(int DataId)
        {
            return dal.Selecionar(DataId);
        }
        public bool Excluir()
        {
            return dal.Excluir();
        }
    }
}
