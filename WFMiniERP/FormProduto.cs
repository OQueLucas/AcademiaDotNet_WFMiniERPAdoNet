using System.Data;
using WFMiniERP.Models;

namespace WFMiniERP
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            Buscar();
            AtualizarFornecedor();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new();

            DataRowView fornecedorRow = comboBox_Fornecedor.SelectedItem as DataRowView;

            if (fornecedorRow == null)
            {
                MessageBox.Show("Selecione o fornecedor");
                return;
            }

            int fornecedorID = (int)fornecedorRow.Row["ID"];

            fornecedor.BuscaByIdDR(fornecedorID);

            if (fornecedor == null)
            {
                MessageBox.Show("Fornecedor não encontrado");
                return;
            }

            Produto produto = new()
            {
                Nome = textBox_Nome.Text,
                Preco = double.Parse(textBox_Preco.Text),
                QuantidadeEstoque = int.Parse(textBox_QuantidadeEstoque.Text),
                Fornecedor = fornecedor
            };

            if (produto.Cadastrar())
            {
                Buscar();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar");
            }
        }

        private void Buscar()
        {
            Produto produto = new();
            DataTable dt = produto.Buscar();
            dataGridView_Clientes.DataSource = dt;
        }

        private void AtualizarFornecedor()
        {
            Fornecedor fornecedor = new();
            comboBox_Fornecedor.DataSource = fornecedor.Buscar();
            comboBox_Fornecedor.DisplayMember = "RazaoSocial";
            comboBox_Fornecedor.ValueMember = "ID";
            comboBox_Fornecedor.SelectedItem = null;
        }
    }
}
