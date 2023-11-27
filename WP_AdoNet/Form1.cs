using System.Data;

namespace WP_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            Pessoa p = new();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dt = p.BuscaPessoas();
            }
            else
            {
                p.id = int.Parse(textBox1.Text);
                p = p.BuscaPessoaByIdDR();
                MessageBox.Show(p.nome);

                //dt = p.BuscaPessoaById();
            }

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa p = new();
            p.nome = textBox_Nome.Text;
            p.idade = int.Parse(textBox_Idade.Text);
            textBox_Nome.Text = "";
            textBox_Idade.Text = "";
            textBox_Nome.Focus();

            if (p.Gravar())
            {
                MessageBox.Show("Cadastrado com sucesso!");
                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar!");
            }
        }
    }
}
