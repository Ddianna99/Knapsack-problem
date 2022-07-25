using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagProb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cantitate = new int[] {0, 1, 3, 4, 5 };
            int[] value = new int[] {0, 1, 4, 5, 7 };
            int[,] matrice = new int[5, 8];
            List<int> bag = new List<int>();
            int capacitate = 7;
            for (int i=0; i <= 4; i++)
            {
                for(int j=0; j<= 7; j++)
                {
                    matrice[0, 0] = 0;
                    if (cantitate[i] > j)
                    {
                        matrice[i, j] = matrice[i - 1, j];
                    }
                    else if ((i != 0) && (j != 0))
                    {
                        matrice[i, j] = Math.Max(value[i] + matrice[i - 1, j - cantitate[i]], matrice[i - 1, j]);
                    }
                    Console.WriteLine(matrice[i, j]);
                    Console.ReadLine();
                }
            }
            for(int i=4; i>0; i--)
            {
                for(int j=7; j >0; j--)
                {
                    if((matrice[i,j] != matrice[i - 1, j])&&(capacitate>0))
                    {
                        bag.Add(cantitate[i]);
                        capacitate = capacitate - cantitate[i];
                    }
                    break;
                }
            }
            Console.WriteLine("Continutul rucsacului va fi: ");
            Console.ReadLine();
            foreach (int element in bag)
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }

        }
    }
}
