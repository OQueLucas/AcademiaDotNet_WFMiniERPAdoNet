using System.Data;
using WFMiniERP.Models;

namespace WFMiniERP
{
    public partial class FormCliente : Form
    {
        int clienteId;

        public FormCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            Cliente cliente = new();
            DataTable dt = cliente.Buscar();
            dataGridView_Clientes.DataSource = dt;
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            Cliente cliente = new();

            if (String.IsNullOrEmpty(textBox_Consultar.Text))
            {
                dt = cliente.Buscar();
            }
            else
            {
                cliente.ID = int.Parse(textBox_Consultar.Text);
                cliente = cliente.BuscaClientesByIdDR(cliente.ID);

                if (cliente == null) 
                {
                    MessageBox.Show("Cliente não encontrado");
                    return;
                }

                dt = cliente.BuscaPessoaById();

                MessageBox.Show(cliente.Nome);
            }

            dataGridView_Clientes.DataSource = dt;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new()
            {
                CPF = textBox_CPF.Text,
                Nome = textBox_Nome.Text,
                Email = textBox_Email.Text
            };

            if (cliente.Cadastrar())
            {
                BuscarClientes();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar");
            }
        }

        private void LimparCampos()
        {
            textBox_CPF.Text = "";
            textBox_Nome.Text = "";
            textBox_Email.Text = "";
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private bool Atualizar(Cliente cliente)
        {
            DialogResult result = MessageBox.Show($"Deseja alterar: {cliente.Nome}", "Alterar registro", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                return false;
            }

            if (cliente.Atualizar())
            {
                MessageBox.Show("Atualizado com sucesso!");
                return true;
            }
            return false;
        }

        private void dataGridView_Clientes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView_Clientes.CurrentRow.Index;

            Cliente clienteAtualizado = new()
            {
                ID = int.Parse(dataGridView_Clientes.Rows[linha].Cells["Column_ID"].Value.ToString()),
                CPF = dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].EditedFormattedValue.ToString(),
                Nome = dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].EditedFormattedValue.ToString(),
                Email = dataGridView_Clientes.Rows[linha].Cells["Column_Email"].EditedFormattedValue.ToString()
            };

            if (clienteAtualizado == null) return;

            Cliente cliente = new();
            cliente.BuscaClientesByIdDR(clienteAtualizado.ID);

            if (cliente.CPF == clienteAtualizado.CPF && cliente.Nome == clienteAtualizado.Nome && cliente.Email == clienteAtualizado.Email) return;

            if (!Atualizar(clienteAtualizado))
            {
                dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].Value = cliente.CPF;
                dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].Value = cliente.Nome;
                dataGridView_Clientes.Rows[linha].Cells["Column_Email"].Value = cliente.Email;
            }
        }
        private bool Excluir(Cliente cliente)
        {
            DialogResult result = MessageBox.Show($"Deseja excluir: {cliente.Nome}", "Excluir registro", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                return false;
            }

            if (cliente.Excluir())
            {
                MessageBox.Show("Excluído com sucesso!");
                return true;
            }
            return false;
        }

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool excluirClick = e.ColumnIndex == dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_Excluir"].ColumnIndex;

            if (!excluirClick) return;

            Cliente cliente = new();
            cliente.ID = int.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells["Column_ID"].Value.ToString());

            Excluir(cliente);
            dataGridView_Clientes.Rows.RemoveAt(e.RowIndex);
        }
    }
}
