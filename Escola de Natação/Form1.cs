namespace Escola_de_Natação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Aluno> alunosCadastrado = new List<Aluno>();



        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoCadastrado = new Aluno();

            alunoCadastrado.Nome = txtNomedoAluno.Text;
            alunoCadastrado.CPF = txtCPF.Text;
            alunoCadastrado.Endereco = txtEndereco.Text;
            alunoCadastrado.Telefone = txtTelefone.Text;
            alunoCadastrado.DataNascimento = dtpDataNascimento.Value;

            alunosCadastrado.Add(alunoCadastrado);

            MessageBox.Show("O Aluno(a): " + alunoCadastrado.Nome + " foi cadastrado");

            lblQuantidadeAlunosCadastrados.Text = alunosCadastrado.Count().ToString();

        }

        public void CriarAlunosMockup()
        {
            Aluno alunoCadastrado = new Aluno();
            alunoCadastrado.Nome = "Marcio";
            alunoCadastrado.DataNascimento = new DateTime(1989, 09, 28);
            alunoCadastrado.Endereco = "Rua 1";
            alunoCadastrado.CPF = "000.000.000-00";
            alunoCadastrado.Telefone = "64 992735930";

            alunosCadastrado.Add(alunoCadastrado);


            alunoCadastrado.Nome = "Ricardo";
            alunoCadastrado.DataNascimento = new DateTime(1989, 09, 29);
            alunoCadastrado.Endereco = "Rua 2";
            alunoCadastrado.CPF = "000.000.000-01";
            alunoCadastrado.Telefone = "64 992735930";

            alunosCadastrado.Add(alunoCadastrado);


            alunoCadastrado.Nome = "Marcia";
            alunoCadastrado.DataNascimento = new DateTime(1989, 09, 30);
            alunoCadastrado.Endereco = "Rua 3";
            alunoCadastrado.CPF = "000.000.000-02";
            alunoCadastrado.Telefone = "64 992735930";

            alunosCadastrado.Add(alunoCadastrado);


            alunoCadastrado.Nome = "Angela";
            alunoCadastrado.DataNascimento = new DateTime(1989, 09, 31);
            alunoCadastrado.Endereco = "Rua 4";
            alunoCadastrado.CPF = "000.000.000-03";
            alunoCadastrado.Telefone = "64 992735930";

            alunosCadastrado.Add(alunoCadastrado);



        }


        private void lblQuantidadeAlunosCadastrados_Click(object sender, EventArgs e)
        {
            CriarAlunosMockup();
            lblQuantidadeAlunosCadastrados.Text = alunosCadastrado.Count().ToString();
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscaPorCPF.Text != "")
            {
                var AlunosEncontrados = alunosCadastrado.Where(p => p.CPF == txtBuscaPorCPF.Text);

                if (AlunosEncontrados.Any())
                {
                    Aluno AlunoEncontrado = alunosCadastrado.First();
                    CarregaDadosAlunoEncontrado(alunosCadastrado);
                }
            }
        }
    }
}