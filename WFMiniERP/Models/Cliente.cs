using System.Data.SqlClient;
using System.Data;
using WFMiniERP.Data;

namespace WFMiniERP.Models
{
    internal class Cliente
    {
        public Cliente()
        {
        }
        public Cliente(string cpf, string nome, string email)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
        }
        public Cliente(int id, string cpf, string nome, string email)
        {
            ID = id;
            CPF = cpf;
            Nome = nome;
            Email = email;
        }
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            Cliente PessoaObj = obj as Cliente;

            if (obj == null) return false;

            return CPF.ToUpper().Equals(PessoaObj.CPF.ToUpper());
        }

        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }

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
                CommandText = "insert into clientes values (@cpf, @nome, @email);"
            };

            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = CPF;
            command.Parameters[1].Value = Nome;
            command.Parameters[2].Value = Email;

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
                    CommandText = "select * from clientes"
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

        public bool Atualizar()
        {
            Banco bd = new();
            SqlConnection cn = bd.AbrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update clientes set cpf = @cpf, nome = @nome, email = @email where id = @id"
            };

            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = CPF;
            command.Parameters[1].Value = Nome;
            command.Parameters[2].Value = Email;
            command.Parameters[3].Value = ID;

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

        public Cliente BuscaClientesById(int id)
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new("select * from clientes", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        CPF = reader.GetString(1);
                        Nome = reader.GetString(2);
                        Email = reader.GetString(3);
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
