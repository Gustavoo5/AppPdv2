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
  public  class parametrosDAL
    {
        public IDbConnection conexao { get; set; }

        public parametrosDAL()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoPadrao"].ConnectionString);
        }

        const string sqlInserir = @"insert into Parametros (Razão_social, Endereco, Bairro, CEP, Email, CNPJ, Inscr_Estadual, Telefone, Contador, Dt_Validade, img) values (@Razão_social, @Endereco, @Bairro, @CEP, @Email, @CNPJ, @Inscr_Estadual, @Telefone, @Contador, @Dt_Validade, @img)";
        const string sqlSelecionarTodos = "select * from Parametros";
        const string sqlSelecionar = "SELECT Razão_social from Parametros where Codigo = @Codigo";
        const string sqlExcluir = "delete from Parametros where Codigo = @Codigo";
        const string sqlAtualizar = "update Parametros set Razão_social = @Razão_social, Endereco = @Endereco, Bairro = @Bairro, CEP = @CEP, Email = @Email, CNPJ = @CNPJ, Inscr_Estadual = @Inscr_Estadual, Telefone = @Telefone, Contador = @Contador, Dt_Validade = @Dt_Validade, img = @img  where Codigo = @Codigo";


        public parametrosINFO Salvar(parametrosINFO parametrosinfo)
        {
            if (parametrosinfo.Codigo == 0)
            {
                return conexao.Query<parametrosINFO>(sqlInserir, parametrosinfo).SingleOrDefault();
            }
            else
                conexao.Query<parametrosINFO>(sqlAtualizar, parametrosinfo);
            return parametrosinfo;
        }

        public List<parametrosINFO> SelecionarTodos()
        {
            return conexao.Query<parametrosINFO>(sqlSelecionarTodos, null).ToList();
        }

        public parametrosINFO Selecionar(int Codigo)
        {
            return conexao.Query<parametrosINFO>(sqlSelecionar, new { Codigo = Codigo }).SingleOrDefault();
        }
        public bool Excluir(int ParametrosId)
        {
            return conexao.Execute(sqlExcluir, new { Codigo = ParametrosId }) > 0;
        }
    }
}
