using System;

namespace Estudoo
{
   
        struct Aluno
        {
        public int Matricula;
        public string NomeAluno;
        public string DataNascimento;
        }
        class Program
        {
        static void Main(string[] args)
        {
            Aluno[] x = new Aluno[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Matricula do Aluno:");
                x[i].Matricula = int.Parse(Console.ReadLine());

                Console.Write("Nome do Aluno.....:");
                x[i].NomeAluno = Console.ReadLine();

                Console.Write("Data de Nascimento:");
                x[i].DataNascimento = Console.ReadLine();
            }

            Console.Clear();

            foreach (Aluno A in x)
            {
                Console.WriteLine("{0} - {1}", A.Matricula, A.NomeAluno);
                Console.WriteLine("Nasceu em {0}\n", A.DataNascimento);
            }
            Console.ReadKey();
            
        }
    }
}
