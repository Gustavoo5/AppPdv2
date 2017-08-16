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
    public class ComponenteVendaDAL
    {
        public ComponenteVendaDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }

        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        ComponenteVendaINFO obj = new ComponenteVendaINFO();
        string strConexao;

        const string ParamidCompVenda = "@idCompVenda";
        const string ParamidVenda = "@idVenda";
        const string ParamidProd = "@idProd";
        const string ParamdescVenda = "@descVenda";
        const string ParamqtdProd = "@QtdProd";
        const string ParamvalorItem = "@ValorItem";
        const string Paramidclie = "@idClie";
        const string Paramidcateg = "@idCateg";

        const string ParamidUserVenda = "@idUserVenda";

        const string SQLSelectAll = "select componentes_Venda.idCompVenda, componentes_Venda.idProd,componentes_Venda.ValorItem ,componentes_Venda.idVenda, componentes_Venda.descVenda, componentes_Venda.QtdProd, produtos.descProd, produtos.valorProd from componentes_Venda inner join produtos on componentes_Venda.idProd = produtos.idProd";
        const string SQLAlterar = "update componentes_Venda set idVenda = @idVenda, idProd = @idProd where idCompVenda = @idCompVenda";
        const string SQLInsert = "insert into componentes_Venda (descVenda,idVenda, idProd, QtdProd,ValorItem) values (@descVenda,@idVenda, @idProd, @QtdProd, @ValorItem)";
        const string SQLDelete = "delete from componentes_Venda where idCompVenda= @idCompVenda";
        const string SQLSelectGraficoConsumo = "select COUNT(*) as qtd, produtos.descProd from componentes_Venda INNER JOIN produtos on componentes_Venda.idProd = produtos.idProd INNER JOIN vendas ON vendas.idVenda = componentes_Venda.idVenda where vendas.idClie = @idClie group by produtos.descProd";
        const string SQLSelectGraficoModel = "select COUNT(*) qtd, produtos.descProd from componentes_Venda INNER JOIN produtos on componentes_Venda.idProd = produtos.idProd INNER JOIN vendas ON vendas.idVenda = componentes_Venda.idVenda where vendas.idClie = @idClie and produtos.idCateg = @idCateg group by descProd";
        const string SQLSelectTotalItensPorUser = "select COUNT(*) as qtd, produtos.descProd from componentes_Venda inner join vendas on componentes_Venda.idVenda = vendas.idVenda inner join produtos on produtos.idProd = produtos.idProd where vendas.idUserVenda = @idUserVenda and vendas.status = 'Concluida' group by produtos.descProd";
        const string SQLSELECT_CLIENTE = "SELECT componentes_Venda.descVenda, componentes_Venda.idVenda FROM componentes_Venda INNER JOIN vendas ON componentes_Venda.idVenda = vendas.idVenda WHERE vendas.idClie = @idClie";


        public List<ComponenteVendaINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<ComponenteVendaINFO> listObj = new List<ComponenteVendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public List<ComponenteVendaINFO> RetornaTableGraficoCons(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramidclie, obj.IdClie)
            };
            List<ComponenteVendaINFO> listObj = new List<ComponenteVendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectGraficoConsumo, strConexao, listParam).Rows)
            {
                listObj.Add(MapperGraficoConsumo(r));
            }
            return listObj;
        }

        public List<ComponenteVendaINFO> RetornaTableGraficoModel(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramidclie, obj.IdClie),
                new SqlParameter(Paramidcateg, obj.IdCateg)
            };
            List<ComponenteVendaINFO> listObj = new List<ComponenteVendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectGraficoModel, strConexao, listParam).Rows)
            {
                listObj.Add(MapperGraficoConsumo(r));
            }
            return listObj;
        }

        public List<ComponenteVendaINFO> RetornaTableItensUser(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidUserVenda, obj.IdUserVenda)
            };
            List<ComponenteVendaINFO> listObj = new List<ComponenteVendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectTotalItensPorUser, strConexao, listParam).Rows)
            {
                listObj.Add(MapperGraficoConsumo(r));
            }
            return listObj;
        }

        public List<ComponenteVendaINFO> RetornaTableItensClie(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(Paramidclie, obj.IdClie)
            };
            List<ComponenteVendaINFO> listObj = new List<ComponenteVendaINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSELECT_CLIENTE, strConexao, listParam).Rows)
            {
                listObj.Add(MapperItensClie(r));
            }
            return listObj;
        }


        public ComponenteVendaINFO Salvar(ComponenteVendaINFO obj)
        {
            if (obj.IdCompVenda == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public ComponenteVendaINFO Inserir(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidProd, obj.IdProd),
                new SqlParameter(ParamidVenda, obj.IdVenda),
                new SqlParameter(ParamdescVenda, obj.DescVenda),
                new SqlParameter(ParamqtdProd, obj.QtdProd),
                new SqlParameter(ParamvalorItem, obj.ValorItem)
            };
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);
            return obj;

        }

        public ComponenteVendaINFO Alterar(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidCompVenda, obj.IdCompVenda),
                new SqlParameter(ParamidProd, obj.IdProd),
                new SqlParameter(ParamidVenda, obj.IdVenda),
                new SqlParameter(ParamvalorItem, obj.ValorItem)
            };
            Helper.ExecuteNowQuery(SQLAlterar, strConexao, listParam);
            return obj;
        }

        public ComponenteVendaINFO Delete(ComponenteVendaINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>
            {
                new SqlParameter(ParamidCompVenda, obj.IdCompVenda)
            };
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public ComponenteVendaINFO Mapper(DataRow Dr)
        {
            obj = new ComponenteVendaINFO()
            {
                DescProd = Dr["descProd"].ToString(),
                DescVenda = Dr["descVenda"].ToString(),
                IdCompVenda = Convert.ToInt16(Dr["idCompVenda"]),
                IdProd = Convert.ToInt16(Dr["idProd"]),
                IdVenda = Convert.ToInt16(Dr["idVenda"]),
                ValorProd = Convert.ToDecimal(Dr["valorProd"]),
                QtdProd = Convert.ToInt16(Dr["QtdProd"])
            };
            return obj;
        }

        public ComponenteVendaINFO MapperGraficoConsumo(DataRow Dr)
        {
            obj = new ComponenteVendaINFO()
            {
                DescProd = Dr["descProd"].ToString(),
                qtd = Convert.ToInt16(Dr["qtd"])
            };
            return obj;
        }

        public ComponenteVendaINFO MapperItensClie(DataRow Dr)
        {
            obj = new ComponenteVendaINFO()
            {
                DescVenda = Dr["DescVenda"].ToString(),
                qtd = Convert.ToInt16(Dr["qtd"])
            };
            return obj;
        }

    }
}
