using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetAspxCRUD
{
    /*CREATE LOGIN meuLogin WITH PASSWORD='senha';
        CREATE USER meuLogin FROM LOGIN meuLogin;
        EXEC SP_ADDROLEMEMBER 'DB_DATAREADER', 'meuLogin';
        EXEC SP_ADDROLEMEMBER 'DB_DATAWRITER', 'meuLogin'*/

    public class Banco
    {
        private string conec = "Data Source=localhost;initial Catalog=teste;User ID=teste;password=teste;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirconexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void fecharconexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DataTable executeQuery(string sql)
        {
            conexao();
            abrirconexao();
            try
            {
                SqlCommand sqlComm = new SqlCommand(sql, cn);
                sqlComm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlComm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                fecharconexao();
            }
        }
    }
}