namespace WFMiniERP
{
    partial class FormNotaFiscal
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
            comboBox_FiltroCliente = new ComboBox();
            label_FiltroCliente = new Label();
            dataGridView_Notas = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Data_Emissao = new DataGridViewTextBoxColumn();
            Column_Status = new DataGridViewTextBoxColumn();
            Column_Cliente = new DataGridViewTextBoxColumn();
            dateTimePicker_FiltroDataEmissao = new DateTimePicker();
            comboBox_FiltroStatus = new ComboBox();
            label_FiltroStatus = new Label();
            label_FiltroDataEmissao = new Label();
            button_Filtrar = new Button();
            button_RemoverFiltros = new Button();
            groupBox_VisualizarNota = new GroupBox();
            label1 = new Label();
            comboBox_Status = new ComboBox();
            maskedTextBox_DataEmissao = new MaskedTextBox();
            label_DataEmissao = new Label();
            maskedTextBox_CPF = new MaskedTextBox();
            textBox_Cliente = new TextBox();
            label_CPF = new Label();
            dataGridView_ItensNota = new DataGridView();
            label_Cliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Notas).BeginInit();
            groupBox_VisualizarNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItensNota).BeginInit();
            SuspendLayout();
            // 
            // comboBox_FiltroCliente
            // 
            comboBox_FiltroCliente.FormattingEnabled = true;
            comboBox_FiltroCliente.Location = new Point(62, 17);
            comboBox_FiltroCliente.Name = "comboBox_FiltroCliente";
            comboBox_FiltroCliente.Size = new Size(102, 23);
            comboBox_FiltroCliente.TabIndex = 0;
            // 
            // label_FiltroCliente
            // 
            label_FiltroCliente.AutoSize = true;
            label_FiltroCliente.Location = new Point(12, 20);
            label_FiltroCliente.Name = "label_FiltroCliente";
            label_FiltroCliente.Size = new Size(44, 15);
            label_FiltroCliente.TabIndex = 1;
            label_FiltroCliente.Text = "Cliente";
            // 
            // dataGridView_Notas
            // 
            dataGridView_Notas.AllowUserToAddRows = false;
            dataGridView_Notas.AllowUserToDeleteRows = false;
            dataGridView_Notas.AllowUserToOrderColumns = true;
            dataGridView_Notas.BackgroundColor = SystemColors.Control;
            dataGridView_Notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Notas.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Data_Emissao, Column_Status, Column_Cliente });
            dataGridView_Notas.Location = new Point(12, 82);
            dataGridView_Notas.Name = "dataGridView_Notas";
            dataGridView_Notas.ReadOnly = true;
            dataGridView_Notas.RowTemplate.Height = 25;
            dataGridView_Notas.Size = new Size(412, 477);
            dataGridView_Notas.TabIndex = 2;
            dataGridView_Notas.RowEnter += dataGridView_Notas_RowEnter;
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.ReadOnly = true;
            Column_ID.Visible = false;
            // 
            // Column_Data_Emissao
            // 
            Column_Data_Emissao.DataPropertyName = "Data_Emissao";
            Column_Data_Emissao.HeaderText = "Data de Emissão";
            Column_Data_Emissao.Name = "Column_Data_Emissao";
            Column_Data_Emissao.ReadOnly = true;
            // 
            // Column_Status
            // 
            Column_Status.DataPropertyName = "Status";
            Column_Status.HeaderText = "Status";
            Column_Status.Name = "Column_Status";
            Column_Status.ReadOnly = true;
            // 
            // Column_Cliente
            // 
            Column_Cliente.DataPropertyName = "Cliente";
            Column_Cliente.HeaderText = "Cliente";
            Column_Cliente.Name = "Column_Cliente";
            Column_Cliente.ReadOnly = true;
            // 
            // dateTimePicker_FiltroDataEmissao
            // 
            dateTimePicker_FiltroDataEmissao.Location = new Point(270, 17);
            dateTimePicker_FiltroDataEmissao.Name = "dateTimePicker_FiltroDataEmissao";
            dateTimePicker_FiltroDataEmissao.Size = new Size(154, 23);
            dateTimePicker_FiltroDataEmissao.TabIndex = 3;
            // 
            // comboBox_FiltroStatus
            // 
            comboBox_FiltroStatus.FormattingEnabled = true;
            comboBox_FiltroStatus.Location = new Point(62, 49);
            comboBox_FiltroStatus.Name = "comboBox_FiltroStatus";
            comboBox_FiltroStatus.Size = new Size(102, 23);
            comboBox_FiltroStatus.TabIndex = 4;
            // 
            // label_FiltroStatus
            // 
            label_FiltroStatus.AutoSize = true;
            label_FiltroStatus.Location = new Point(12, 52);
            label_FiltroStatus.Name = "label_FiltroStatus";
            label_FiltroStatus.Size = new Size(39, 15);
            label_FiltroStatus.TabIndex = 5;
            label_FiltroStatus.Text = "Status";
            // 
            // label_FiltroDataEmissao
            // 
            label_FiltroDataEmissao.AutoSize = true;
            label_FiltroDataEmissao.Location = new Point(187, 20);
            label_FiltroDataEmissao.Name = "label_FiltroDataEmissao";
            label_FiltroDataEmissao.Size = new Size(77, 15);
            label_FiltroDataEmissao.TabIndex = 6;
            label_FiltroDataEmissao.Text = "Data Emissão";
            // 
            // button_Filtrar
            // 
            button_Filtrar.Location = new Point(218, 49);
            button_Filtrar.Name = "button_Filtrar";
            button_Filtrar.Size = new Size(75, 23);
            button_Filtrar.TabIndex = 7;
            button_Filtrar.Text = "Filtrar";
            button_Filtrar.UseVisualStyleBackColor = true;
            // 
            // button_RemoverFiltros
            // 
            button_RemoverFiltros.Location = new Point(326, 49);
            button_RemoverFiltros.Name = "button_RemoverFiltros";
            button_RemoverFiltros.Size = new Size(98, 23);
            button_RemoverFiltros.TabIndex = 8;
            button_RemoverFiltros.Text = "Remover Filtros";
            button_RemoverFiltros.UseVisualStyleBackColor = true;
            // 
            // groupBox_VisualizarNota
            // 
            groupBox_VisualizarNota.Controls.Add(label1);
            groupBox_VisualizarNota.Controls.Add(comboBox_Status);
            groupBox_VisualizarNota.Controls.Add(maskedTextBox_DataEmissao);
            groupBox_VisualizarNota.Controls.Add(label_DataEmissao);
            groupBox_VisualizarNota.Controls.Add(maskedTextBox_CPF);
            groupBox_VisualizarNota.Controls.Add(textBox_Cliente);
            groupBox_VisualizarNota.Controls.Add(label_CPF);
            groupBox_VisualizarNota.Controls.Add(dataGridView_ItensNota);
            groupBox_VisualizarNota.Controls.Add(label_Cliente);
            groupBox_VisualizarNota.Location = new Point(444, 12);
            groupBox_VisualizarNota.Name = "groupBox_VisualizarNota";
            groupBox_VisualizarNota.Size = new Size(344, 547);
            groupBox_VisualizarNota.TabIndex = 9;
            groupBox_VisualizarNota.TabStop = false;
            groupBox_VisualizarNota.Text = "Visualizar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(6, 521);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 18;
            label1.Text = "Status:";
            // 
            // comboBox_Status
            // 
            comboBox_Status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Location = new Point(54, 518);
            comboBox_Status.Name = "comboBox_Status";
            comboBox_Status.Size = new Size(121, 23);
            comboBox_Status.TabIndex = 17;
            // 
            // maskedTextBox_DataEmissao
            // 
            maskedTextBox_DataEmissao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maskedTextBox_DataEmissao.Enabled = false;
            maskedTextBox_DataEmissao.Location = new Point(108, 489);
            maskedTextBox_DataEmissao.Mask = "00/00/0000 90:00";
            maskedTextBox_DataEmissao.Name = "maskedTextBox_DataEmissao";
            maskedTextBox_DataEmissao.Size = new Size(87, 23);
            maskedTextBox_DataEmissao.TabIndex = 16;
            maskedTextBox_DataEmissao.ValidatingType = typeof(DateTime);
            // 
            // label_DataEmissao
            // 
            label_DataEmissao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_DataEmissao.AutoSize = true;
            label_DataEmissao.Location = new Point(6, 492);
            label_DataEmissao.Name = "label_DataEmissao";
            label_DataEmissao.Size = new Size(96, 15);
            label_DataEmissao.TabIndex = 15;
            label_DataEmissao.Text = "Data de Emissão:";
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.Enabled = false;
            maskedTextBox_CPF.Location = new Point(58, 51);
            maskedTextBox_CPF.Mask = "000,000,000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(88, 23);
            maskedTextBox_CPF.TabIndex = 14;
            // 
            // textBox_Cliente
            // 
            textBox_Cliente.Enabled = false;
            textBox_Cliente.Location = new Point(58, 22);
            textBox_Cliente.Name = "textBox_Cliente";
            textBox_Cliente.Size = new Size(177, 23);
            textBox_Cliente.TabIndex = 13;
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Location = new Point(6, 54);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(31, 15);
            label_CPF.TabIndex = 12;
            label_CPF.Text = "CPF:";
            // 
            // dataGridView_ItensNota
            // 
            dataGridView_ItensNota.AllowUserToAddRows = false;
            dataGridView_ItensNota.AllowUserToDeleteRows = false;
            dataGridView_ItensNota.AllowUserToOrderColumns = true;
            dataGridView_ItensNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_ItensNota.BackgroundColor = SystemColors.Control;
            dataGridView_ItensNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ItensNota.Enabled = false;
            dataGridView_ItensNota.Location = new Point(6, 84);
            dataGridView_ItensNota.MultiSelect = false;
            dataGridView_ItensNota.Name = "dataGridView_ItensNota";
            dataGridView_ItensNota.ReadOnly = true;
            dataGridView_ItensNota.RowTemplate.Height = 25;
            dataGridView_ItensNota.Size = new Size(332, 399);
            dataGridView_ItensNota.TabIndex = 10;
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(6, 25);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(47, 15);
            label_Cliente.TabIndex = 10;
            label_Cliente.Text = "Cliente:";
            // 
            // FormNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(groupBox_VisualizarNota);
            Controls.Add(button_RemoverFiltros);
            Controls.Add(button_Filtrar);
            Controls.Add(label_FiltroDataEmissao);
            Controls.Add(label_FiltroStatus);
            Controls.Add(comboBox_FiltroStatus);
            Controls.Add(dateTimePicker_FiltroDataEmissao);
            Controls.Add(dataGridView_Notas);
            Controls.Add(label_FiltroCliente);
            Controls.Add(comboBox_FiltroCliente);
            Name = "FormNotaFiscal";
            Text = "FormNotaFiscal";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Notas).EndInit();
            groupBox_VisualizarNota.ResumeLayout(false);
            groupBox_VisualizarNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItensNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_FiltroCliente;
        private Label label_FiltroCliente;
        private DataGridView dataGridView_Notas;
        private DateTimePicker dateTimePicker_FiltroDataEmissao;
        private ComboBox comboBox_FiltroStatus;
        private Label label_FiltroStatus;
        private Label label_FiltroDataEmissao;
        private Button button_Filtrar;
        private Button button_RemoverFiltros;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Data_Emissao;
        private DataGridViewTextBoxColumn Column_Status;
        private DataGridViewTextBoxColumn Column_Cliente;
        private GroupBox groupBox_VisualizarNota;
        private Label label_Cliente;
        private Label label_CPF;
        private DataGridView dataGridView_ItensNota;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MaskedTextBox maskedTextBox_CPF;
        private TextBox textBox_Cliente;
        private Label label_DataEmissao;
        private ComboBox comboBox_Status;
        private MaskedTextBox maskedTextBox_DataEmissao;
        private Label label1;
    }
}