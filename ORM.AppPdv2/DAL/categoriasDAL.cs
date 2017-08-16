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
    public class CategoriasDAL
    {
        public CategoriasDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }
        string strConexao;
        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        CategoriasINFO obj = new CategoriasINFO();

        const string ParamidCateg = "@idCateg";
        const string ParamdescCateg = "@descCateg";
        const string ParamdataCateg = "@dataCateg";

        const string SQLSelectAll = "select * from categorias";
        const string SQLInsert = "insert into categorias(descCateg, dataCateg) values(@descCateg, @dataCateg)";
        const string SQLUpdade = "update categorias set descCateg = @descCateg, dataCateg = @dataCateg where idCateg = @idCateg";
        const string SQLDelete = "delete from categorias where idCateg = @idCateg";

        public List<CategoriasINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<CategoriasINFO> listObj = new List<CategoriasINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public CategoriasINFO Salvar(CategoriasINFO obj)
        {
            if (obj.IdCateg == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public CategoriasINFO Inserir(CategoriasINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdataCateg, obj.DataCateg),
                new SqlParameter(ParamdescCateg, obj.DescCateg)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);

            return obj;
        }

        public CategoriasINFO Alterar(CategoriasINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdataCateg, obj.DataCateg),
                new SqlParameter(ParamdescCateg, obj.DescCateg),
                new SqlParameter(ParamidCateg, obj.IdCateg)
            };
            Helper.ExecuteNowQuery(SQLUpdade, strConexao, listParam);
            return obj;
        }

        public CategoriasINFO Delete(CategoriasINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidCateg, obj.IdCateg)
            };
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public CategoriasINFO Mapper(DataRow dr)
        {
            obj = new CategoriasINFO()
            {
                DataCateg = Convert.ToDateTime(dr["dataCateg"]),
                DescCateg = dr["descCateg"].ToString(),
                IdCateg = Convert.ToInt16(dr["idCateg"])
            };
            return obj;
        }

    }
}
