using System.Data;
using WFMiniERP.Models;
using WFMiniERP.Models.Enums;

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
            AtualizarProdutos();
        }

        private void AtualizarClientes()
        {
            Cliente cliente = new();
            comboBox_Clientes.DataSource = cliente.Buscar();
            comboBox_Clientes.DisplayMember = "Nome";
            comboBox_Clientes.ValueMember = "ID";
            comboBox_Clientes.SelectedItem = null;
        }

        private void AtualizarProdutos()
        {
            Produto produto = new();
            comboBox_Produtos.DataSource = produto.Buscar();
            comboBox_Produtos.DisplayMember = "Nome";
            comboBox_Produtos.ValueMember = "ID";
            comboBox_Produtos.SelectedItem = null;
        }

        private void button_AtualizarClientes_Click(object sender, EventArgs e)
        {
            AtualizarClientes();
            AtualizarProdutos();
        }

        private void button_EmitirNota_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();

            DataRowView clienteRow = comboBox_Clientes.SelectedItem as DataRowView;

            if (clienteRow == null)
            {
                MessageBox.Show("Selecione o cliente");
                return;
            }

            int clienteID = (int)clienteRow.Row["ID"];

            cliente.BuscaClientesByIdDR(clienteID);

            if (cliente == null)
            {
                MessageBox.Show("Cliente n�o encontrado");
                return;
            }

            List<ItemNota> listItensNotas = new();

            Nota nota = new()
            {
                DataCompra = DateTime.Now,
                ItensNota = listItensNotas,
                Cliente = cliente,
                Status = StatusNota.Emitida
            };

            for (int i = 0; i < dataGridView_Produtos.RowCount - 1; i++)
            {
                ItemNota item = new()
                {
                    Nome = dataGridView_Produtos.Rows[i].Cells["Column_Nome"].Value.ToString(),
                    Preco = float.Parse(dataGridView_Produtos.Rows[i].Cells["Column_Preco"].Value.ToString()),
                    Quantidade = int.Parse(dataGridView_Produtos.Rows[i].Cells["Column_Quantidade"].Value.ToString()),
                    Nota = nota
                };

                listItensNotas.Add(item);
            }

            try
            {
                if (nota.Cadastrar(nota.ID))
                {
                    MessageBox.Show("Nota emitida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao emitir nota " + ex.Message, ex.GetType().Name);

            }
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new();
            DataRowView produtoRow = comboBox_Produtos.SelectedItem as DataRowView;

            if (produtoRow == null)
            {
                MessageBox.Show("Selecione o produto");
                return;
            }

            int produtoID = (int)produtoRow.Row["ID"];

            produto.BuscaByIdDR(produtoID);

            if (produto == null)
            {
                MessageBox.Show("Produto n�o encontrado");
                return;
            }

            ItemNota item = new() { Nome = produto.Nome, Preco = produto.Preco };
            item.Quantidade = int.Parse(numericUpDown_Quantidade.Value.ToString());

            dataGridView_Produtos.Rows.Add(new string[] { dataGridView_Produtos.RowCount.ToString(), item.Nome, item.Preco.ToString(), item.Quantidade.ToString() });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNotaFiscal formNotaFiscal = new();
            formNotaFiscal.ShowDialog();
        }
    }
}
