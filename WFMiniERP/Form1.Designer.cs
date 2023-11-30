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
            textBox_Consultar = new TextBox();
            dataGridView_Clientes = new DataGridView();
            button_Clientes = new Button();
            button_Produtos = new Button();
            button_Fornecedores = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox_Clientes = new ComboBox();
            groupBox_Cadastro = new GroupBox();
            button_AtualizarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            groupBox_Cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // button_Adicionar
            // 
            button_Adicionar.FlatStyle = FlatStyle.System;
            button_Adicionar.Location = new Point(532, 102);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(75, 23);
            button_Adicionar.TabIndex = 11;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.UseVisualStyleBackColor = true;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(12, 73);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(595, 23);
            textBox_Consultar.TabIndex = 10;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(12, 131);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(595, 307);
            dataGridView_Clientes.TabIndex = 9;
            // 
            // button_Clientes
            // 
            button_Clientes.Anchor = AnchorStyles.Top;
            button_Clientes.Location = new Point(19, 22);
            button_Clientes.Name = "button_Clientes";
            button_Clientes.Size = new Size(93, 23);
            button_Clientes.TabIndex = 12;
            button_Clientes.Text = "Clientes";
            button_Clientes.UseVisualStyleBackColor = true;
            button_Clientes.Click += button_Clientes_Click;
            // 
            // button_Produtos
            // 
            button_Produtos.Anchor = AnchorStyles.Bottom;
            button_Produtos.Location = new Point(19, 106);
            button_Produtos.Name = "button_Produtos";
            button_Produtos.Size = new Size(93, 23);
            button_Produtos.TabIndex = 13;
            button_Produtos.Text = "Produtos";
            button_Produtos.UseVisualStyleBackColor = true;
            button_Produtos.Click += button_Produtos_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Anchor = AnchorStyles.None;
            button_Fornecedores.Location = new Point(19, 64);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(93, 23);
            button_Fornecedores.TabIndex = 14;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 15;
            label1.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 16;
            label2.Text = "Cliente:";
            // 
            // comboBox_Clientes
            // 
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
            groupBox_Cadastro.Location = new Point(653, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(135, 139);
            groupBox_Cadastro.TabIndex = 18;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastros";
            // 
            // button_AtualizarClientes
            // 
            button_AtualizarClientes.Location = new Point(264, 6);
            button_AtualizarClientes.Name = "button_AtualizarClientes";
            button_AtualizarClientes.Size = new Size(121, 23);
            button_AtualizarClientes.TabIndex = 19;
            button_AtualizarClientes.Text = "Atualizar Clientes";
            button_AtualizarClientes.UseVisualStyleBackColor = true;
            button_AtualizarClientes.Click += button_AtualizarClientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_AtualizarClientes);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(comboBox_Clientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Adicionar);
            Controls.Add(textBox_Consultar);
            Controls.Add(dataGridView_Clientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            groupBox_Cadastro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Adicionar;
        private TextBox textBox_Consultar;
        private DataGridView dataGridView_Clientes;
        private Button button_Clientes;
        private Button button_Produtos;
        private Button button_Fornecedores;
        private Label label1;
        private Label label2;
        private ComboBox comboBox_Clientes;
        private GroupBox groupBox_Cadastro;
        private Button button_AtualizarClientes;
    }
}
