using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args){

            // Vetor e Variáveis
            int[] vetor = {5, 20, 4, 7, 9, 3};
            int somatoriaVetor = 0;
            int mediaVetor = 0;

            // Métodos
            void somatoria(){
                for(int i=0; i < vetor.Length; i++){
                    somatoriaVetor = somatoriaVetor + vetor[i];
                }
            }

            somatoria();

            void media(){
                mediaVetor = somatoriaVetor / vetor.Length;
            }
            
            media();

            //Função Principal
            Console.WriteLine("A somatória do vetor é: " + somatoriaVetor);
            Console.WriteLine("A média do vetor é: " + mediaVetor);
            Console.ReadKey();
           

        }
    }
}