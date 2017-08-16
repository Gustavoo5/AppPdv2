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
    public class ComponenteProdDAL
    {
        public ComponenteProdDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }

        string strConexao;
        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        ComponenteProdINFO obj = new ComponenteProdINFO();

        const string ParamidCompProd = "@idCompProd";
        const string ParamidProd = "@idProd";
        const string ParamidProdComp = "@idProdComp";
        const string ParamqtdComp = "@qtdComp";

        const string SQLSelectAll = "select componentes_prod.idCompProd, componentes_prod.idProd, componentes_prod.idProdComp, componentes_prod.qtdComp,"+
            " produtos.descProd from componentes_prod inner join produtos on componentes_prod.idProdComp = produtos.idProd";
        const string SQLInsert = "insert into componentes_prod(idProd, idProdComp, qtdComp) values(@idProd, @idProdComp, @qtdComp)";
        const string SQLUpdade = "update componentes_prod set idProd = @idProd, idProdComp = @idProdComp, qtdComp = @qtdComp where idCompProd = @idCompProd";
        const string SQLDelete = "delete from componentes_prod where idCompProd = @idCompProd";

        public List<ComponenteProdINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<ComponenteProdINFO> listObj = new List<ComponenteProdINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public ComponenteProdINFO Salvar(ComponenteProdINFO obj)
        {
            if (obj.IdCompProd == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public ComponenteProdINFO Inserir(ComponenteProdINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidProd, obj.IdProd),
                new SqlParameter(ParamidProdComp, obj.IdProdComp),
                new SqlParameter(ParamqtdComp, obj.QtdComp)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);

            return obj;
        }

        public ComponenteProdINFO Alterar(ComponenteProdINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidCompProd, obj.IdCompProd),
                new SqlParameter(ParamidProd, obj.IdProd),
                new SqlParameter(ParamidProdComp, obj.IdProdComp),
                new SqlParameter(ParamqtdComp, obj.QtdComp)
            };
            Helper.ExecuteNowQuery(SQLUpdade, strConexao, listParam);
            return obj;
        }

        public ComponenteProdINFO Delete(ComponenteProdINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidCompProd, obj.IdCompProd)
            };
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public ComponenteProdINFO Mapper(DataRow dr)
        {
            obj = new ComponenteProdINFO()
            {
                DescProd = dr["descProd"].ToString(),
                IdCompProd = Convert.ToInt16(dr["idCompProd"]),
                IdProd = Convert.ToInt16(dr["idProd"]),
                IdProdComp = Convert.ToInt16(dr["idProdComp"]),
                QtdComp = Convert.ToDouble(dr["qtdComp"])
            };
            return obj;
        }

    }
}
