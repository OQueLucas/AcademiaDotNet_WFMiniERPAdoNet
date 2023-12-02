using System.Data;
using WFMiniERP.Models;
using WFMiniERP.Models.Enums;

namespace WFMiniERP
{
    public partial class FormNotaFiscal : Form
    {
        public FormNotaFiscal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            BuscarClientes();
        }



        private void BuscarClientes()
        {
            Nota nota = new();
            DataTable dt = nota.Buscar();
            dataGridView_Notas.DataSource = dt;
            dataGridView_Notas.AutoSize = true;
            dataGridView_Notas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView_Notas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Notas.CurrentRow == null)
            {
                return;
            }

            Nota nota = new();
            Cliente cliente = new();
            ItemNota itemNota = new();

            var linha = e.RowIndex;

            int id = int.Parse(dataGridView_Notas.Rows[linha].Cells["Column_ID"].Value.ToString());

            nota.BuscaByIdDR(id);

            cliente.BuscaClientesByIdDR(nota.ClienteID);

            itemNota.NotaID = nota.ID;

            textBox_Cliente.Text = cliente.Nome;
            maskedTextBox_CPF.Text = cliente.CPF;
            maskedTextBox_DataEmissao.Text = nota.DataCompra.ToString("dd/MM/yyyy HH:mm");

            dataGridView_ItensNota.DataSource = itemNota.BuscaByNotaId();
            comboBox_Status.DataSource = Enum.GetNames(typeof(StatusNota));

            comboBox_Status.SelectedItem = nota.Status.ToString();
        }
    }
}
