using System.Data;
using WFMiniERP.Models;

namespace WFMiniERP
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            BuscarFornecedor();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new();
            fornecedor.CNPJ = textBox_CNPJ.Text;
            fornecedor.RazaoSocial = textBox_RazaoSocial.Text;

            if(fornecedor.Cadastrar())
            {
                BuscarFornecedor();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
        }

        private void BuscarFornecedor()
        {
            Fornecedor fornecedor = new();
            DataTable dt = fornecedor.Buscar();
            dataGridView_Fornecedores.DataSource = dt;
        }
    }
}
