namespace SGA
{
    partial class F_Listar
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
            dtgDados = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            endereco = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            rdbMatricula = new RadioButton();
            rdbNome = new RadioButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // dtgDados
            // 
            dtgDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, cpf, telefone, endereco, email });
            dtgDados.Dock = DockStyle.Bottom;
            dtgDados.Location = new Point(0, 322);
            dtgDados.Name = "dtgDados";
            dtgDados.Size = new Size(800, 128);
            dtgDados.TabIndex = 0;
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
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 27);
            button1.Name = "button1";
            button1.Size = new Size(168, 47);
            button1.TabIndex = 1;
            button1.Text = "LISTAR TODOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(627, 194);
            button2.Name = "button2";
            button2.Size = new Size(122, 47);
            button2.TabIndex = 2;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // rdbMatricula
            // 
            rdbMatricula.AutoSize = true;
            rdbMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbMatricula.Location = new Point(627, 55);
            rdbMatricula.Name = "rdbMatricula";
            rdbMatricula.Size = new Size(77, 19);
            rdbMatricula.TabIndex = 3;
            rdbMatricula.TabStop = true;
            rdbMatricula.Text = "Matrícula";
            rdbMatricula.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            rdbNome.AutoSize = true;
            rdbNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbNome.Location = new Point(627, 96);
            rdbNome.Name = "rdbNome";
            rdbNome.Size = new Size(111, 19);
            rdbNome.TabIndex = 4;
            rdbNome.TabStop = true;
            rdbNome.Text = "Nome do Aluno";
            rdbNome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 5;
            // 
            // F_Listar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(rdbNome);
            Controls.Add(rdbMatricula);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtgDados);
            Name = "F_Listar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Alunos";
            ((System.ComponentModel.ISupportInitialize)dtgDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDados;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn email;
        private Button button1;
        private Button button2;
        private RadioButton rdbMatricula;
        private RadioButton rdbNome;
        private TextBox textBox1;
    }
}