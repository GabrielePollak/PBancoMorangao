using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Funcionario
    {
        public string IdFuncionario { get; set; }
      
        public int SenhaFuncionario { get; set; }
        public Funcionario Proximo { get; set; }


        public Funcionario(string IdFuncionario, int SenhaFncionario)
        {
            this.IdFuncionario = IdFuncionario;
           
            this.SenhaFuncionario = SenhaFuncionario;
        }

        public override string ToString()
        {
            return "Funcionario: \n" + "IdFuncionario: " + IdFuncionario + "\nSenhaFuncionario: " + SenhaFuncionario;

        }


    }
}
