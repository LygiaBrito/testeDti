using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_estagio_DTI
{
    class Atividade2
    {
        //Crie um algoritmo que receba a nota de 20 alunos de uma classe, e que
        //calcule a média das notas da sala.
        public void Sala()
        {
            float Notas = 0;

            for (int i =0; i < 20; i++)
            {
                Console.WriteLine($"Insira a nota a nota do aluno {i+1}");
                string nota = Console.ReadLine();
                 Notas += float.Parse(nota);

            }
            Console.WriteLine($"A media das notas da sala é: {Notas / 20}");
        }

    }

}
