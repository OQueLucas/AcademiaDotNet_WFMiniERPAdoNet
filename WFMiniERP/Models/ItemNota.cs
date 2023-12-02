using System.Data.SqlClient;
using System.Data;
using WFMiniERP.Data;

namespace WFMiniERP.Models
{
    internal class ItemNota
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Nota Nota { get; set; }
        public int NotaID { get; set; }

        public void Cadastrar(SqlConnection cn, SqlTransaction tran)
        {
            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into itens_nota values (@nome, @preco, @quantidade, @fk_nota);"
            };

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@fk_nota", SqlDbType.Int);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = (float)Preco;
            command.Parameters[2].Value = Quantidade;
            command.Parameters[3].Value = Nota.ID;

            command.ExecuteNonQuery();
        }
        // select ID, nome, preco, quantidade, fk_nota from itens_nota
        public DataTable BuscaByNotaId()
        {
            Banco bd = new();
            try
            {
                SqlConnection cn = bd.AbrirConexao();

                SqlCommand sqlCommand = new()
                {
                    Connection = cn,
                    CommandType = CommandType.Text,
                    CommandText = "select ID, nome, preco, quantidade, fk_nota from itens_nota WHERE fk_nota = @id"
                };

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters[0].Value = NotaID;

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
    }
}
