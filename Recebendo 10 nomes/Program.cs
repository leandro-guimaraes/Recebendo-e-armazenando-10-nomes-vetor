using System;

namespace Recebendo_10_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] nomes = new string[10];

            for( int i = 0;i < 10;i++ )
            {
                Console.WriteLine("Digite um nome:  ");
                nomes[i] = Console.ReadLine();
                Console.Clear();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nome armazenado  "+ nomes[i]);
            }


        }
    }
}


