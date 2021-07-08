using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public int Nº { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string cpf, string rg, string cep, string rua, int num, string bairro, 
            string cidade, string estado, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            CEP = cep;
            Rua = rua;
            Nº = num;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
        }

        public Pessoa()
        {

        }
    }
}
