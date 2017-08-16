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
    public class ClienteDAL
    {
        public ClienteDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }

        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        ClienteINFO obj = new ClienteINFO();
        string strConexao;

        const string ParamidClie = "@idClie";
        const string ParamnomeClie = "@nomeClie";
        const string ParamdataCadastro = "@dataCadastro";
        const string ParamtelNumero = "@telNumero";
        const string ParamcpfClie = "@cpfClie";
        const string ParamendClie = "@endClie";
        const string ParambairroClie = "@bairroClie";
        const string ParamcidadeClie = "@cidadeClie";
        const string ParamobsClie = "@obsClie";

        //param para retorno
        const string Paramdata = "@data";


        const string SQLSelectAll = "select * from clientes";
        const string SQLSelectAllCod = "select * from clientes where idClie = @idClie";
        const string SQLAlterar = "update clientes set nomeClie = @nomeClie," +
            "DataCadastro = @DataCadastro,telNumero = @telNumero," +
            "cpfClie = @cpfClie, endClie = @endClie, bairroClie = @bairroClie," +
            "cidadeClie = @cidadeClie, obsClie = @obsClie where idClie = @idClie";
        const string SQLInsert = "insert into clientes(nomeClie," +
            "telNumero, cpfClie, endClie, bairroClie, cidadeClie, " +
            "obsClie, DataCadastro) values" +
            "(@nomeClie, " +
            "@telNumero, @cpfClie, @endClie, @bairroClie, @cidadeClie" +
            "@obsClie, @DataCadastro)";
         const string SQLInsertRetornaID = "insert into clientes(nomeClie," +
            "telNumero, endClie, bairroClie, cidadeClie, " +
            "DataCadastro) values" +
            "(@nomeClie, " +
            "@telNumero, @endClie, @bairroClie, @cidadeClie," +
            "@DataCadastro) select @@identity as idClie";
        
        const string SQLDelete = "delete from clientes where idClie= @idClie";
        const string SQLTodosClientesAdicionadosNoDia = "select COUNT(*) as qtdClientes, clientes.dataCadastro from clientes group by clientes.dataCadastro";
        const string SQLSELECT_COUNT_INTER_DATAS = "select COUNT(*) as qtdClientes, clientes.dataCadastro from clientes where dataCadastro = @data group by clientes.dataCadastro";

        public List<ClienteINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<ClienteINFO> listObj = new List<ClienteINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public List<ClienteINFO> RetornaTableCod(int cod)
        {
            List<SqlParameter> listParam = new List<SqlParameter>{
                new SqlParameter(ParamidClie, cod)
            };
            List<ClienteINFO> listObj = new List<ClienteINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAllCod, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public ClienteINFO Salvar(ClienteINFO obj)
        {
            if (obj.IdClie == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public ClienteINFO Inserir(ClienteINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParambairroClie, obj.BairroClie),
                new SqlParameter(ParamcidadeClie, obj.CidadeClie),
                new SqlParameter(ParamcpfClie, obj.CpfClie),
                new SqlParameter(ParamendClie, obj.EndClie),
                new SqlParameter(ParamnomeClie, obj.NomeClie),
                new SqlParameter(ParamobsClie, obj.ObsClie),
                new SqlParameter(ParamtelNumero, obj.telNumero),
                new SqlParameter(ParamdataCadastro, obj.DataCadastro)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);
            return obj;

        }

        public ClienteINFO Alterar(ClienteINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParambairroClie, obj.BairroClie),
                new SqlParameter(ParamcidadeClie, obj.CidadeClie),
                new SqlParameter(ParamcpfClie, obj.CpfClie),
                new SqlParameter(ParamendClie, obj.EndClie),
                new SqlParameter(ParamidClie, obj.IdClie),
                new SqlParameter(ParamnomeClie, obj.NomeClie),
                new SqlParameter(ParamobsClie, obj.ObsClie),
                new SqlParameter(ParamtelNumero, obj.telNumero),
                new SqlParameter(ParamdataCadastro, obj.DataCadastro)
            };
            Helper.ExecuteNowQuery(SQLAlterar, strConexao, listParam);
            return obj;
        }

        public ClienteINFO InserirRetornoId(ClienteINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParambairroClie, obj.BairroClie),
                new SqlParameter(ParamcidadeClie, obj.CidadeClie),
                new SqlParameter(ParamendClie, obj.EndClie),
                new SqlParameter(ParamnomeClie, obj.NomeClie),
                new SqlParameter(ParamtelNumero, obj.telNumero),
                new SqlParameter(ParamdataCadastro, obj.DataCadastro)
            };
            obj.IdClie = Convert.ToInt16(Helper.ExecuteDataRow(SQLInsertRetornaID, strConexao, listParam)[0].ToString());
            return obj;

        }


        public List<ClienteINFO> FiltrarPorDatasGrafico(DateTime data)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramdata, data),
            };
            List<ClienteINFO> listObj = new List<ClienteINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSELECT_COUNT_INTER_DATAS, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountDataNow(r));
            }
            return listObj;
        }

        public ClienteINFO MapperCountDataNow(DataRow Dr)
        {
            obj = new ClienteINFO()
            {
                DataCadastro = Convert.ToDateTime(Dr["DataCadastro"]),
                qtdClientes = Convert.ToInt16(Dr["qtdClientes"])
            };
            return obj;
        }

        public ClienteINFO Delete(ClienteINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidClie, obj.IdClie)
            };
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }
        public List<ClienteINFO> SQLTodosClientesAdicionados()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<ClienteINFO> listObj = new List<ClienteINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLTodosClientesAdicionadosNoDia, strConexao, listParam).Rows)
            {
                listObj.Add(MapperCountCliente(r));
            }
            return listObj;
        }

        public ClienteINFO MapperCountCliente(DataRow Dr)
        {
            obj = new ClienteINFO()
            {
                DataCadastro = Convert.ToDateTime(Dr["DataCadastro"]),
                qtdClientes = Convert.ToInt16(Dr["qtdClientes"])
            };
            return obj;
        }

        public ClienteINFO Mapper(DataRow Dr)
        {
            obj = new ClienteINFO()
            {
                BairroClie = Dr["bairroClie"].ToString(),
                CidadeClie = Dr["cidadeClie"].ToString(),
                CpfClie = Dr["cpfClie"].ToString(),
                DataCadastro = Convert.ToDateTime(Dr["DataCadastro"]),
                EndClie = Dr["endClie"].ToString(),
                IdClie = Convert.ToInt16(Dr["idClie"]),
                NomeClie = Dr["nomeClie"].ToString(),
                ObsClie = Dr["obsClie"].ToString(),
                telNumero = Dr["telNumero"].ToString()
            };
            return obj;
        }

    }
}
