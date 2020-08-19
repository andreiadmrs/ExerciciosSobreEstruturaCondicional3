using System;

namespace ExerciciosSobreEstruturaCondicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente.*/

            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            int n2 = int.Parse(Console.ReadLine());

            if (n1>n2 && n1%n2==0 || n2 > n1 && n2 % n1 == 0)
            {
                Console.WriteLine("São multiplos.");
            }
            else
            {
                Console.WriteLine("Não são multiplos.");
            }
            
        }
    }
}
