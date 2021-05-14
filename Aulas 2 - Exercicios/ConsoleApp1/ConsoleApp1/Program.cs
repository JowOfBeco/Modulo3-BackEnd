using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int qtdAlunos = 0;
            string[] alunos = new string[qtdAlunos];
            int[] notas = new int[qtdAlunos];
            int[] faltas = new int[qtdAlunos];
            while (opcao != 99)
            {
                Console.WriteLine("Selecione uma das opções a baixo:");
                Console.WriteLine("Digite 1 para cadastrar uma turma.");
                Console.WriteLine("Digite 2 para cadastrar alunos.");
                Console.WriteLine("Digite 3 para visualizar alunos cadastrados.");
                Console.WriteLine("Digite 4 para acrescentar notas aos alunos.");
                Console.WriteLine("Digite 5 para adicionar falta a um aluno.");
                Console.WriteLine("Digite 6 para remover um aluno.");
                Console.WriteLine("Digite 7 para ordenar por nota.");
                Console.WriteLine("Digite 7 para ordenar por ordem alfabética.");
                Console.WriteLine("Digite 99 para sair.");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Vamos iniciar uma turma, digite o nome desta turma:");
                        string nomeTurma = Console.ReadLine();
                        Console.WriteLine("Agora informe a quantidade de alunos: ");
                        qtdAlunos = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{nomeTurma}, máximo de {qtdAlunos}, foi criada com sucesso.");
                        Console.ReadKey();
                        alunos = new string[qtdAlunos];
                        notas = new int[qtdAlunos];
                        faltas = new int[qtdAlunos];
                        Console.Clear();
                        break;
                    case 2:
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            int x = qtdAlunos;
                            Console.WriteLine($"Você pode cadastrar {x} alunos. ");
                            alunos[i] = Console.ReadLine();
                            x--;
                        }
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Digite [N] para ordernar por notas ou [A] por ordem alfabética.");
                        var valida = Console.ReadLine();

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            Console.WriteLine($"{i} : {alunos[i]}, nota: {notas[i]}, faltas: {faltas[i]}");
                            if(notas[i] < 7 || faltas[i] >= 4){
                                Console.WriteLine("Aluno reprovado, vide faltas e notas a cima.");
                                Console.ReadKey();
                            }

                        }

                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Digite o nome do aluno para adcionar nota.");
                        string alunoNome = Console.ReadLine();
                        for (int i = 0; i < alunos.Length; i++ )
                        {
                            if(alunos[i] == alunoNome)
                            {
                                Console.WriteLine($"Digite a nota para adcionar ao Aluno: {alunos[i]} Matricula: {i} :");
                                int validaNota = int.Parse(Console.ReadLine());
                                if(validaNota > 0 && validaNota <= 10)
                                {
                                    notas[i] = validaNota;
                                    Console.WriteLine($"{i}: {alunos[i]} - nota : {notas[i]} cadastrada");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Nota incorreta digitada.");
                                    Console.ReadKey();
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Digite o nome do aluno para adicionar falta.");
                        alunoNome = Console.ReadLine();
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (alunos[i] == alunoNome)
                            {
                                faltas[i]++;
                                Console.WriteLine($"Aluno: {alunos[i]} Matricula: {i} : está com {faltas[i]} faltas.");
                                Console.ReadKey();

                            }
                        }
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("Digite o nome do aluno para ser excluído.");
                        alunoNome = Console.ReadLine();
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (alunos[i] == alunoNome)
                            {
                                alunos[i] = null;
                                notas[i] = 0;
                                faltas[i] = 0;
                                Console.WriteLine($"Aluno excluido da matricula: {i}");
                            }
                        }
                        break;
                }
            }
        }
    }
}
