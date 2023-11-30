namespace WFMiniERP
{
    partial class FormFornecedor
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
            dataGridView_Fornecedores = new DataGridView();
            button_Cadastrar = new Button();
            groupBox_Cadastro = new GroupBox();
            label_RazaoSocial = new Label();
            textBox_RazaoSocial = new TextBox();
            label_CNPJ = new Label();
            textBox_CNPJ = new TextBox();
            textBox_Consultar = new TextBox();
            button_Consultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            groupBox_Cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Location = new Point(12, 120);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.RowTemplate.Height = 25;
            dataGridView_Fornecedores.Size = new Size(518, 318);
            dataGridView_Fornecedores.TabIndex = 0;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(157, 153);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 1;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(label_RazaoSocial);
            groupBox_Cadastro.Controls.Add(textBox_RazaoSocial);
            groupBox_Cadastro.Controls.Add(label_CNPJ);
            groupBox_Cadastro.Controls.Add(textBox_CNPJ);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Location = new Point(550, 47);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(238, 182);
            groupBox_Cadastro.TabIndex = 2;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // label_RazaoSocial
            // 
            label_RazaoSocial.AutoSize = true;
            label_RazaoSocial.Location = new Point(11, 92);
            label_RazaoSocial.Name = "label_RazaoSocial";
            label_RazaoSocial.Size = new Size(72, 15);
            label_RazaoSocial.TabIndex = 5;
            label_RazaoSocial.Text = "Razão Social";
            // 
            // textBox_RazaoSocial
            // 
            textBox_RazaoSocial.Location = new Point(6, 114);
            textBox_RazaoSocial.Name = "textBox_RazaoSocial";
            textBox_RazaoSocial.Size = new Size(226, 23);
            textBox_RazaoSocial.TabIndex = 4;
            // 
            // label_CNPJ
            // 
            label_CNPJ.AutoSize = true;
            label_CNPJ.Location = new Point(11, 25);
            label_CNPJ.Name = "label_CNPJ";
            label_CNPJ.Size = new Size(34, 15);
            label_CNPJ.TabIndex = 3;
            label_CNPJ.Text = "CNPJ";
            // 
            // textBox_CNPJ
            // 
            textBox_CNPJ.ImeMode = ImeMode.On;
            textBox_CNPJ.Location = new Point(6, 47);
            textBox_CNPJ.Name = "textBox_CNPJ";
            textBox_CNPJ.Size = new Size(226, 23);
            textBox_CNPJ.TabIndex = 2;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(45, 47);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(362, 23);
            textBox_Consultar.TabIndex = 3;
            // 
            // button_Consultar
            // 
            button_Consultar.FlatStyle = FlatStyle.System;
            button_Consultar.Location = new Point(413, 47);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(75, 23);
            button_Consultar.TabIndex = 4;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Consultar);
            Controls.Add(textBox_Consultar);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(dataGridView_Fornecedores);
            Name = "FormFornecedor";
            Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).EndInit();
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Cadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Fornecedores;
        private Button button_Cadastrar;
        private GroupBox groupBox_Cadastro;
        private Label label_RazaoSocial;
        private TextBox textBox_RazaoSocial;
        private Label label_CNPJ;
        private TextBox textBox_CNPJ;
        private TextBox textBox_Consultar;
        private Button button_Consultar;
    }
}