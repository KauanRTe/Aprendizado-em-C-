using System;

namespace Exercicio1
{
    class Program{
        static void Main(string[] args){

            // Variáveis usadas

            string Nome;
            int Idade;
            int maior = 0;

            // Método verificar
            
             void verificar(){
                if(Idade >= 18){
                maior++;
                }
             }

             // Função principal
             
            Console.WriteLine("Quantos alunos deseja registrar?");
            int Qtd = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = 1; i <= Qtd; i++){
                Console.WriteLine("Digite o nome do aluno " + i + ":");
                Nome = Console.ReadLine();
                Console.WriteLine("~");

                Console.WriteLine("Digite a idade do aluno " + i + ":");
                Idade = int.Parse(Console.ReadLine());   
                verificar();
                Console.Clear();
             }

             Console.WriteLine("Há " + maior + " aluno(s) maior(es) de idade.");

            }
        }
    }
