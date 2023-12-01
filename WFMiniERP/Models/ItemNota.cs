using System.Data.SqlClient;
using System.Data;

namespace WFMiniERP.Models
{
    internal class ItemNota
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Nota Nota { get; set; }

        public void Cadastrar(SqlConnection cn, SqlTransaction tran)
        {
            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into itens_nota values (@nome, @preco, @quantidade, @fk_produto, @fk_nota);"
            };

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@fk_produto", SqlDbType.Int);
            command.Parameters.Add("@fk_nota", SqlDbType.Int);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = (float)Preco;
            command.Parameters[2].Value = Quantidade;
            command.Parameters[3].Value = Produto.ID;
            command.Parameters[4].Value = Nota.ID;
        }
    }
}
