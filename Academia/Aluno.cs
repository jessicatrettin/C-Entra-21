using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    public class Aluno : Pessoa
    {
        public string Turma { get; set; }
        public bool Pago { get; set; }
        
        public Aluno(string turma, bool pago)
        {
            Turma = turma;
            Pago = pago;
        }

        public Aluno()
        {
        }

        public void pagamento(string pago)
        {
            pago = "SIM";
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
