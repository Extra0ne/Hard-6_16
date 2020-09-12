using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите число столбцов: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();
            Filling_rnd(mas);
            Sort(mas);
            Console.WriteLine();
            Print(mas);
            Console.ReadKey();

        }
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }
        }

        static void Filling_rnd(int[,] mas)
        {

            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(1, 15);
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Sort(int[,] mas)
        {

            int i, j, k;
            int result;

            for (i = 0; i < mas.GetLength(0); i++)
            {

                for (j = 0; j < mas.GetLength(1); j++)
                {
                    result = mas[i, j];

                    for (k = j - 1; k >= 0 && mas[i, k] > result; k--)
                        mas[i, k + 1] = mas[i, k];

                    result = mas[i, k + 1];
                }
            }

        }
    }
}
           