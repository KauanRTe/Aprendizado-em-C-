using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args){
            // Variáveis
            int numMultiplicar, numMultiplicado, resultado = 0;

            // Método da soma
            void multiplicar(){
                for(int i=1; i <= numMultiplicar; i++){
                    resultado = resultado + numMultiplicado;
                }
            }

            // Main Program

            Console.WriteLine("Qual o número a ser multiplicado? ");
            numMultiplicado = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Por quanto será multiplicado? ");
            numMultiplicar = int.Parse(Console.ReadLine());

            multiplicar();

            Console.WriteLine("O resultado da multiplicação é: " + resultado);

        }
    }
}