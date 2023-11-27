namespace WFMiniERP
{
    partial class Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Consultar = new Button();
            textBox_Consultar = new TextBox();
            groupBox_Cadastro = new GroupBox();
            label_Fornecedor = new Label();
            label_QuantidadeEstoque = new Label();
            textBox_Fornecedor = new TextBox();
            label_Nome = new Label();
            textBox_QuantidadeEstoque = new TextBox();
            textBox_Nome = new TextBox();
            label_Preco = new Label();
            textBox_Preco = new TextBox();
            button_Cadastrar = new Button();
            dataGridView_Clientes = new DataGridView();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // button_Consultar
            // 
            button_Consultar.FlatStyle = FlatStyle.System;
            button_Consultar.Location = new Point(413, 30);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(75, 23);
            button_Consultar.TabIndex = 12;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(45, 30);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(362, 23);
            textBox_Consultar.TabIndex = 11;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(label_Fornecedor);
            groupBox_Cadastro.Controls.Add(label_QuantidadeEstoque);
            groupBox_Cadastro.Controls.Add(textBox_Fornecedor);
            groupBox_Cadastro.Controls.Add(label_Nome);
            groupBox_Cadastro.Controls.Add(textBox_QuantidadeEstoque);
            groupBox_Cadastro.Controls.Add(textBox_Nome);
            groupBox_Cadastro.Controls.Add(label_Preco);
            groupBox_Cadastro.Controls.Add(textBox_Preco);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Location = new Point(550, 30);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(238, 311);
            groupBox_Cadastro.TabIndex = 10;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // label_Fornecedor
            // 
            label_Fornecedor.AutoSize = true;
            label_Fornecedor.Location = new Point(11, 202);
            label_Fornecedor.Name = "label_Fornecedor";
            label_Fornecedor.Size = new Size(67, 15);
            label_Fornecedor.TabIndex = 14;
            label_Fornecedor.Text = "Fornecedor";
            // 
            // label_QuantidadeEstoque
            // 
            label_QuantidadeEstoque.AutoSize = true;
            label_QuantidadeEstoque.Location = new Point(11, 145);
            label_QuantidadeEstoque.Name = "label_QuantidadeEstoque";
            label_QuantidadeEstoque.Size = new Size(114, 15);
            label_QuantidadeEstoque.TabIndex = 16;
            label_QuantidadeEstoque.Text = "Quantidade Estoque";
            // 
            // textBox_Fornecedor
            // 
            textBox_Fornecedor.Location = new Point(6, 224);
            textBox_Fornecedor.Name = "textBox_Fornecedor";
            textBox_Fornecedor.Size = new Size(226, 23);
            textBox_Fornecedor.TabIndex = 13;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(11, 28);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(40, 15);
            label_Nome.TabIndex = 5;
            label_Nome.Text = "Nome";
            // 
            // textBox_QuantidadeEstoque
            // 
            textBox_QuantidadeEstoque.Location = new Point(6, 167);
            textBox_QuantidadeEstoque.Name = "textBox_QuantidadeEstoque";
            textBox_QuantidadeEstoque.Size = new Size(226, 23);
            textBox_QuantidadeEstoque.TabIndex = 15;
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(6, 50);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(226, 23);
            textBox_Nome.TabIndex = 4;
            // 
            // label_Preco
            // 
            label_Preco.AutoSize = true;
            label_Preco.Location = new Point(11, 86);
            label_Preco.Name = "label_Preco";
            label_Preco.Size = new Size(37, 15);
            label_Preco.TabIndex = 3;
            label_Preco.Text = "Preço";
            // 
            // textBox_Preco
            // 
            textBox_Preco.ImeMode = ImeMode.On;
            textBox_Preco.Location = new Point(6, 108);
            textBox_Preco.Name = "textBox_Preco";
            textBox_Preco.Size = new Size(226, 23);
            textBox_Preco.TabIndex = 2;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(157, 282);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 1;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(12, 103);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(518, 318);
            dataGridView_Clientes.TabIndex = 9;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Consultar);
            Controls.Add(textBox_Consultar);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(dataGridView_Clientes);
            Name = "Produto";
            Text = "Produto";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Consultar;
        private TextBox textBox_Consultar;
        private GroupBox groupBox_Cadastro;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Label label_Preco;
        private TextBox textBox_Preco;
        private Button button_Cadastrar;
        private DataGridView dataGridView_Clientes;
        private Label label_QuantidadeEstoque;
        private TextBox textBox_QuantidadeEstoque;
        private Label label_Fornecedor;
        private TextBox textBox_Fornecedor;
    }
}