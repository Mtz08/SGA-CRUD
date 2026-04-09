namespace SGA
{
    partial class F_Excluir
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
            label7 = new Label();
            textBox4 = new TextBox();
            btnBuscar = new Button();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // dtgDados
            // 
            dtgDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, cpf, telefone, endereco, email });
            dtgDados.Dock = DockStyle.Bottom;
            dtgDados.Location = new Point(0, 278);
            dtgDados.Name = "dtgDados";
            dtgDados.Size = new Size(767, 141);
            dtgDados.TabIndex = 32;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 40);
            label7.Name = "label7";
            label7.Size = new Size(131, 17);
            label7.TabIndex = 31;
            label7.Text = "Matrícula do Aluno:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(83, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 36);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "BUSCAR ALUNO";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(609, 204);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(119, 42);
            btnDeletar.TabIndex = 33;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // F_Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(767, 419);
            Controls.Add(btnDeletar);
            Controls.Add(dtgDados);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(btnBuscar);
            Name = "F_Excluir";
            Text = "Excluir Aluno";
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
        private Label label7;
        private TextBox textBox4;
        private Button btnBuscar;
        private Button btnDeletar;
    }
}