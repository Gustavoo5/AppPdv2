using Helpers.AppPdv2;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.AppPdv2.DAL
{
    public class VendaDAL
    {
        public VendaDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }

        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        VendaINFO obj = new VendaINFO();
        string strConexao;

        const string ParamidVenda = "@idVenda";
        const string ParamidClie = "@idClie";
        const string ParamvalorTotal = "@valorTotal";
        const string ParamdataVenda = "@dataVenda";
        const string ParamidUserVenda = "@idUserVenda";
        const string ParamidFormPag = "@idFormPag";
        const string Paramativa = "@ativa";
        const string Paramstatus = "@status";
        const string ParamidFC = "@idFC";

        const string ParamNomeUser = "@nomeUser";

        //parametro de retorno
        const string Paramdataini = "@dataIni";
        const string Paramdatafin = "@dataFin";

        const string SQLSelectAll = "SELECT vendas.idVenda ,vendas.idClie, vendas.idClie, vendas.valorTotal, vendas.dataVenda, vendas.idFormPag, pagamentos.descPag," +
            " vendas.idUserVenda, vendas.ativa, clientes.nomeClie, usuarios.nomeUser, vendas.status FROM vendas INNER JOIN clientes on vendas.idClie = clientes.idClie" +
            " INNER join usuarios on vendas.idUserVenda =  usuarios.idUser INNER JOIN pagamentos on vendas.idFormPag = pagamentos.idFormPag";
        const string SQLAlterar = "update vendas set idClie = @idClie, valorTotal = @valorTotal," +
            " dataVenda = @dataVenda, idUserVenda= @idUserVenda, ativa = @ativa, idFormPag = @idFormPag, status = @status" +
            " where idVenda = @idVenda";
        const string SQLInsert = "insert into vendas(idClie, valorTotal, dataVenda, " +
            "idUserVenda, ativa, idFormPag, status, idFC) values (@idClie, @valorTotal, @dataVenda, @idUserVenda, @ativa, @idFormPag, @status, @idFC); select @@identity as idVenda;";
        const string SQLSelectPorData = "SELECT vendas.idVenda ,vendas.idClie, vendas.idClie, vendas.valorTotal, vendas.dataVenda, vendas.idFormPag, pagamentos.descPag, " +
            "vendas.idUserVenda, vendas.ativa, clientes.nomeClie, usuarios.nomeUser, vendas.status FROM vendas INNER JOIN clientes on vendas.idClie = clientes.idClie INNER join usuarios " +
            "on vendas.idUserVenda =  usuarios.idUser INNER JOIN pagamentos on vendas.idFormPag = pagamentos.idFormPag where dataVenda between @dataIni and @dataFin";
        const string SQLSelectCountData = "select COUNT(*) as qtd, vendas.dataVenda from vendas where vendas.idUserVenda = @idUserVenda group by vendas.dataVenda";
        const string SQLSelectCounTotalUser = "select SUM(vendas.valorTotal) as total, usuarios.nomeUser from vendas inner join usuarios on vendas.idUserVenda = usuarios.idUser where usuarios.nomeUser like '%'+@nomeUser+'%' group by usuarios.nomeUser";
        const string SQLSelecionar = "select SUM(vendas.valorTotal) as total, usuarios.nomeUser from vendas inner join usuarios on vendas.idUserVenda = usuarios.idUser group by usuarios.nomeUser";
        const string SQLFiltrar = "select COUNT(*) as qtd, vendas.dataVenda from vendas group by vendas.dataVenda";
        const string SQLSELECT_COUNT_INTER_DATAS = "select COUNT(*) as qtd, vendas.dataVenda from vendas where dataVenda between @dataIni and @dataFin group by vendas.dataVenda";

        public List<VendaINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public List<VendaINFO> RetornaTableCountTotalUserSelecionar()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelecionar, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountTotalUser(r));
            }
            return listObj;
        }
        public List<VendaINFO> RetornaTablePorData(DateTime dataIni, DateTime dataFin)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramdataini, dataIni),
                new SqlParameter(Paramdatafin, dataFin)
            };
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectPorData, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public List<VendaINFO> RetornaTableCountDataNow(VendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidUserVenda, obj.IdUserVenda)
            };
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectCountData, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountDataNow(r));
            }
            return listObj;
        }
        public List<VendaINFO> Filtrar()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLFiltrar, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountDataNow(r));
            }
            return listObj;
        }

        public List<VendaINFO> FiltrarPorDatasGrafico(DateTime dataIni, DateTime dataFin)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramdataini, dataIni),
                new SqlParameter(Paramdatafin, dataFin)
            };
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSELECT_COUNT_INTER_DATAS, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountDataNow(r));
            }
            return listObj;
        }

        public List<VendaINFO> RetornaTableCountTotalUser(string Nome)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamNomeUser, Nome)
            };
            List<VendaINFO> listObj = new List<VendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectCounTotalUser, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountTotalUser(r));
            }
            return listObj;
        }

        public VendaINFO Salvar(VendaINFO obj)
        {
            if (obj.IdVenda == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }
       
        public VendaINFO Inserir(VendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdataVenda, obj.DataVenda),
                new SqlParameter(ParamidClie, obj.IdClie),
                new SqlParameter(ParamidUserVenda, obj.IdUserVenda),
                new SqlParameter(ParamvalorTotal, obj.ValorTotal),
                new SqlParameter(ParamidFormPag, obj.IdFormPag),
                new SqlParameter(Paramativa, obj.ativa),
                new SqlParameter(Paramstatus, obj.status),
                new SqlParameter(ParamidFC, obj.idFC)
            };
            obj.IdVenda = Convert.ToInt16(Helper.ExecuteDataRow(SQLInsert, strConexao, listParam)[0].ToString());
            return obj;

        }
        public VendaINFO Alterar(VendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdataVenda, obj.DataVenda),
                new SqlParameter(ParamidClie, obj.IdClie),
                new SqlParameter(ParamidUserVenda, obj.IdUserVenda),
                new SqlParameter(ParamidVenda, obj.IdVenda),
                new SqlParameter(ParamvalorTotal, obj.ValorTotal),
                new SqlParameter(ParamidFormPag, obj.IdFormPag),
                new SqlParameter(Paramativa, obj.ativa),
                new SqlParameter(Paramstatus, obj.status)
            };
            Helper.ExecuteNowQuery(SQLAlterar, strConexao, listParam);
            return obj;
        }

        public VendaINFO Mapper(DataRow Dr)
        {
            obj = new VendaINFO()
            {
                DataVenda = Convert.ToDateTime(Dr["dataVenda"]),
                IdClie = Convert.ToInt16(Dr["idClie"]),
                IdUserVenda = Convert.ToInt16(Dr["idUserVenda"]),
                IdVenda = Convert.ToInt16(Dr["idVenda"]),
                ValorTotal = Convert.ToDecimal(Dr["valorTotal"]),
                NomeClie = Dr["nomeClie"].ToString(),
                NomeUser = Dr["nomeUser"].ToString(),
                DescPag = Dr["descPag"].ToString(),
                ativa = Convert.ToBoolean(Dr["ativa"]),
                status = Dr["status"].ToString(),
                IdFormPag = Convert.ToInt16(Dr["IdFormPag"])
            };
            return obj;
        }

        public VendaINFO MapperCountDataNow(DataRow Dr)
        {
            obj = new VendaINFO()
            {
                DataVenda = Convert.ToDateTime(Dr["dataVenda"]),
                qtd = Convert.ToInt16(Dr["qtd"])
            };
            return obj;
        }

        public VendaINFO MapperCountTotalUser(DataRow Dr)
        {
            obj = new VendaINFO()
            {
                NomeUser = Dr["NomeUser"].ToString(),
                total = Convert.ToDecimal(Dr["total"])
            };
            return obj;
        }

    }
}
