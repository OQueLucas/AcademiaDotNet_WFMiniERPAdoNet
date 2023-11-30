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

        private void Atualizar(int linha)
        {
            Cliente cliente = new();
            cliente.ID = int.Parse(dataGridView_Clientes.Rows[linha].Cells["Column_ID"].Value.ToString());
            cliente.CPF = dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].EditedFormattedValue.ToString();
            cliente.Nome = dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].EditedFormattedValue.ToString();
            cliente.Email = dataGridView_Clientes.Rows[linha].Cells["Column_Email"].EditedFormattedValue.ToString();

            if (cliente == null) return;

            Cliente verifica = new();
            verifica.BuscaClientesById(cliente.ID);

            if (verifica.CPF == cliente.CPF && verifica.Nome == cliente.Nome && verifica.Email == cliente.Email)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja alterar: {cliente.Nome}", "Alterar registro", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                dataGridView_Clientes.Rows[linha].Cells["Column_CPF"].Value = verifica.CPF;
                dataGridView_Clientes.Rows[linha].Cells["Column_Nome"].Value = verifica.Nome;
                dataGridView_Clientes.Rows[linha].Cells["Column_Email"].Value = verifica.Email;
                return;
            }

            if (cliente.Atualizar())
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
        }


        private void dataGridView_Clientes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView_Clientes.CurrentRow.Index;
            //Cliente cliente = dataGridView_Clientes.CurrentRow as Cliente;

            //if (!dataGridView_Clientes.CurrentRow.Cells.) return;

            //Cliente verifica = new();
            //verifica.BuscaClientesById(cliente.ID);

            //if (verifica.CPF == cliente.CPF && verifica.Nome == cliente.Nome && verifica.Email == cliente.Email)
            //{
            //    return;
            //}

            Atualizar(linha);
        }
    }
}
