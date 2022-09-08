using System;

namespace PBanco_Morangao
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ListaCliente Minhalista = new ListaCliente();
            ListaFuncionario Minhalista1 = new ListaFuncionario();
            Minhalista.Push(new Cliente("Gabriele", new DateTime(2004, 08, 01), 1.200, "423.436.048-19", "60.499.619-19", "gabrielepollak@outlook.com", "Universitariia", "Colegio Sla", 12345, 1234, null));
            Minhalista1.Push(new Funcionario("4252", 1234));

            int opc;



            Console.WriteLine("\n\n                                  <<<<<Bem-Vindo ao Banco Morangão!>>>>>                            ");

            do
            {
                Console.Clear();
                Console.WriteLine ("\nOlá, você é clinete ou funcionário?\n\n1-Sou cliente!\n2-Sou colaborador!\n3-Sair!\nOpção: ");
                opc = int.Parse(Console.ReadLine());


                if (opc == 1)
                {
                    do
                    {
                        
                        Console.WriteLine("\nVocê já um cliente Morangão?\n\n1-Sim! Sou cliente\n2-Não mas desejo ser!\nOpcão: ");
                        opc = int.Parse(Console.ReadLine());
                    } while (opc < 1 || opc > 3);

                    if (opc == 1)
                    {


                        Console.Write("\nInforme seu CPF: ");
                        string cpf = Console.ReadLine();

                        if (Minhalista.Find(cpf, true)==null)

                        {
                            
                            opc = -1;
                            continue;

                        }
                        Console.WriteLine("Digite sua senha numérica de 4 digitos: ");
                        int senha = int.Parse(Console.ReadLine());

                        Console.Clear ();
                        Console.WriteLine("Olá! ");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Você deseja: \n1-Sacar\n2-Depositar\n3-Consultar saldo\n4-Sair\nOpção");
                            opc = int.Parse(Console.ReadLine());
                        }while (opc < 1 || opc > 4);

                        if (opc == 1)
                        {
                            Console.WriteLine("Isira o valor que deseja sacar: ");
                            string valordesaque = Console.ReadLine();

                            Console.WriteLine("Valor sacado com sucesso!");
                            //voltar as 4 opções
                        }
                        if (opc == 2)
                        {
                            Console.WriteLine("Insira o valor que deseja depositar: ");
                            string valordedeposito = Console.ReadLine();

                            Console.WriteLine("Valor depositado com sucesso!");
                            //voltar as 4 opc
                        }
                        if (opc == 3)
                        {
                            Console.WriteLine("Seu saldo é de: ");

                            //Voltar as 4 opc
                        }
                        if (opc == 4)
                        {
                            break;
                        }

                        
                    }
                    else
                    {

                        Console.Clear();
                       

                        

                            Console.WriteLine("Antes de se tornar cliente Morangão precisamos de algumas informações: ");
                            Console.WriteLine("Deseja abrir uma conta universitária ou normal?");
                            string tipoConta = Console.ReadLine();
                            Console.WriteLine("\nInforme seu nome completo: ");
                            string Nome = Console.ReadLine();
                            Console.WriteLine("Informe seu CPF utilizando pontuação: ");
                            string Cpf = Console.ReadLine();
                            Console.WriteLine("Informe seu RG utilizando pontuação: ");
                            string Rg = Console.ReadLine();
                            Console.WriteLine("Informe sua data de nascimento: ");
                            DateTime Datanasc = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Informe seu email: ");
                            string email = Console.ReadLine();
                            Console.WriteLine("Informe o nome da instiruição de ensino (escreva [nenhum] em caso de conta normal): ");
                            string instituiçãoEnsino = Console.ReadLine();
                            Console.WriteLine("Informe o núemro da matrícula (escreva [0000] em caso de conta normal): ");
                            int numeroMatricula = int.Parse(Console.ReadLine());
                            Console.WriteLine("Agora vamos cadastrar seu endereço!");
                            Console.WriteLine("Informe o nome da sua rua: ");
                            string rua = Console.ReadLine();
                            Console.WriteLine("Informe o número da sua casa: ");
                            int numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe seu bairro: ");
                            string bairro = Console.ReadLine();
                            Console.WriteLine("Informe seu complemento (apt,bloco,casa) se não houver apenas digite (nenhum)");
                            string complemento = Console.ReadLine();
                            Console.WriteLine("Informe sua cidade: ");
                            string cidade = Console.ReadLine();
                            Console.WriteLine("Informe seu estado: ");
                            string estado = Console.ReadLine();
                            Console.WriteLine("Informe sua renda mensal: ");
                            double FaturamentoMensal = double.Parse(Console.ReadLine());
                            Console.WriteLine("Caso sua conta seja aprovada você precisrá de uma senha. Crie uma senha de acesso de 4 números: ");
                            int senha = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nMuito bem! Dentro de alguns instantes você recebrá um email informando se sua conta foi aprovada!\nO Banco Morangão agradece a preferência!");

                        Endereco endereco = new Endereco(rua, numero, bairro, complemento, cidade, estado);
                            Minhalista.Push(new Cliente(Nome, Datanasc, FaturamentoMensal, Cpf, Rg, email, tipoConta, instituiçãoEnsino , numeroMatricula, senha, endereco ));
                            opc = -1;
                        
                    }
                }

                if (opc == 2)
                {
                    Console.WriteLine("Informe seu Id de funcionario: ");
                    string idFuncionario = (Console.ReadLine());
                    if (!Minhalista1.Find(idFuncionario))

                    {
                        opc = -1;
                        continue;

                    }
                    Console.WriteLine("Informe sua senha: ");
                    int senhaFuncionario = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Minhalista.Print();

                    Console.WriteLine("Informe o CPF da conta que deseja aprovar: ");
                    string Cpf = Console.ReadLine();
                    Cliente clienteaprovado = Minhalista.Find(Cpf, false);
                    Minhalista.pop(clienteaprovado.Nome);
                    clienteaprovado.Aprovado = true;
                    Minhalista.Push(clienteaprovado);
                    Console.WriteLine("\n*****Favor não esquecer de enviar email para o cliente informando a aprovação da conta!");

                    opc = -1;
                }
            } while (opc < 1 || opc > 2);





















            }
    }
}
