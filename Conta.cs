using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Conta
    {
        public int IdAgencia { get; set; }
        public int IdConta { get; set; }
        public int Senha { get; set; }
        public float Saldo { get; set; }
        

        public Conta(int IdAgencia, int IdConta, int Senha, float Saldo)
        {

            this.IdAgencia = IdAgencia;
            this.IdConta = IdConta;
            this.Senha = Senha;
            this.Saldo = Saldo;
            
        }

        public override string ToString()
        {
            return "\nIdAgencia: " + IdAgencia + "\nIdConta: " + IdConta + "\nSenha: " + Senha + "\nSaldo: " + Saldo;



        }






    }
}
