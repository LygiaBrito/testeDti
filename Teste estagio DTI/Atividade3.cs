using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_estagio_DTI
{
    class Atividade3
    {
        //3) Crie um algoritmo para calcular o fatorial de um número natural n.
        public void calculoFatorial()
        {
            int Fatorial=0;
            Console.WriteLine("Digite o numero a ser calculado: ");
            string Numero = Console.ReadLine();
            
            for (int i = int.Parse(Numero) ; i != 1; i--)
            {
                if(Fatorial == 0)
                {
                    Fatorial = i;
                }
                else
                {
                    Fatorial *=i;
                }

            }

            Console.WriteLine($"O Fatorial do numero digitado é {Fatorial}");
        }
    }
}
