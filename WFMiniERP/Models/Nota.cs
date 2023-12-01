using System.Data.SqlClient;
using System.Data;
using WFMiniERP.Data;
using WFMiniERP.Models.Enums;

namespace WFMiniERP.Models
{
    internal class Nota
    {
        public int ID { get; set; }
        public DateTime DataCompra { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemNota> ItensNota { get; set; }
        public StatusNota Status {  get; set; }

        public bool Cadastrar(int id)
        {
            Banco bd = new();
            SqlConnection cn = bd.AbrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into notas values (@data_compra, @fk_cliente, @status);SELECT SCOPE_IDENTITY();"
            };

            command.Parameters.Add("@data_compra", SqlDbType.Date);
            command.Parameters.Add("@fk_cliente", SqlDbType.Int);
            command.Parameters.Add("@status", SqlDbType.VarChar);
            command.Parameters[0].Value = DataCompra;
            command.Parameters[1].Value = Cliente.ID;
            command.Parameters[2].Value = Status;

            try
            {
                var row = command.ExecuteScalar();

                if (row == null)
                {
                    MessageBox.Show("Não foi possivel encontrar a linha");
                    return false;
                }
                else
                {
                    ID = int.Parse(row.ToString());
                }

                foreach (ItemNota itens in ItensNota)
                {
                    itens.Cadastrar(cn, tran);
                }

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

    }
}
