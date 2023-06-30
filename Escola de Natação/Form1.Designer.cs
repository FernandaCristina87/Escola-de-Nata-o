namespace Escola_de_Natação
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
            label4 = new Label();
            txtNomedoAluno = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtCPF = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            groupBox1 = new GroupBox();
            lblQuantidadeAlunosCadastrados = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtBuscaPorCPF = new TextBox();
            btbBuscar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome do Aluno";
            // 
            // txtNomedoAluno
            // 
            txtNomedoAluno.Location = new Point(9, 37);
            txtNomedoAluno.Name = "txtNomedoAluno";
            txtNomedoAluno.Size = new Size(277, 23);
            txtNomedoAluno.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(9, 354);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(160, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrarAluno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 75);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(9, 93);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(395, 23);
            txtEndereco.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 166);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(112, 23);
            txtTelefone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 209);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(9, 227);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(152, 23);
            txtCPF.TabIndex = 13;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(9, 295);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(306, 23);
            dtpDataNascimento.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblQuantidadeAlunosCadastrados);
            groupBox1.Location = new Point(573, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 171);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alunos Cadastrados";
            // 
            // lblQuantidadeAlunosCadastrados
            // 
            lblQuantidadeAlunosCadastrados.AutoSize = true;
            lblQuantidadeAlunosCadastrados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadeAlunosCadastrados.Location = new Point(86, 68);
            lblQuantidadeAlunosCadastrados.Name = "lblQuantidadeAlunosCadastrados";
            lblQuantidadeAlunosCadastrados.Size = new Size(32, 37);
            lblQuantidadeAlunosCadastrados.TabIndex = 0;
            lblQuantidadeAlunosCadastrados.Text = "0";
            lblQuantidadeAlunosCadastrados.Click += lblQuantidadeAlunosCadastrados_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 274);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 17;
            label5.Text = "Data de Nascimento";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btbBuscar);
            groupBox2.Controls.Add(txtBuscaPorCPF);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(573, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 148);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 31);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 0;
            label6.Text = "CPF";
            // 
            // txtBuscaPorCPF
            // 
            txtBuscaPorCPF.Location = new Point(9, 54);
            txtBuscaPorCPF.Name = "txtBuscaPorCPF";
            txtBuscaPorCPF.Size = new Size(140, 23);
            txtBuscaPorCPF.TabIndex = 1;
            // 
            // btbBuscar
            // 
            btbBuscar.Location = new Point(71, 111);
            btbBuscar.Name = "btbBuscar";
            btbBuscar.Size = new Size(75, 23);
            btbBuscar.TabIndex = 2;
            btbBuscar.Text = "Buscar";
            btbBuscar.UseVisualStyleBackColor = true;
            btbBuscar.Click += btbBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 445);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNomedoAluno);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Cadastro do Aluno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtNomedoAluno;
        private Button btnCadastrar;
        private Label label1;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtCPF;
        private DateTimePicker dtpDataNascimento;
        private GroupBox groupBox1;
        private Label label5;
        private Label lblQuantidadeAlunosCadastrados;
        private GroupBox groupBox2;
        private TextBox txtBuscaPorCPF;
        private Label label6;
        private Button btbBuscar;
    }
}