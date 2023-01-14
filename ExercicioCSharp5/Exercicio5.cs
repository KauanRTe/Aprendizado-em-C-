using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5{
    public class Produto
    {
        int[] id = new int[10];
        int[] tamanho = new int [64];
        double[] preco = new double[64];

        
        public void registrarProduto(){
            Console.WriteLine("Quantos produtos deseja registrar?");
            int qtdProduto = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = 0; i < qtdProduto; i++){
                Console.WriteLine("Digite o ID do produto: ");
                id[i] = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite o tamanho(cm) do produto: ");
                tamanho[i] = int.Parse(Console.ReadLine()); 
                Console.Clear();

                Console.WriteLine("Digite o preço do produto: ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                if(tamanho[i] > 10){
                    preco[i] = preco[i] * 1.20;
                    Console.WriteLine("Este produto teve acréscimo de 20% ao seu preço, devido ao tamanho.");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte qualquer botão para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Produtos registrados com sucesso!");
        }

        public void mostrarProduto(){
            for(int i = 0; i < id.Length; i++){
                if(id[i] != 0){                
                    Console.WriteLine("ID do Produto: " + id[i] + " / " + "Preço do Produto: R$" + preco[i] + " / " + "Tamanho do Produto: " + tamanho[i] + "cm");
                }
            }
        }

        public void verificarTamanho(){
            for(int i = 0; i < tamanho.Length; i++){
                if(tamanho[i] != 0){
                    if(tamanho[i] < 10){
                        Console.WriteLine("O produto de ID [" + id[i] + "] é menor que 10cm.");
                    }
                }
            }
        }
    }
    class Program{
        static void Main(string[] args){
            // Variáveis
            int acaoEscolhida = 0;
            Produto produtos = new Produto();
            int auxMenu = 0;

            //ENQUANTO FOR TRUE, O MENU VOLTARÁ A APARECER.

            while(auxMenu == 0){
                Console.Clear();
                Console.WriteLine("                 Controle de Inventário                   ");
                Console.WriteLine();
                Console.WriteLine("==========================================================");
                Console.WriteLine();
                Console.WriteLine("[1] Registrar produto");
                Console.WriteLine();
                Console.WriteLine("[2] Listar produtos");
                Console.WriteLine();
                Console.WriteLine("[3] Listar produtos menores que 10cm de tamanho");
                Console.WriteLine();
                Console.WriteLine("[4] Encerrar programa");
                Console.WriteLine();

                Console.WriteLine("Digite o número da ação que deseja fazer");
                acaoEscolhida = int.Parse(Console.ReadLine());
                Console.Clear();

                if(acaoEscolhida == 1){
                    produtos.registrarProduto();
                    voltarMenu();
                }

                else if(acaoEscolhida == 2){
                    produtos.mostrarProduto();
                    Console.WriteLine();
                    voltarMenu();
                }

                else if(acaoEscolhida == 3){
                    produtos.verificarTamanho();
                    Console.WriteLine();
                    voltarMenu();
                }
                else if(acaoEscolhida == 4){auxMenu++;}
                
            }

            // Método voltar para o Menu
            void voltarMenu(){
                Console.WriteLine("Aperte qualquer botão para voltar ao menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

