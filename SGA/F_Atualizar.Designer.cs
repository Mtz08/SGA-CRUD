namespace SGA
{
    partial class F_Atualizar
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            dtgDados = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            endereco = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(495, 331);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 23;
            label6.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(480, 265);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 22;
            label5.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(508, 198);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 21;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(422, 131);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
            label3.TabIndex = 20;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(484, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 19;
            label2.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(440, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 18;
            label1.Text = "Nome Completo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(572, 330);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 17;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Consolas", 9F);
            maskedTextBox3.Location = new Point(572, 198);
            maskedTextBox3.Mask = "000\\.000\\.000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 22);
            maskedTextBox3.TabIndex = 16;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Consolas", 9F);
            maskedTextBox2.Location = new Point(572, 131);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 22);
            maskedTextBox2.TabIndex = 15;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Consolas", 9F);
            maskedTextBox1.Location = new Point(572, 71);
            maskedTextBox1.Mask = "(00)00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 22);
            maskedTextBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(572, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(73, 131);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 24;
            button1.Text = "BUSCAR ALUNO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 25;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 71);
            label7.Name = "label7";
            label7.Size = new Size(131, 17);
            label7.TabIndex = 26;
            label7.Text = "Matrícula do Aluno:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(570, 387);
            button2.Name = "button2";
            button2.Size = new Size(127, 40);
            button2.TabIndex = 27;
            button2.Text = "ATUALIZAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dtgDados
            // 
            dtgDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, cpf, telefone, endereco, email });
            dtgDados.Location = new Point(1, 315);
            dtgDados.Name = "dtgDados";
            dtgDados.Size = new Size(466, 141);
            dtgDados.TabIndex = 28;
            dtgDados.Visible = false;
            // 
            // matricula
            // 
            matricula.DataPropertyName = "matricula";
            matricula.HeaderText = "Matrícula";
            matricula.Name = "matricula";
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            // 
            // endereco
            // 
            endereco.DataPropertyName = "endereco";
            endereco.HeaderText = "Endereço";
            endereco.Name = "endereco";
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // F_Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(723, 455);
            Controls.Add(dtgDados);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "F_Atualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Dados";
            ((System.ComponentModel.ISupportInitialize)dtgDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox4;
        private Label label7;
        private Button button2;
        private DataGridView dtgDados;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn email;
    }
}