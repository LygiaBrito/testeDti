using System;

namespace Teste_estagio_DTI
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Bem vindo ao Teste da DTI =)");
                Console.WriteLine("Por favor escolha qual teste deseja ver:");
                Console.WriteLine("1 - Números Pares");
                Console.WriteLine("2 - Média de Notas da Sala");
                Console.WriteLine("3 - Fatorial ( esse deu trabalho ) ");
                Console.WriteLine("0 - Sair");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Atividade1 Numero1 = new Atividade1();
                        Console.WriteLine("Digite o numero inteiro a ser verificado: ");
                        string numero = Console.ReadLine();
                        try
                        {
                            Numero1.N1(int.Parse(numero));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Gentileza digitar um numero inteiro.");
                        }
                        break;
                    case "2":
                        Atividade2 Media = new Atividade2();

                        Media.Sala();
                        break;
                    case "3":
                        Atividade3 Calculo = new Atividade3();
                        Calculo.calculoFatorial();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Por favor digite um número válido");
                        break;
                }
            }
        }
    }
}
