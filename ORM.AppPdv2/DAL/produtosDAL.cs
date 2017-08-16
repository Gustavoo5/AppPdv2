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
    public class ProdutosDAL
    {
        public ProdutosDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }

        string strConexao;
        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        ProdutosINFO obj = new ProdutosINFO();

        const string ParamidProd = "@idProd";
        const string ParamidForn = "@idForn";
        const string ParamidCateg = "@idCateg";
        const string ParamdescProd = "@descProd";
        const string ParamqtdProd = "@qtdProd";
        const string ParamvalorProd = "@valorProd";

        const string SQLSelectAll = "select produtos.idProd, produtos.idCateg, produtos.descProd, produtos.qtdProd, produtos.valorProd , " +
            "categorias.descCateg from produtos inner join categorias on produtos.idCateg = categorias.idCateg";
        const string SQLInsert = "insert into Produtos(idCateg, descProd, qtdProd, valorProd) values (@idCateg, @descProd, @qtdProd, @valorProd)";
        const string SQLUpdate = "update Produtos set idCateg = @idCateg, descProd = @descProd, qtdProd = @qtdProd, valorProd = @valorProd where idProd = @idProd";
        const string SQLDelete = "delete from Produtos where idProd = @idProd";

        public List<ProdutosINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<ProdutosINFO> listObj = new List<ProdutosINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public ProdutosINFO Salvar(ProdutosINFO obj)
        {
            if (obj.IdProd == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public ProdutosINFO Inserir(ProdutosINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdescProd, obj.DescProd),
                new SqlParameter(ParamidCateg, obj.IdCateg),
                //listParam.Add(new SqlParameter(ParamidForn, obj.idForn));
                new SqlParameter(ParamqtdProd, obj.QtdProd),
                new SqlParameter(ParamvalorProd, obj.ValorProd)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);

            return obj;
        }

        public ProdutosINFO Alterar(ProdutosINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamdescProd, obj.DescProd),
                new SqlParameter(ParamidCateg, obj.IdCateg),
                //listParam.Add(new SqlParameter(ParamidForn, obj.idForn));
                new SqlParameter(ParamidProd, obj.IdProd),
                new SqlParameter(ParamqtdProd, obj.QtdProd),
                new SqlParameter(ParamvalorProd, obj.ValorProd)
            };
            Helper.ExecuteNowQuery(SQLUpdate, strConexao, listParam);
            return obj;
        }

        public ProdutosINFO Delete(ProdutosINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidProd, obj.IdProd)
            };
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public ProdutosINFO Mapper(DataRow dr)
        {
            obj = new ProdutosINFO();
            obj.DescCateg = dr["descCateg"].ToString();
            obj.DescProd = dr["descProd"].ToString();
            obj.IdCateg = Convert.ToInt16(dr["idCateg"]);
            //obj.idForn = Convert.ToInt16(dr["idForn"]);
            obj.IdProd = Convert.ToInt16(dr["idProd"]);
            obj.QtdProd = Convert.ToDouble(dr["qtdProd"]);
            //obj.razao_social = dr["razao_social"].ToString();
            obj.ValorProd = Convert.ToDecimal(dr["valorProd"]);
            return obj;
        }

    }
}
