using System.Data;
using System.Data.SqlClient;

namespace WP_AdoNet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public int idade;

        public bool Gravar()
        {
            Banco bd = new();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into pessoas values (@nome, @idade);"
            };

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = idade;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool Atualizar()
        {
            Banco bd = new();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update pessoas set nome = @nome, @idade where id = @id"
            };
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = idade;
            command.Parameters[2].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool Excluir()
        {
            Banco bd = new();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new()
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "delete from pessoas where id = @id"
            };

            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
        public DataTable BuscaPessoas()
        {
            Banco bd = new();
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new()
                {
                    Connection = cn,
                    CommandType = CommandType.Text,
                    CommandText = "select * from pessoas"
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
                bd.fecharConexao();
            }
        }

        public DataTable BuscaPessoaById()
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand sqlCommand = new()
                {
                    Connection = cn,
                    CommandType = CommandType.Text,
                    CommandText = "select * from pessoas where id = @id"
                };

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters[0].Value = id;
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
                bd.fecharConexao();
            }
        }

        public Pessoa BuscaPessoaByIdDR()
        {
            Banco bd = new();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new("select * from pessoas", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if(reader.GetInt32(0) == id)
                    {
                        nome = reader.GetString(1);
                        idade = reader.GetInt32(2);
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
                bd.fecharConexao();
            }
        }
    }
}
