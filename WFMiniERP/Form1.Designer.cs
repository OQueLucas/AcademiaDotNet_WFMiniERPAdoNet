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
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // button_Adicionar
            // 
            button_Adicionar.FlatStyle = FlatStyle.System;
            button_Adicionar.Location = new Point(556, 31);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(75, 23);
            button_Adicionar.TabIndex = 11;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.UseVisualStyleBackColor = true;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(39, 31);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(511, 23);
            textBox_Consultar.TabIndex = 10;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(39, 102);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(592, 318);
            dataGridView_Clientes.TabIndex = 9;
            // 
            // button_Clientes
            // 
            button_Clientes.Location = new Point(695, 31);
            button_Clientes.Name = "button_Clientes";
            button_Clientes.Size = new Size(93, 23);
            button_Clientes.TabIndex = 12;
            button_Clientes.Text = "Clientes";
            button_Clientes.UseVisualStyleBackColor = true;
            button_Clientes.Click += button_Clientes_Click;
            // 
            // button_Produtos
            // 
            button_Produtos.Location = new Point(695, 171);
            button_Produtos.Name = "button_Produtos";
            button_Produtos.Size = new Size(93, 23);
            button_Produtos.TabIndex = 13;
            button_Produtos.Text = "Produtos";
            button_Produtos.UseVisualStyleBackColor = true;
            button_Produtos.Click += button_Produtos_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Location = new Point(695, 103);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(93, 23);
            button_Fornecedores.TabIndex = 14;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Fornecedores);
            Controls.Add(button_Produtos);
            Controls.Add(button_Clientes);
            Controls.Add(button_Adicionar);
            Controls.Add(textBox_Consultar);
            Controls.Add(dataGridView_Clientes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
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
    }
}
