using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ORM.AppPdv2.INFO;
using Dapper;
using System.Configuration;

namespace ORM.AppPdv2.DAL
{
  public class AtivacaoDAL
    {
        public IDbConnection conexao { get; set; }

        public AtivacaoDAL()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString);
        }
        const string sqlInserir = @"insert into Ativacao (DiaDaAtivacao, DiaDaExpiracao, Contador, Ativo, Serial) values (@DiaDaAtivacao, @DiaDaExpiracao, @Contador, @Ativo, @Serial)";
        const string sqlSelecionarTodos = "select * from Ativacao";
        const string sqlSelecionar = "SELECT DiaDaExpiracao from Ativacao where DataId = 1";
        const string sqlExcluir = "delete * from SalvarData";
        const string sqlAtualizar = "update Ativacao set Ativo = @Ativo  where  DataId = @DataId";
        const string sqlAtualizarContador = "update Ativacao set Contador = @Contador  where Ativo = 1";

        public AtivacaoINFO Salvar(AtivacaoINFO Datainfo)
        {
            return conexao.Query<AtivacaoINFO>(sqlInserir, Datainfo).SingleOrDefault();
        }

        public AtivacaoINFO Alterar(AtivacaoINFO Datainfo)
        {
            conexao.Query<AtivacaoINFO>(sqlAtualizar, Datainfo);
            return Datainfo;
        }
        public AtivacaoINFO AlterarContador(AtivacaoINFO Datainfo)
        {
            conexao.Query<AtivacaoINFO>(sqlAtualizarContador, Datainfo);
            return Datainfo;
        }

        public List<AtivacaoINFO> SelecionarTodos()
        {
            return conexao.Query<AtivacaoINFO>(sqlSelecionarTodos, null).ToList();
        }

        public AtivacaoINFO Selecionar(int DataId)
        {
            return conexao.Query<AtivacaoINFO>(sqlSelecionar, new { DataId = DataId }).SingleOrDefault();
        }
        public bool Excluir()
        {
            return conexao.Execute(sqlExcluir) > 0;
        }
    }
}
