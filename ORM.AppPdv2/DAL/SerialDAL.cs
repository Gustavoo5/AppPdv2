using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ORM.AppPdv2.INFO;

namespace ORM.AppPdv2.DAL
{
  public class SerialDAL
    {
        public IDbConnection conexao { get; set; }

        public SerialDAL()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoPadrao"].ConnectionString);
        }

        const string sqlInserir = @"insert into Seriais (Serial, Ativo) values (@Serial, @Ativo)";
        const string sqlSelecionarTodos = "select * from Seriais";
        const string sqlSelecionar = "SELECT Serial from Seriais where SerialId = @SerialId";
        const string sqlExcluir = "delete from Seriais where SerialId = @SerialId";
        const string sqlAtualizar = "update Seriais set Serial = @Serial, Ativo = @Ativo  where SerialId = @SerialId";
        const string sqlSelecionarTodosAtivos = "select * from Seriais where Ativo = 1";


        public SerialINFO Salvar(SerialINFO serialinfo)
        {
            if (serialinfo.SerialId == 0)
            {
                return conexao.Query<SerialINFO>(sqlInserir, serialinfo).SingleOrDefault();
            }
            else
                conexao.Query<SerialINFO>(sqlAtualizar, serialinfo);
            return serialinfo;
        }

        public List<SerialINFO> SelecionarTodos()
        {
            return conexao.Query<SerialINFO>(sqlSelecionarTodos, null).ToList();
        }

        public List<SerialINFO> SelecionarTodosAtivos()
        {
            return conexao.Query<SerialINFO>(sqlSelecionarTodosAtivos,null).ToList();
        }

        public SerialINFO Selecionar(int SerialId)
        {
            return conexao.Query<SerialINFO>(sqlSelecionar, new { SerialId = SerialId }).SingleOrDefault();
        }
        public bool Excluir(int SerialId)
        {
            return conexao.Execute(sqlExcluir, new { SerialI = SerialId}) > 0;
        }
    }
}
