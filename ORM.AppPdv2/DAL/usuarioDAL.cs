using Helpers.AppPdv2;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace ORM.AppPdv2.DAL
{
    public class UsuarioDAL
    {
        public IDbConnection conexao { get; set; }

        public UsuarioDAL()
        {
            strConexao = ConfigurationManager.ConnectionStrings["conexaoPadrao"].ConnectionString;
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoPadrao"].ConnectionString);
        }
      
            string strConexao;       
        SQLServer Helper = new SQLServer();
        UsuarioINFO obj = new UsuarioINFO();

        const string ParamidUser = "@idUser";
        const string ParamnomeUser = "@nomeUser";
        const string ParamloginUser = "@loginUser";
        const string ParamacessoUser = "@acessoUser";
        const string Paramsenha = "@senha";
        const string Paramimg = "@img";

        const string SQLSelectAll = "select * from usuarios";
        const string SQLInsert = "insert into usuarios(nomeUser, loginUser, acessoUser,senha, img) values(@nomeUser, @loginUser, @acessoUser,@senha, @img)";
        const string SQLUpdade = "update usuarios set senha = @senha, nomeUser = @nomeUser, loginUser = @loginUser, acessoUser = @acessoUser, img = @img where idUser = @idUser";
        const string SQLDelete = "delete from usuarios where idUser = @idUser";
        public List<UsuarioINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<UsuarioINFO> listObj = new List<UsuarioINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public UsuarioINFO Salvar(UsuarioINFO obj)
        {
            if (obj.IdUser == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public UsuarioINFO Inserir(UsuarioINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter(ParamacessoUser, obj.AcessoUser));
            listParam.Add(new SqlParameter(ParamloginUser, obj.LoginUser));
            listParam.Add(new SqlParameter(ParamnomeUser, obj.NomeUser));
            listParam.Add(new SqlParameter(Paramsenha, obj.Senha));
            listParam.Add(new SqlParameter(Paramimg, obj.img));

            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);

            return obj;
        }

        public UsuarioINFO Alterar(UsuarioINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter(ParamacessoUser, obj.AcessoUser));
            listParam.Add(new SqlParameter(ParamloginUser, obj.LoginUser));
            listParam.Add(new SqlParameter(ParamnomeUser, obj.NomeUser));
            listParam.Add(new SqlParameter(ParamidUser, obj.IdUser));
            listParam.Add(new SqlParameter(Paramsenha, obj.Senha));
            listParam.Add(new SqlParameter(Paramimg, obj.img));

            Helper.ExecuteNowQuery(SQLUpdade, strConexao, listParam);
            return obj;
        }

        public UsuarioINFO Delete(UsuarioINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter(ParamidUser, obj.IdUser));
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public UsuarioINFO Mapper(DataRow dr)
        {
            obj = new UsuarioINFO();
            {
                obj.AcessoUser = Convert.ToInt16(dr["acessoUser"]);
                obj.IdUser = Convert.ToInt16(dr["idUser"]);
                obj.LoginUser = dr["loginUser"].ToString();
                obj.NomeUser = dr["nomeUser"].ToString();
                obj.Senha = dr["senha"].ToString();
                obj.img = dr["img"].ToString();
            }
            return obj;
        }
    }
}
