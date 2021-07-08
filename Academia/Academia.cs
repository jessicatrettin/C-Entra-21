using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    class Academia
    {
        public List<Aluno> Alunos { get; private set; }

        public Academia()
        {
            Alunos = new List<Aluno>();
        }

        public void adicionarAluno(string nome, string cpf, string rg, string cep, string rua, int num, string bairro,
            string cidade, string estado, string telefone)
        {
            var aluno = new Aluno();
            aluno.Nome = nome;
            aluno.CPF = cpf;
            aluno.RG = rg;
            aluno.CEP = cep;
            aluno.Rua = rua;
            aluno.Nº = num;
            aluno.Bairro = bairro;
            aluno.Cidade = cidade;
            aluno.Estado = estado;
            aluno.Telefone = telefone;
            Alunos.Add(aluno);

        }
    }
}
