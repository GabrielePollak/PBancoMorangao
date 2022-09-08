using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PBanco_Morangao
{
    internal class Pessoa
    {
        
        public string Nome { get; set; }
        public DateTime DataNasc_Registro { get; set; }
        public float FaturamentoMensal { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Endereco endereco { get; set; }


        public Pessoa(string Nome, DateTime DataNasc, float FaturamentoMensal, string Cpf, string Rg)
        {

            this.Nome = Nome;
            this.DataNasc_Registro = DataNasc;
            this.FaturamentoMensal = FaturamentoMensal;
            this.CPF = Cpf;
            this.RG = Rg;
        }

        public override string ToString()
        {
            return "\nNome" + Nome + "\nDataNasc" + DataNasc_Registro + "\nFaturamento Mensal:" + FaturamentoMensal + "\nCPF:" + CPF + "\nRG:" + RG;



        }
    }
}
