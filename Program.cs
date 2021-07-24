using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes_e_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int[] vetor = new int[5];
            int[,] matriz = new int[3, 3];

            Console.WriteLine("Mostra o vetor: ");
            do
            {
                Console.Write(vetor[contador] = contador);
                Console.Write(" ");
                contador++;

            } while (contador <= 4);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Mostra a matriz: ");

            contador = 0;
            int contador2 = 1;
            do
            {
                Console.Write(matriz[0, contador] = contador2);
                Console.Write(" ");
                contador++;
                contador2++;

                if(contador == 3)
                {
                    contador = 0;
                    Console.WriteLine("\n");
                }


            } while (contador2 <= 9);




            Console.ReadKey();

        }
    }
}
