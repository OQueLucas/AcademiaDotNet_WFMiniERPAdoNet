using System.Data;
using System.Net.Http.Json;
using System.Windows.Forms;
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

            button_Consultar.Click += delegate { BuscarClientes(); };
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.CPF = textBox_CPF.Text;
            cliente.Nome = textBox_Nome.Text;
            cliente.Email = textBox_Email.Text;

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

        private void BuscarClientes()
        {
            Cliente cliente = new();
            DataTable dt = cliente.Buscar();
            dataGridView_Clientes.DataSource = dt;
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

        private bool Atualizar(Cliente clienteAtualizado)
        {
            DialogResult result = MessageBox.Show($"Deseja alterar: {clienteAtualizado.Nome}", "Alterar registro", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                return false;
            }

            if (clienteAtualizado.Atualizar())
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
            cliente.BuscaClientesById(clienteAtualizado.ID);

            if (cliente.CPF == clienteAtualizado.CPF && cliente.Nome == clienteAtualizado.Nome && cliente.Email == clienteAtualizado.Email)
                return;

            if(!Atualizar(clienteAtualizado))
            {
                dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].Value = cliente.CPF;
                dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].Value = cliente.Nome;
                dataGridView_Clientes.Rows[linha].Cells["Column_Email"].Value = cliente.Email;
            }
        }
    }
}
