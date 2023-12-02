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
        public int ClienteID { get; set; }
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
                CommandText = "insert into notas values (@data_compra, @fk_status, @fk_cliente); SELECT SCOPE_IDENTITY();"
            };

            command.Parameters.Add("@data_compra", SqlDbType.DateTime2);
            command.Parameters.Add("@fk_status", SqlDbType.Int);
            command.Parameters.Add("@fk_cliente", SqlDbType.Int);
            command.Parameters[0].Value = DataCompra;
            command.Parameters[1].Value = (int)Status;
            command.Parameters[2].Value = Cliente.ID;

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
                    CommandText = "SELECT notas.ID, data_compra as Data_Emissao, status as Status, nome as Cliente FROM notas INNER JOIN clientes ON clientes.ID = notas.fk_cliente INNER JOIN status_nota ON status_nota.ID = notas.fk_Status"
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
        public Nota BuscaByIdDR(int id)
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new("select notas.ID, data_compra, status_nota.status, fk_cliente from notas INNER JOIN status_nota ON status_nota.ID = fk_status", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        ID = reader.GetInt32(0);
                        DataCompra = reader.GetDateTime(1);
                        Status = (StatusNota)Enum.Parse(typeof(StatusNota), reader.GetString(2));
                        ClienteID = reader.GetInt32(3);
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
