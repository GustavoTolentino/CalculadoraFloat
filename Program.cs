using System;

namespace Calculadora_Float
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Bem Vindo ao Sistema de Avaliação Escolar");
            Console.WriteLine("PorFavor, para comecar a avaliação de rendimento, Para acessar, se identifique...");
            Console.WriteLine("---------------------------------------------------------------------------------");           
            Console.Write("Login: ");
            Console.ReadLine();
            Console.Write("Senha: ");
            Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo.");

            string[] alunos = new string [10] {"Aluno1", "Aluno2", "Aluno3", "Aluno4", "Aluno5", "Aluno6", "Aluno7", "Aluno8", "Aluno9", "Aluno10"};
            Console.WriteLine("Agora ensira o Nome do Primeiro aluno");

            int[] notaaluno0 = new int [4];
            int[] notaaluno1 = new int [4];
            int[] notaaluno2 = new int [4];
            int[] notaaluno3 = new int [4];
            int[] notaaluno4 = new int [4];
            int[] notaaluno5 = new int [4];
            int[] notaaluno6 = new int [4];
            int[] notaaluno7 = new int [4];
            int[] notaaluno8 = new int [4];
            int[] notaaluno9 = new int [4];

             


            alunos [0] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Segundo aluno");
            alunos [1] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Terceiro aluno");
            alunos [2] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Quarto aluno");
            alunos [3] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Quinto aluno");
            alunos [4] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Sexto aluno");
            alunos [5] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Setimo aluno");
            alunos [6] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Oitavo aluno");
            alunos [7] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Nono aluno");
            alunos [8] = Console.ReadLine();
            Console.WriteLine("Agora ensira o Nome do Decimo aluno");
            alunos [9] = Console.ReadLine();

            Console.WriteLine($"O nome dos alunos que terao suas notas avaliadas sera: { alunos[0] }, { alunos[1] }, { alunos[2] }, { alunos[3] }, { alunos[4] }, { alunos[5] }, { alunos[6] }, { alunos[7] }, { alunos[8] }, { alunos[9] }.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
           
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[0]} ");
            Console.Write("1º Bimestre: ");
            Console.ReadLine();
            Console.Write("2º Bimestre: ");
            Console.ReadLine();
            Console.Write("3º Bimestre: ");
            Console.ReadLine();
            Console.Write("4º Bimestre: ");
            Console.ReadLine();
            Console.WriteLine($"As notas de { alunos[0] } serão as seguintes:");

        }

        }
    }

