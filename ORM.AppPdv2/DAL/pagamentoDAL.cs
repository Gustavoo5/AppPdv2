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
    public class pagamentoDAL
    {
        public pagamentoDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }
        string strConexao;
        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        pagamentoINFO obj = new pagamentoINFO();

        const string ParamIdFormPag = "@IdFormPag";
        const string ParamDescPag = "@DescPag";

        const string SQLSelectAll = "select * from pagamentos";
        const string SQLInsert = "insert into pagamentos(DescPag) values(@DescPag)";
        const string SQLUpdade = "update pagamentos set DescPag = @DescPag where IdFormPag = @IdFormPag";
        const string SQLDelete = "delete from pagamentos where IdFormPag = @IdFormPag";

        public List<pagamentoINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<pagamentoINFO> listObj = new List<pagamentoINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public pagamentoINFO Salvar(pagamentoINFO obj)
        {
            if (obj.DescPag.Replace(" ", "") != "")
            {
                if (obj.IdFormPag == 0) Inserir(obj); else Alterar(obj);               
            }
            return obj;
        }

        public pagamentoINFO Inserir(pagamentoINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamDescPag, obj.DescPag)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);

            return obj;
        }

        public pagamentoINFO Alterar(pagamentoINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamDescPag, obj.DescPag),
                new SqlParameter(ParamIdFormPag, obj.IdFormPag)
            };
            Helper.ExecuteNowQuery(SQLUpdade, strConexao, listParam);
            return obj;
        }

        public pagamentoINFO Delete(pagamentoINFO obj)
        {
            if (obj.IdFormPag != 0)
            {
                List<SqlParameter> listParam = new List<SqlParameter>
                {
                new SqlParameter(ParamIdFormPag, obj.IdFormPag)
                };
                Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            }
            return obj;

        }

        public pagamentoINFO Mapper(DataRow dr)
        {
            obj = new pagamentoINFO()
            {
                IdFormPag = Convert.ToInt16(dr["IdFormPag"]),
                DescPag = dr["DescPag"].ToString()
            };
            return obj;
        }
    }
}
