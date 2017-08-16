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
    public class FornecedorDAL
    {
        public FornecedorDAL()
        {
            strConexao = config.GetConnectString("conexaoPadrao");
        }
        Configuration config = new Configuration();
        SQLServer Helper = new SQLServer();
        FornecedorINFO obj = new FornecedorINFO();
        string strConexao;

        const string ParamidForn = "@idForn";
        const string Paramrazao_social = "@razao_social";
        const string Paramnome_fantasia = "@nome_fantasia";
        const string ParamendForn = "@endForn";
        const string ParambairroForn = "@bairroForn";
        const string ParamcepForn = "@cepForn";
        const string ParamufForn = "@ufForn";
        const string ParamcidadeForn = "@cidadeForn";
        const string ParamcnpjForn = "@cnpjForn";
        const string ParamcpfForn = "@cpfForn";
        const string ParaminscMunicipalForn = "@inscMunicipalForn";
        const string ParaminscEstadualForn = "@inscEstadualForn";
        const string ParamsiteEmpForn = "@siteEmpForn";
        const string ParamemailEmpForn = "@emailEmpForn";
        const string ParamtelEmpForn = "@telEmpForn";
        const string ParamfaxEmpForn = "@faxEmpForn";
        const string ParambancoForn = "@bancoForn";
        const string ParamagenciaForn = "@agenciaForn";
        const string ParamcontaCorrForn = "@contaCorrForn";
        const string ParamnomeContForn = "@nomeContForn";
        const string ParamcargoForn = "@cargoForn";
        const string ParamemailForn = "@emailForn";
        const string ParamtelForn = "@telForn";

        const string SQLSelectAll = "select * from Fornecedores";
        const string SQLAlterar = "update fornecedores set razao_social = @razao_social, nome_fantasia = @nome_fantasia," +
            "endForn = @endForn, bairroForn = @bairroForn, cepForn= @cepForn, ufForn = @ufForn, cidadeForn = @cidadeForn," +
            "cpfForn = @cpfForn, inscMunicipalForn = @inscMunicipalForn, inscEstadualForn = @inscEstadualForn, siteEmpForn = @siteEmpForn," +
            "emailEmpForn = @emailEmpForn, telEmpForn = @telEmpForn, faxEmpForn= @faxEmpForn, bancoForn = @bancoForn, agenciaForn = @agenciaForn," +
            "contaCorrForn = @contaCorrForn, nomeContForn = @nomeContForn, cargoForn = @cargoForn, emailForn = @emailForn, telForn = @telForn where idForn = @idForn";
        const string SQLInsert = "insert into fornecedores(razao_social, nome_fantasia, endForn, bairroForn, " +
            "cepForn, ufForn, cidadeForn, cnpjForn, cpfForn, inscMunicipalForn, inscEstadualForn, siteEmpForn, emailEmpForn," +
            "telEmpForn, faxEmpForn, bancoForn, agenciaForn, contaCorrForn, nomeContForn, cargoForn, emailForn, telForn) values" +
            "(@razao_social, @nome_fantasia, @endForn, @bairroForn, @cepForn, @ufForn, @cidadeForn, @cnpjForn, @cpfForn, @inscMunicipalForn, @inscEstadualForn, @siteEmpForn, @emailEmpForn," +
            "@telEmpForn, @faxEmpForn, @bancoForn, @agenciaForn, @contaCorrForn, @nomeContForn, @cargoForn, @emailForn, @telForn)";
        const string SQLDelete = "delete from fornecedores where idForn= @idForn";

        public List<FornecedorINFO> RetornaTable()
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            List<FornecedorINFO> listObj = new List<FornecedorINFO>();
            foreach (DataRow r in Helper.ExecuteDataTable(SQLSelectAll, strConexao, listParam).Rows)
            {
                listObj.Add(Mapper(r));
            }
            return listObj;
        }

        public FornecedorINFO Salvar(FornecedorINFO obj)
        {
            if (obj.IdForn == 0) Inserir(obj); else Alterar(obj);
            return obj;
        }

        public FornecedorINFO Inserir(FornecedorINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            {
                new SqlParameter(ParamagenciaForn, obj.AgenciaForn);
                new SqlParameter(ParambairroForn, obj.BairroForn);
                new SqlParameter(ParambancoForn, obj.BancoForn);
                new SqlParameter(ParamcargoForn, obj.CargoForn);
                new SqlParameter(ParamcepForn, obj.CepForn);
                new SqlParameter(ParamcidadeForn, obj.CidadeForn);
                new SqlParameter(ParamcnpjForn, obj.CnpjForn);
                new SqlParameter(ParamcontaCorrForn, obj.ContaCorrForn);
                new SqlParameter(ParamcpfForn, obj.CpfForn);
                new SqlParameter(ParamemailEmpForn, obj.EmailEmpForn);
                new SqlParameter(ParamemailForn, obj.EmailForn);
                new SqlParameter(ParamfaxEmpForn, obj.FaxEmpForn);
                new SqlParameter(ParaminscEstadualForn, obj.InscEstadualForn);
                new SqlParameter(ParaminscMunicipalForn, obj.InscMunicipalForn);
                new SqlParameter(Paramnome_fantasia, obj.Nome_fantasia);
                new SqlParameter(ParamnomeContForn, obj.NomeContForn);
                new SqlParameter(Paramrazao_social, obj.Razao_social);
                new SqlParameter(ParamsiteEmpForn, obj.SiteEmpForn);
                new SqlParameter(ParamtelEmpForn, obj.TelEmpForn);
                new SqlParameter(ParamtelForn, obj.TelForn);
                new SqlParameter(ParamufForn, obj.UfForn);
                new SqlParameter(ParamendForn, obj.EndForn);
            }       
            Helper.ExecuteNowQuery(SQLInsert, strConexao, listParam);
            return obj;
        }

        public FornecedorINFO Alterar(FornecedorINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter(ParamagenciaForn, obj.AgenciaForn));
            listParam.Add(new SqlParameter(ParambairroForn, obj.BairroForn));
            listParam.Add(new SqlParameter(ParambancoForn, obj.BancoForn));
            listParam.Add(new SqlParameter(ParamcargoForn, obj.CargoForn));
            listParam.Add(new SqlParameter(ParamcepForn, obj.CepForn));
            listParam.Add(new SqlParameter(ParamcidadeForn, obj.CidadeForn));
            listParam.Add(new SqlParameter(ParamcnpjForn, obj.CnpjForn));
            listParam.Add(new SqlParameter(ParamcontaCorrForn, obj.ContaCorrForn));
            listParam.Add(new SqlParameter(ParamcpfForn, obj.CpfForn));
            listParam.Add(new SqlParameter(ParamemailEmpForn, obj.EmailEmpForn));
            listParam.Add(new SqlParameter(ParamemailForn, obj.EmailForn));
            listParam.Add(new SqlParameter(ParamfaxEmpForn, obj.FaxEmpForn));
            listParam.Add(new SqlParameter(ParamidForn, obj.IdForn));
            listParam.Add(new SqlParameter(ParaminscEstadualForn, obj.InscEstadualForn));
            listParam.Add(new SqlParameter(ParaminscMunicipalForn, obj.InscMunicipalForn));
            listParam.Add(new SqlParameter(Paramnome_fantasia, obj.Nome_fantasia));
            listParam.Add(new SqlParameter(ParamnomeContForn, obj.NomeContForn));
            listParam.Add(new SqlParameter(Paramrazao_social, obj.Razao_social));
            listParam.Add(new SqlParameter(ParamsiteEmpForn, obj.SiteEmpForn));
            listParam.Add(new SqlParameter(ParamtelEmpForn, obj.TelEmpForn));
            listParam.Add(new SqlParameter(ParamtelForn, obj.TelForn));
            listParam.Add(new SqlParameter(ParamufForn, obj.UfForn));
            listParam.Add(new SqlParameter(ParamendForn, obj.EndForn));

            Helper.ExecuteNowQuery(SQLAlterar, strConexao, listParam);
            return obj;
        }

        public FornecedorINFO Delete(FornecedorINFO obj)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter(ParamidForn, obj.IdForn));
            Helper.ExecuteNowQuery(SQLDelete, strConexao, listParam);
            return obj;
        }

        public FornecedorINFO Mapper(DataRow Dr)
        {
            obj = new FornecedorINFO()
            {
                AgenciaForn = Dr["agenciaForn"].ToString(),
                BairroForn = Dr["bairroForn"].ToString(),
                BancoForn = Dr["bancoForn"].ToString(),
                CargoForn = Dr["cargoForn"].ToString(),
                CepForn = Dr["cepForn"].ToString(),
                CidadeForn = Dr["cidadeForn"].ToString(),
                CnpjForn = Dr["cnpjForn"].ToString(),
                ContaCorrForn = Dr["contaCorrForn"].ToString(),
                CpfForn = Dr["cpfForn"].ToString(),
                EmailEmpForn = Dr["emailEmpForn"].ToString(),
                EmailForn = Dr["emailForn"].ToString(),
                EndForn = Dr["endForn"].ToString(),
                FaxEmpForn = Dr["faxEmpForn"].ToString(),
                IdForn = Convert.ToInt16(Dr["idForn"]),
                InscEstadualForn = Dr["inscEstadualForn"].ToString(),
                InscMunicipalForn = Dr["inscMunicipalForn"].ToString(),
                Nome_fantasia = Dr["nome_fantasia"].ToString(),
                NomeContForn = Dr["nomeContForn"].ToString(),
                Razao_social = Dr["razao_social"].ToString(),
                SiteEmpForn = Dr["siteEmpForn"].ToString(),
                TelEmpForn = Dr["telEmpForn"].ToString(),
                TelForn = Dr["telForn"].ToString(),
                UfForn = Dr["ufForn"].ToString()
            };
            return obj;
        }
    }
}
