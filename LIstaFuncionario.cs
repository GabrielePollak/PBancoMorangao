using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBanco_Morangao
{
    internal class ListaFuncionario
    {
        public Funcionario HEAD { get; set; }
        public Funcionario TAIL { get; set; }

        public ListaFuncionario()
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

      

        public void Push(Funcionario aux)
        {
        

            
            if (Vazia())
            {
                this.HEAD = this.TAIL = aux;
            }
            else
            {
                
                if (aux.IdFuncionario.CompareTo(TAIL.IdFuncionario) >= 0)
                {
                    TAIL.Proximo = aux; 
                    TAIL = aux; 
                }
                else
                {   
                    if (aux.IdFuncionario.CompareTo(HEAD.IdFuncionario) < 0)
                    {
                        aux.Proximo = HEAD; 
                        HEAD = aux; 
                    }
                    else 
                    {
                        Funcionario aux1, aux2;
                        aux1 = this.HEAD;
                        aux2 = this.HEAD;

                        do
                        {
                            if (aux.IdFuncionario.CompareTo(aux1.IdFuncionario) >= 0)
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
                Funcionario auxiliar = HEAD;
                do
                {
                    contador++;
                    auxiliar = auxiliar.Proximo;

                } while (auxiliar != null);

            }
            Console.ReadKey();
        }


        //Localizando 
        public bool Find(string idfuncionario)
        {
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {


                Funcionario auxiliar = HEAD;

                do
                {
                    if (auxiliar.IdFuncionario == idfuncionario)
                    {


                        return true;
                    }
                    auxiliar = auxiliar.Proximo;
                } while (auxiliar != null);

                Console.Clear();
                Console.WriteLine("\nFuncionario portador do ID [" + idfuncionario + "] não existente.");
            }
            return false;











        }
    }
}
