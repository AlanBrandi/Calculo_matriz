using System;

namespace Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedindo o valor para criar a matriz quadrada
            Console.WriteLine("Digite o valor de N, onde N é igual ao número de linhas e colunas.");
            int n = int.Parse(Console.ReadLine());

            //Criando a matriz utilizando o N.
            int[,] mat = new int[n, n];
            //Computando os valores dentro da matriz que o usuário adicionar.
            Console.WriteLine("Digite os valores da primeira linha: Ex.: 10 5 -20");
            for (int i = 0; i < n; i++)
            {
                //Criando uma array para guardar os valores.
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    //adicionando os valores em seus lugares corretamente.
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
        
            for(int i = 0; i < n; i++)
            {
                //Pegando a diagonal e mostrando a mesma.
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();

            //Criando uma variável para contar quantos números negativos possuem.
            int count = 0;
            //passando por todas as posições
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    //se algum valor for menor que zero adicione um no contador.
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            //Mostrando o contador.
            Console.WriteLine("Valores negativos: " + count);
        }
    }
}
