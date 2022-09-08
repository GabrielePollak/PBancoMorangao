using System;

namespace PBanco_Morangao
{
    public class Cliente
    {

        public string Nome { get; set; }
        public DateTime DataNasc_Registro { get; set; }
        public double FaturamentoMensal { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string TipoConta { get; set; }
        public string InstituiçãoEnsino { get; set; }
        public int NumeroMatricula { get; set; }
        public int Senha { get; set; }
        public Endereco endereco { get; set; }

        public Cliente Proximo { get; set; }

        public Cliente Aprovado { get; set; }



        public Cliente(string Nome, DateTime DataNasc, float FaturamentoMensal, string Cpf, string Rg, string email, string TipoConta, string InstituiçãoEnsino, int NumeroMatricula, int Senha, Endereco endereco)
        {

            this.Nome = Nome;
            this.DataNasc_Registro = DataNasc;
            this.FaturamentoMensal = FaturamentoMensal;
            this.CPF = Cpf;
            this.RG = Rg;
            this.Email = email;
            this.TipoConta = TipoConta;
            this.InstituiçãoEnsino = InstituiçãoEnsino;
            this.NumeroMatricula = NumeroMatricula;
            this.Senha = Senha;
            this.endereco = endereco;
        }

        public override string ToString()
        {
            return "\nNome" + Nome + "\nDataNasc" + DataNasc_Registro + "\nFaturamento Mensal:" + FaturamentoMensal + "\nCPF:" + CPF + "\nRG:" + RG;



        }
    }
}