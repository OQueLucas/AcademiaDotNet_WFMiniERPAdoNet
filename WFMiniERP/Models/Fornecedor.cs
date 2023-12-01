using System.Data.SqlClient;
using System.Data;
using WFMiniERP.Data;

namespace WFMiniERP.Models
{
    internal class Fornecedor
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

        public bool Cadastrar()
        {
            Banco bd = new();
            SqlConnection cn = bd.AbrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into fornecedores values (@cnpj, @razao_social);"
            };

            command.Parameters.Add("@cnpj", SqlDbType.VarChar);
            command.Parameters.Add("@razao_social", SqlDbType.VarChar);
            command.Parameters[0].Value = CNPJ;
            command.Parameters[1].Value = RazaoSocial;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public DataTable Buscar()
        {
            Banco bd = new();
            try
            {
                SqlConnection cn = bd.AbrirConexao();

                SqlCommand sqlCommand = new()
                {
                    Connection = cn,
                    CommandType = CommandType.Text,
                    CommandText = "select * from fornecedores"
                };

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new();
                SqlDataAdapter adapter = new(sqlCommand);

                adapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public Fornecedor BuscaByIdDR(int id)
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new("select * from fornecedores", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        ID = id;
                        CNPJ = reader.GetString(1);
                        RazaoSocial = reader.GetString(2);
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
