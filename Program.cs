using System;

namespace Calculadora_Float
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Bem Vindo ao Sistema de Avaliação Escolar");
            Console.WriteLine("PorFavor, para comecar a avaliação de rendimento, Para acessar, se identifique...");
            Console.WriteLine("---------------------------------------------------------------------------------");           
            Console.Write("Login: ");
            Console.ReadLine();
            Console.Write("Senha: ");
            Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo.");

           // Quantidade de alunos
            string[] alunos = new string [1];
            int iAluno = 0;
          //  i e o numero do aluno atual
            for(int i = 0; i<= iAluno; i++){
                Console.WriteLine($"Agora ensira o Nome do aluno numero {i+1}");
                alunos [i] = Console.ReadLine(); 
               
               // notaaluno = 4 notas do aluno
                Double[] notaaluno = new Double [4];
               // j = numero do bimestre 
                for(int j = 0; j <= 3; j++){
                    Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[i] } ");
                    Console.Write($"{j+1}º Bimestre: ");
                    notaaluno[j] = Double.Parse( Console.ReadLine() ); 
                }
                // Soma as notas digitadas
                double total = 0;
                // k = 
                for(int k = 0; k <= 3 ; k++){

                    total = total + notaaluno[k];
                }
                // Media das notas
                double media = total/4;
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"Otimo, com base nessas informacoes media do aluno(a) { alunos[i] } sera: {media}");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            // Console.WriteLine($"O nome dos alunos que terao suas notas avaliadas sera: { alunos[0] }, { alunos[1] }, { alunos[2] }, { alunos[3] }, { alunos[4] }, { alunos[5] }, { alunos[6] }, { alunos[7] }, { alunos[8] }, { alunos[9] }.");
            // Console.WriteLine("-----------------------------------------------------------------------------------------");
           

            // notaaluno0 [0] = Double.Parse ( Console.ReadLine() );
            // Console.Write("2º Bimestre: ");
            // notaaluno0 [1] = Double.Parse( Console.ReadLine() );
            // Console.Write("3º Bimestre: ");
            // notaaluno0 [2] = Double.Parse( Console.ReadLine() );
            // Console.Write("4º Bimestre: ");
            // notaaluno0 [3] = Double.Parse( Console.ReadLine() );

            

            // // Console.WriteLine($"As notas de { alunos[0] } serão as seguintes: \n 1º Bimestre: { notaaluno0 [0] } \n 2º Bimestre: { notaaluno0 [1] } \n 3º Bimestre: { notaaluno0 [2] } \n 4º Bimestre: { notaaluno0 [3] } ");


        }

        }
    }

