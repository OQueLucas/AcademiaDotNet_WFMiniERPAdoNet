using System.Data;
using System.Data.SqlClient;

namespace WP_AdoNet
{
    internal class Banco
    {
        public string conec = "Data Source=localhost;Initial Catalog=ado_net;User ID=adonet;password=senha1234;language=Portuguese;";
        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand sqlCommand = new(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new(sqlCommand);
                DataTable dt = new();

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
