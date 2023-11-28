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

        private void dataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            clienteId = int.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox_CPF.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Nome.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_Email.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
