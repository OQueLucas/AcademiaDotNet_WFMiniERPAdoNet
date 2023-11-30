using WFMiniERP.Models;

namespace WFMiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new();
            formCliente.ShowDialog();
        }

        private void button_Fornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new();
            formFornecedor.ShowDialog();
        }

        private void button_Produtos_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new();
            formProduto.ShowDialog();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarClientes();
        }

        private void AtualizarClientes()
        {
            Cliente cliente = new();
            comboBox_Clientes.DataSource = cliente.Buscar();
            comboBox_Clientes.DisplayMember = "Nome";
            comboBox_Clientes.ValueMember = "ID";
            comboBox_Clientes.SelectedItem = null;
        }

        private void button_AtualizarClientes_Click(object sender, EventArgs e)
        {
            AtualizarClientes();
        }
    }
}
