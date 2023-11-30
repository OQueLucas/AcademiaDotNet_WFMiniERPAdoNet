namespace WFMiniERP
{
    partial class FormCliente
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
            button_LimparCampos = new Button();
            button_Remover = new Button();
            label_Email = new Label();
            textBox_Email = new TextBox();
            button_Cadastrar = new Button();
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            button_Atualizar = new Button();
            label_CPF = new Label();
            textBox_CPF = new TextBox();
            dataGridView_Clientes = new DataGridView();
            Column_IDs = new DataGridViewTextBoxColumn();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_CPF = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Email = new DataGridViewTextBoxColumn();
            Column_Excluir = new DataGridViewButtonColumn();
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
            button_Consultar.TabIndex = 8;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            button_Consultar.Click += button_Consultar_Click;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(45, 30);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(362, 23);
            textBox_Consultar.TabIndex = 7;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(button_LimparCampos);
            groupBox_Cadastro.Controls.Add(button_Remover);
            groupBox_Cadastro.Controls.Add(label_Email);
            groupBox_Cadastro.Controls.Add(textBox_Email);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Controls.Add(label_Nome);
            groupBox_Cadastro.Controls.Add(textBox_Nome);
            groupBox_Cadastro.Controls.Add(button_Atualizar);
            groupBox_Cadastro.Controls.Add(label_CPF);
            groupBox_Cadastro.Controls.Add(textBox_CPF);
            groupBox_Cadastro.Location = new Point(541, 30);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(247, 292);
            groupBox_Cadastro.TabIndex = 6;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // button_LimparCampos
            // 
            button_LimparCampos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_LimparCampos.Location = new Point(140, 216);
            button_LimparCampos.Name = "button_LimparCampos";
            button_LimparCampos.Size = new Size(101, 23);
            button_LimparCampos.TabIndex = 10;
            button_LimparCampos.Text = "Limpar Campos";
            button_LimparCampos.UseVisualStyleBackColor = true;
            button_LimparCampos.Click += button_LimparCampos_Click;
            // 
            // button_Remover
            // 
            button_Remover.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Remover.Location = new Point(166, 253);
            button_Remover.Name = "button_Remover";
            button_Remover.Size = new Size(75, 23);
            button_Remover.TabIndex = 9;
            button_Remover.Text = "Remover";
            button_Remover.UseVisualStyleBackColor = true;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(14, 157);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(36, 15);
            label_Email.TabIndex = 7;
            label_Email.Text = "Email";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Email.Location = new Point(6, 179);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(235, 23);
            textBox_Email.TabIndex = 6;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Cadastrar.Location = new Point(6, 253);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 1;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(14, 92);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(40, 15);
            label_Nome.TabIndex = 5;
            label_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Nome.Location = new Point(6, 114);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(235, 23);
            textBox_Nome.TabIndex = 4;
            // 
            // button_Atualizar
            // 
            button_Atualizar.Anchor = AnchorStyles.Bottom;
            button_Atualizar.Location = new Point(86, 253);
            button_Atualizar.Name = "button_Atualizar";
            button_Atualizar.Size = new Size(75, 23);
            button_Atualizar.TabIndex = 8;
            button_Atualizar.Text = "Atualizar";
            button_Atualizar.UseVisualStyleBackColor = true;
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Location = new Point(14, 25);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(28, 15);
            label_CPF.TabIndex = 3;
            label_CPF.Text = "CPF";
            // 
            // textBox_CPF
            // 
            textBox_CPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_CPF.ImeMode = ImeMode.On;
            textBox_CPF.Location = new Point(6, 47);
            textBox_CPF.Name = "textBox_CPF";
            textBox_CPF.Size = new Size(235, 23);
            textBox_CPF.TabIndex = 2;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_CPF, Column_Nome, Column_Email, Column_Excluir });
            dataGridView_Clientes.Location = new Point(12, 103);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(483, 318);
            dataGridView_Clientes.TabIndex = 5;
            dataGridView_Clientes.RowLeave += dataGridView_Clientes_RowLeave;
            // 
            // Column_IDs
            // 
            Column_IDs.Name = "Column_IDs";
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.ReadOnly = true;
            Column_ID.Visible = false;
            // 
            // Column_CPF
            // 
            Column_CPF.DataPropertyName = "CPF";
            Column_CPF.HeaderText = "CPF";
            Column_CPF.Name = "Column_CPF";
            // 
            // Column_Nome
            // 
            Column_Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_Nome.DataPropertyName = "Nome";
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            Column_Nome.Width = 65;
            // 
            // Column_Email
            // 
            Column_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_Email.DataPropertyName = "Email";
            Column_Email.HeaderText = "Email";
            Column_Email.Name = "Column_Email";
            Column_Email.Width = 61;
            // 
            // Column_Excluir
            // 
            Column_Excluir.HeaderText = "";
            Column_Excluir.Name = "Column_Excluir";
            Column_Excluir.Text = "Excluir";
            Column_Excluir.UseColumnTextForButtonValue = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Consultar);
            Controls.Add(textBox_Consultar);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(dataGridView_Clientes);
            Name = "FormCliente";
            Text = "Cliente";
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
        private Label label_CPF;
        private TextBox textBox_CPF;
        private Button button_Cadastrar;
        private DataGridView dataGridView_Clientes;
        private Label label_Email;
        private TextBox textBox_Email;
        private Button button_Atualizar;
        private Button button_Remover;
        private Button button_LimparCampos;
        private DataGridViewTextBoxColumn Column_IDs;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_CPF;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Email;
        private DataGridViewButtonColumn Column_Excluir;
    }
}