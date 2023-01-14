using System;

namespace Exercicio5{

    public class Equacao
    {
        public int numero = 0;
        public int potencia = 0;
        public int resultado = 0;

        public void EquacaoExponencial(){
            Console.WriteLine("Qual o número a ser potencializado?");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a potência?");
            potencia = int.Parse(Console.ReadLine());

            resultado = numero;

            for(int i=1; i < potencia; i++){
                resultado = resultado * numero;
            }

        }

        }
       class Program
        {
        static void Main(string[] args){

            // Main Program
            Equacao equacao = new Equacao();

            equacao.EquacaoExponencial();

            Console.WriteLine("O resultado da equação é: " + equacao.resultado);

        }
    }
}
