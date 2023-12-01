using System.Data.SqlClient;
using System.Data;
using WFMiniERP.Data;

namespace WFMiniERP.Models
{
    internal class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Fornecedor Fornecedor { get; set; }

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
                CommandText = "insert into produtos values (@nome, @preco, @quantidade_estoque, @fk_fornecedor);"
            };

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@quantidade_estoque", SqlDbType.Int);
            command.Parameters.Add("@fk_fornecedor", SqlDbType.Int);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = (float)Preco;
            command.Parameters[2].Value = QuantidadeEstoque;
            command.Parameters[3].Value = Fornecedor.ID;

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
                    CommandText = "select * from produtos"
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

        public Produto BuscaByIdDR(int id)
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new("select * from produtos", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        ID = id;
                        Nome = reader.GetString(1);
                        Preco = reader.GetDouble(2);
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
