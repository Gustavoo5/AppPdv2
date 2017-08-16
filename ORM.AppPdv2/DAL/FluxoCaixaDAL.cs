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
    public class FluxoCaixaDAL
    {
        public IDbConnection conexao { get; set; }
        public FluxoCaixaDAL()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString);
        }

        const string sqlInserir = @"insert into FluxoCaixa (dataAbertura, saldoInicial, saldoBruto, saldoLiquido, situacao, userFechamento) values (@dataAbertura, @saldoInicial, @saldoBruto, @saldoLiquido, @situacao, @userFechamento)";
        const string sqlSelecionarTodos = "select * from FluxoCaixa";
        const string sqlAtualizar = "update FluxoCaixa set dataAbertura = @dataAbertura, saldoBruto = @saldoBruto, saldoLiquido = @saldoLiquido, situacao = @situacao, userFechamento = @userFechamento where  idFC = @idFC";
        const string sqlFiltrar = "select* from FluxoCaixa where dataAbertura >= @dataInicial and dataAbertura <=@dataFinal";

        public FluxoCaixaINFO Salvar (FluxoCaixaINFO obj)
        {
            if (obj.idFC == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }
        public FluxoCaixaINFO Inserir(FluxoCaixaINFO obj)
        {
            return conexao.Query<FluxoCaixaINFO>(sqlInserir, obj).SingleOrDefault();
        }

        public FluxoCaixaINFO Alterar(FluxoCaixaINFO obj)
        {
            conexao.Query<FluxoCaixaINFO>(sqlAtualizar, obj);
            return obj;
        }
        public List<FluxoCaixaINFO> SelecionarTodos()
        {
            return conexao.Query<FluxoCaixaINFO>(sqlSelecionarTodos, null).ToList();
        }
        public List<FluxoCaixaINFO> Filtrar(DateTime pdatainicial, DateTime pdatafinal)
        {
            return conexao.Query<FluxoCaixaINFO>(sqlFiltrar, new { @dataInicial = pdatainicial, @dataFinal = pdatafinal }).ToList();
        }
    }
}
