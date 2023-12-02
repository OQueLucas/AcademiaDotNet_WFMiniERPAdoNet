namespace WFMiniERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Adicionar = new Button();
            dataGridView_Produtos = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Preco = new DataGridViewTextBoxColumn();
            Column_Quantidade = new DataGridViewTextBoxColumn();
            button_Clientes = new Button();
            button_Produtos = new Button();
            button_Fornecedores = new Button();
            label_Produto = new Label();
            label_Cliente = new Label();
            comboBox_Clientes = new ComboBox();
            groupBox_Cadastro = new GroupBox();
            button_AtualizarClientes = new Button();
            comboBox_Produtos = new ComboBox();
            button_EmitirNota = new Button();
            numericUpDown_Quantidade = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).BeginInit();
            SuspendLayout();
            // 
            // button_Adicionar
            // 
            button_Adicionar.FlatStyle = FlatStyle.System;
            button_Adicionar.Location = new Point(532, 53);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(75, 23);
            button_Adicionar.TabIndex = 11;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.UseVisualStyleBackColor = true;
            button_Adicionar.Click += button_Adicionar_Click;
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Nome, Column_Preco, Column_Quantidade });
            dataGridView_Produtos.Location = new Point(12, 81);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.Size = new Size(595, 328);
            dataGridView_Produtos.TabIndex = 9;
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_Nome
            // 
            Column_Nome.DataPropertyName = "Nome";
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            // 
            // Column_Preco
            // 
            Column_Preco.DataPropertyName = "Preco";
            Column_Preco.HeaderText = "Preço";
            Column_Preco.Name = "Column_Preco";
            // 
            // Column_Quantidade
            // 
            Column_Quantidade.DataPropertyName = "Quantidade";
            Column_Quantidade.HeaderText = "Quantidade";
            Column_Quantidade.Name = "Column_Quantidade";
            // 
            // button_Clientes
            // 
            button_Clientes.Anchor = AnchorStyles.Top;
            button_Clientes.Location = new Point(22, 22);
            button_Clientes.Name = "button_Clientes";
            button_Clientes.Size = new Size(95, 25);
            button_Clientes.TabIndex = 12;
            button_Clientes.Text = "Clientes";
            button_Clientes.UseVisualStyleBackColor = true;
            button_Clientes.Click += button_Clientes_Click;
            // 
            // button_Produtos
            // 
            button_Produtos.Anchor = AnchorStyles.Bottom;
            button_Produtos.Location = new Point(22, 108);
            button_Produtos.Name = "button_Produtos";
            button_Produtos.Size = new Size(95, 25);
            button_Produtos.TabIndex = 13;
            button_Produtos.Text = "Produtos";
            button_Produtos.UseVisualStyleBackColor = true;
            button_Produtos.Click += button_Produtos_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Anchor = AnchorStyles.None;
            button_Fornecedores.Location = new Point(22, 65);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(95, 25);
            button_Fornecedores.TabIndex = 14;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Location = new Point(12, 55);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(55, 15);
            label_Produto.TabIndex = 15;
            label_Produto.Text = "Produtos";
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(12, 9);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(47, 15);
            label_Cliente.TabIndex = 16;
            label_Cliente.Text = "Cliente:";
            // 
            // comboBox_Clientes
            // 
            comboBox_Clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Clientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Clientes.FormattingEnabled = true;
            comboBox_Clientes.Location = new Point(65, 6);
            comboBox_Clientes.Name = "comboBox_Clientes";
            comboBox_Clientes.Size = new Size(193, 23);
            comboBox_Clientes.TabIndex = 17;
            comboBox_Clientes.Click += comboBox1_Click;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(button_Clientes);
            groupBox_Cadastro.Controls.Add(button_Produtos);
            groupBox_Cadastro.Controls.Add(button_Fornecedores);
            groupBox_Cadastro.Location = new Point(648, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(140, 139);
            groupBox_Cadastro.TabIndex = 18;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastros";
            // 
            // button_AtualizarClientes
            // 
            button_AtualizarClientes.Location = new Point(486, 6);
            button_AtualizarClientes.Name = "button_AtualizarClientes";
            button_AtualizarClientes.Size = new Size(121, 23);
            button_AtualizarClientes.TabIndex = 19;
            button_AtualizarClientes.Text = "Atualizar Listas";
            button_AtualizarClientes.UseVisualStyleBackColor = true;
            button_AtualizarClientes.Click += button_AtualizarClientes_Click;
            // 
            // comboBox_Produtos
            // 
            comboBox_Produtos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Produtos.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Produtos.FormattingEnabled = true;
            comboBox_Produtos.Location = new Point(73, 52);
            comboBox_Produtos.Name = "comboBox_Produtos";
            comboBox_Produtos.Size = new Size(364, 23);
            comboBox_Produtos.TabIndex = 20;
            // 
            // button_EmitirNota
            // 
            button_EmitirNota.Location = new Point(532, 415);
            button_EmitirNota.Name = "button_EmitirNota";
            button_EmitirNota.Size = new Size(75, 23);
            button_EmitirNota.TabIndex = 21;
            button_EmitirNota.Text = "Emitir Nota";
            button_EmitirNota.UseVisualStyleBackColor = true;
            button_EmitirNota.Click += button_EmitirNota_Click;
            // 
            // numericUpDown_Quantidade
            // 
            numericUpDown_Quantidade.Location = new Point(443, 52);
            numericUpDown_Quantidade.Name = "numericUpDown_Quantidade";
            numericUpDown_Quantidade.Size = new Size(83, 23);
            numericUpDown_Quantidade.TabIndex = 22;
            numericUpDown_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(670, 314);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 24;
            button1.Text = "Notas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(numericUpDown_Quantidade);
            Controls.Add(button_EmitirNota);
            Controls.Add(comboBox_Produtos);
            Controls.Add(button_AtualizarClientes);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(comboBox_Clientes);
            Controls.Add(label_Cliente);
            Controls.Add(label_Produto);
            Controls.Add(button_Adicionar);
            Controls.Add(dataGridView_Produtos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            groupBox_Cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Adicionar;
        private DataGridView dataGridView_Produtos;
        private Button button_Clientes;
        private Button button_Produtos;
        private Button button_Fornecedores;
        private Label label_Produto;
        private Label label_Cliente;
        private ComboBox comboBox_Clientes;
        private GroupBox groupBox_Cadastro;
        private Button button_AtualizarClientes;
        private TextBox textBox_Consultar;
        private ComboBox comboBox_Produtos;
        private Button button_EmitirNota;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Preco;
        private DataGridViewTextBoxColumn Column_Quantidade;
        private NumericUpDown numericUpDown_Quantidade;
        private Button button1;
    }
}
