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
    }
}
