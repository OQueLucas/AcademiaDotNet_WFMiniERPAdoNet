namespace WP_AdoNet
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Nome = new TextBox();
            textBox_Idade = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 95);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 0;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(350, 202);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 23);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox_Idade);
            groupBox1.Controls.Add(textBox_Nome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(526, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 211);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(39, 52);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(100, 23);
            textBox_Nome.TabIndex = 2;
            // 
            // textBox_Idade
            // 
            textBox_Idade.Location = new Point(39, 112);
            textBox_Idade.Name = "textBox_Idade";
            textBox_Idade.Size = new Size(100, 23);
            textBox_Idade.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(98, 174);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox_Idade;
        private TextBox textBox_Nome;
        private Label label2;
        private Label label1;
    }
}
