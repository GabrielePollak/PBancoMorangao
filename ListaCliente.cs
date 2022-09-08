using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ListaCliente
    {

        public Cliente HEAD { get; set; }
        public Cliente TAIL { get; set; }

        public ListaCliente()
        {
            HEAD = TAIL = null;
        }

        private bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Nemhum cliente solicitou abertura de conta no momento!");
            }
            else
            {
                Cliente aux = HEAD;
                Console.WriteLine("Lista de pedido de abertura de conta: ");
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO");
            }
            Console.ReadKey();
        }

        public void Push(Cliente aux)
        {
            

           
            if (Vazia())
            {
                this.HEAD = this.TAIL = aux;
            }
            else
            {
                
                if (aux.CPF.CompareTo(TAIL.CPF) >= 0)
                {
                    TAIL.Proximo = aux; 
                    TAIL = aux;
                }
                else
                {   
                    if (aux.CPF.CompareTo(HEAD.CPF) < 0)
                    {
                        aux.Proximo = HEAD; 
                        HEAD = aux; 
                    }
                    else 
                    {
                        Cliente aux1, aux2;
                        aux1 = this.HEAD;
                        aux2 = this.HEAD;
                       
                        do
                        {
                            if (aux.CPF.CompareTo(aux1.CPF) >= 0)
                            {   
                                aux2 = aux1; 
                                aux1 = aux1.Proximo; 
                            }
                            else
                            {
                                
                                aux2.Proximo = aux; 
                                aux.Proximo = aux1; 
                               
                                break;
                            }
                        } while (true);


                    }
                }
            }
        }
      
        public void Length()
        {
            int contador = 0;
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {
                Cliente auxiliar = HEAD;
                do
                {
                    contador++;
                    auxiliar = auxiliar.Proximo;

                } while (auxiliar != null);
               
            }
            Console.ReadKey();
        }

        // fazendo remoção
        public void pop(string clienteRemovido)
        {
            if (Vazia())
                Console.WriteLine("Lista Vazia! Impossivel remover.");
            else
            {
                HEAD = HEAD.Proximo;
                Console.WriteLine("Cliente: " + clienteRemovido + " removido!");
            }
            Console.WriteLine("\nAperte [enter] para continuar.");
            Console.ReadKey();
        }

        //Localizando
        public Cliente Find(string cpf, bool Aprovado)
        
        {
            
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {

                Cliente auxiliar = HEAD;

                do
                {
                    if (auxiliar.CPF == cpf && auxiliar.Aprovado == Aprovado) //deu erro aqui
                    {


                        return auxiliar;
                    }
                    auxiliar = auxiliar.Proximo;
                } while (auxiliar != null);

                Console.Clear();
                Console.WriteLine("\nCliente portador do CPF [" + cpf + "] não existente.");
            }
            return null;











        }
    }
}
