using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class Endereco
    {

        public string Rua { set; get; }
        public int Numero { set; get; }
        public string Bairro { set; get; }
        public string Complemento { set; get; }
        public string Cidade { set; get; }
        public string Estado { set; get; }





        public Endereco(string Rua, int Numero, string Bairro, string complemento, string Cidade, string Estado  )
        {
            this.Rua = Rua;
            this.Numero = Numero;
            this.Bairro = Bairro;
            this.Complemento = Complemento;
            this.Cidade = Cidade;
            this.Estado = Estado;
        }

        public override string ToString()
        {
            return "Endereco: \n" + "Rua: " + Rua + "\nNumero: " + Numero + "\nCidade: " + Cidade + "\nEstado" + Estado;
        }





    }
}
