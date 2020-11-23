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


            double[] notaaluno0 = new double [4];
            double[] notaaluno1 = new double [4];
            double[] notaaluno2 = new double [4];
            double[] notaaluno3 = new double [4];
            double[] notaaluno4 = new double [4];
            double[] notaaluno5 = new double [4];
            double[] notaaluno6 = new double [4];
            double[] notaaluno7 = new double [4];
            double[] notaaluno8 = new double [4];
            double[] notaaluno9 = new double [4];


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
            notaaluno0 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno0 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno0 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno0 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[1]} ");
            Console.Write("1º Bimestre: ");
            notaaluno1 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno1 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno1 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno1 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[2]} ");
            Console.Write("1º Bimestre: ");
            notaaluno2 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno2 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno2 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno2 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[3]} ");
            Console.Write("1º Bimestre: ");
            notaaluno3 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno3 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno3 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno3 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[4]} ");
            Console.Write("1º Bimestre: ");
            notaaluno4 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno4 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno4 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno4 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[5]} ");
            Console.Write("1º Bimestre: ");
            notaaluno5 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno5 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno5 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno5 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[6]} ");
            Console.Write("1º Bimestre: ");
            notaaluno6 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno6 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno6 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno6 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[7]} ");
            Console.Write("1º Bimestre: ");
            notaaluno7 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno7 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno7 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno7 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[8]} ");
            Console.Write("1º Bimestre: ");
            notaaluno8 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno8 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno8 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno8 [3] = Double.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Otimo, Agora insira as notas dos seguintes bimestres decorrente do aluno: { alunos[9]} ");
            Console.Write("1º Bimestre: ");
            notaaluno9 [0] = Double.Parse ( Console.ReadLine() );
            Console.Write("2º Bimestre: ");
            notaaluno9 [1] = Double.Parse( Console.ReadLine() );
            Console.Write("3º Bimestre: ");
            notaaluno9 [2] = Double.Parse( Console.ReadLine() );
            Console.Write("4º Bimestre: ");
            notaaluno9 [3] = Double.Parse( Console.ReadLine() );

            Console.WriteLine("Otimo, com base nessas informacoes, as medias dos aluno sera a seguinte: ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("                            Medias:                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------");
        
            Double mediaaluno0 = (notaaluno0[0]+notaaluno0[1]+notaaluno0[2]+notaaluno0[3]) / 4;
            Double mediaaluno1 = (notaaluno1[0]+notaaluno1[1]+notaaluno1[2]+notaaluno1[3]) / 4;
            Double mediaaluno2 = (notaaluno2[0]+notaaluno2[1]+notaaluno2[2]+notaaluno2[3]) / 4;
            Double mediaaluno3 = (notaaluno3[0]+notaaluno3[1]+notaaluno3[2]+notaaluno3[3]) / 4;
            Double mediaaluno4 = (notaaluno4[0]+notaaluno4[1]+notaaluno4[2]+notaaluno4[3]) / 4;
            Double mediaaluno5 = (notaaluno5[0]+notaaluno5[1]+notaaluno5[2]+notaaluno5[3]) / 4;
            Double mediaaluno6 = (notaaluno6[0]+notaaluno6[1]+notaaluno6[2]+notaaluno6[3]) / 4;
            Double mediaaluno7 = (notaaluno7[0]+notaaluno7[1]+notaaluno7[2]+notaaluno7[3]) / 4;
            Double mediaaluno8 = (notaaluno8[0]+notaaluno8[1]+notaaluno8[2]+notaaluno8[3]) / 4;
            Double mediaaluno9 = (notaaluno9[0]+notaaluno9[1]+notaaluno9[2]+notaaluno9[3]) / 4;

            Console.Write($"{alunos[0]} : ");
                Console.WriteLine( (notaaluno0[0]+notaaluno0[1]+notaaluno0[2]+notaaluno0[3]) / 4);
                if(mediaaluno0 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[1]} : ");
                Console.WriteLine( (notaaluno1[0]+notaaluno1[1]+notaaluno1[2]+notaaluno1[3]) / 4);
                if(mediaaluno1 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[2]} : ");
                Console.WriteLine( (notaaluno2[0]+notaaluno2[1]+notaaluno2[2]+notaaluno2[3]) / 4);
                if(mediaaluno2 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[3]} : ");
                Console.WriteLine( (notaaluno3[0]+notaaluno3[1]+notaaluno3[2]+notaaluno3[3]) / 4);
                if(mediaaluno3 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[4]} : ");
                Console.WriteLine( (notaaluno4[0]+notaaluno4[1]+notaaluno4[2]+notaaluno4[3]) / 4);
                if(mediaaluno4 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[5]} : ");
                Console.WriteLine( (notaaluno5[0]+notaaluno5[1]+notaaluno5[2]+notaaluno5[3]) / 4);
                if(mediaaluno5 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[6]} : ");
                Console.WriteLine( (notaaluno6[0]+notaaluno6[1]+notaaluno6[2]+notaaluno6[3]) / 4);
                if(mediaaluno6 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[7]} : ");
                Console.WriteLine( (notaaluno7[0]+notaaluno7[1]+notaaluno7[2]+notaaluno7[3]) / 4);
                if(mediaaluno7 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[8]} : ");
                Console.WriteLine( (notaaluno8[0]+notaaluno8[1]+notaaluno8[2]+notaaluno8[3]) / 4);
                if(mediaaluno8 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                        
            Console.Write($"{alunos[9]} : ");
                Console.WriteLine( (notaaluno9[0]+notaaluno9[1]+notaaluno9[2]+notaaluno9[3]) / 4);
                if(mediaaluno9 >= 6){
                    Console.WriteLine("APROVADO\n");
                }else{
                    Console.WriteLine("REPROVADO\n");
                }
                Double mediasala = (mediaaluno0+mediaaluno1+mediaaluno2+mediaaluno3+mediaaluno4+mediaaluno5+mediaaluno6+mediaaluno7+mediaaluno8+mediaaluno9) / 10;
                Console.WriteLine($"Media da Sala: {mediasala}");
        

            }

        }
    }

