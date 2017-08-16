using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.AppPdv2
{
    public class SQLServer
    {
        public SQLServer()
        {

        }

        public void SetaParametros(SqlCommand cmd, List<SqlParameter> listParam)
        {
            foreach (SqlParameter param in listParam)
            {
                cmd.Parameters.Add(param);
            }
        }

        public DataTable ExecuteDataTable(string cmdText, string BDconn, List<SqlParameter> listParam)
        {
            using (SqlConnection conn = new SqlConnection(BDconn))
            {
                using (DataTable dt = new DataTable())
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.CommandType = CommandType.Text;
                        SetaParametros(cmd, listParam);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    return dt;
                }
            }
        }

        public void ExecuteNowQuery(string cmdText, string BDconn, List<SqlParameter> listParam)
        {
            using (SqlConnection conn = new SqlConnection(BDconn))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.Text;
                    SetaParametros(cmd, listParam);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public DataRow ExecuteDataRow (string cmdText, string BDconexao, List<SqlParameter> listParam)
        {
            DataRow dr;
            using (SqlConnection conn = new SqlConnection(BDconexao))
            {               
                using (DataTable dt = new DataTable())
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.CommandType = CommandType.Text;
                        SetaParametros(cmd, listParam);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    if (dt.Rows.Count > 0)
                        dr = dt.Rows[0];
                    else
                        dr = null;
                    return dr;
                }
            }
        }

    }
}
