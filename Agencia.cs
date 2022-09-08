using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Agencia
    {
        public int IDAgencia { set; get; }
        public int QuantidadeFuncionarios { set; get; }
        public List<Funcionario> ListaFuncionarios { set; get; }
        public List<Conta> ListaConta { set; get; } 
       

        public Agencia(int IDAgencia, int QuantidadeFuncionarios)
        {
            this.IDAgencia = IDAgencia;
            this.QuantidadeFuncionarios = QuantidadeFuncionarios;
        }

        public override string ToString()
        {
            return "Agencia: \n" + "ID Agencia: " + IDAgencia + "\nQuantidade Funcionarios: " + QuantidadeFuncionarios;
        }


    }
}
