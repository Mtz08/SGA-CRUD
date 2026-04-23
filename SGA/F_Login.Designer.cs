namespace SGA
{
    partial class F_Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            btnCliqueAqui = new Button();
            pnlCadastrar = new Panel();
            panel2 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            btnCadastrar = new Button();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            pnlCadastrar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(168, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "LOGIN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(168, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "SENHA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 264);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Não tem cadastro?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(168, 203);
            button1.Name = "button1";
            button1.Size = new Size(191, 31);
            button1.TabIndex = 5;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCliqueAqui
            // 
            btnCliqueAqui.Location = new Point(214, 293);
            btnCliqueAqui.Name = "btnCliqueAqui";
            btnCliqueAqui.Size = new Size(84, 29);
            btnCliqueAqui.TabIndex = 6;
            btnCliqueAqui.Text = "Clique Aqui";
            btnCliqueAqui.UseVisualStyleBackColor = true;
            btnCliqueAqui.Click += btnCliqueAqui_Click;
            // 
            // pnlCadastrar
            // 
            pnlCadastrar.BackColor = Color.DimGray;
            pnlCadastrar.Controls.Add(panel2);
            pnlCadastrar.Location = new Point(137, 8);
            pnlCadastrar.Name = "pnlCadastrar";
            pnlCadastrar.Size = new Size(236, 226);
            pnlCadastrar.TabIndex = 7;
            pnlCadastrar.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 220);
            panel2.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gainsboro;
            btnCadastrar.Location = new Point(40, 179);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(144, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(37, 110);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 1;
            label5.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(37, 32);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "E-mail:";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(183, 3);
            button2.Name = "button2";
            button2.Size = new Size(45, 23);
            button2.TabIndex = 5;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 382);
            Controls.Add(pnlCadastrar);
            Controls.Add(btnCliqueAqui);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Login";
            pnlCadastrar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button btnCliqueAqui;
        private Panel pnlCadastrar;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btnCadastrar;
        private Label label5;
        private Label label4;
        private Button button2;
    }
}