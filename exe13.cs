using System;

    class exe13{
        static void Main(string[] args){
            int n;

            Console.WriteLine("Digite o Tamanho do Vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            double soma = 0;

            for(int i = 0; i<n; i++){
                Console.WriteLine("digite os valores");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
                soma = soma + Math.Sqrt(vetor[i]);
            }

            double media = soma/n;

            Console.WriteLine("media da raiz quadrada" +media);
        }
    }
