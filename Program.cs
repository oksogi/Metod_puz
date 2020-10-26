using System;

namespace Metod_puz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            // ввод чисел
            int[] M = new int[100];
            Console.Write(" Неотсортированный массив:");
            for (int i = 0; i < 100; i++)
            { 
              
                M[i] = rnd.Next(0, 100);

                Console.WriteLine(M[i]) ;
            }
                
                // сортировка
                int c;
                for (int i = 0; i < M.Length - 1; i++)
                {
                    for (int j = i + 1; j < M.Length; j++)
                    {
                        if (M[i] > M[j])
                        {
                            c = M[i];
                        M[i] = M[j];
                        M[j] = c;
                        }
                    }
                }

               
                Console.WriteLine(" Отсортированный массив: ");
                for (int i = 0; i < M.Length; i++)
                {
                    Console.WriteLine(M[i]);
                }
                Console.ReadLine();
            }
        }
}

