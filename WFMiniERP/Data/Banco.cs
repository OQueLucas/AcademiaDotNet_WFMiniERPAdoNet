using System.Data.SqlClient;

namespace WFMiniERP.Data
{
    internal class Banco
    {
        public string conec = "Data Source=localhost;Initial Catalog=miniERP;User ID=adonet;password=senha1234;language=Portuguese;";
        private SqlConnection cn;

        private void Conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void FecharConexao()
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
    }
}
