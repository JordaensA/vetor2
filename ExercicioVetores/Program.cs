using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudade[] vect = new Estudade[10];

            Console.WriteLine("Entre com o numero dos quartos:  ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int qtd = int.Parse(Console.ReadLine());
                vect[qtd] = new Estudade(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i+ ": "+ vect[i]);
                }
            }


        }
    }
}

            





        
    

