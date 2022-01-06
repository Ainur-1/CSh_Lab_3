using System;

namespace CSh_Lab_3
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //Ex_1();
            //Ex_2();
            Ex_3();
        }

        static void Ex_1()
        {
            int n = 10;
            double s1 = 0, s = 0;
            double[] mas = new double[n];
            
            // Заполнение массива
            for (int i = 0; i < n; i++) mas[i] = Math.Round(rnd.NextDouble() * rnd.Next(-100, 100), 2);

            // Вывод массива 
            for (int i = 0; i < n; i++) Console.Write("{0}: {1,4} | ", i, mas[i]);

            // Вычисление суммы нечётных элементов
            for (int i = 1; i < n; i += 2) s += mas[i];
            Console.WriteLine();
            Console.WriteLine("s = {0}", Math.Round(s, 2));

            // Нахождение крайних отрицательных чисел
            int left = n, right = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 0 & left > i) left = i;
                if (mas[i] < 0 & right < i) right = i;
            }

            // Вычисление суммы элементов между первым и последним отрицательным числом
            for (int i = left; i <= right; i++) s1 += mas[i];
            Console.WriteLine("s1 = {0}", Math.Round(s1, 2));
        }
        static void Ex_2()
        {
            int n = 4;
            int[,] sqmas = new int[n, n];

            //Заполнение матрицы
            for(int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    sqmas[i, k] = rnd.Next(-10, 20);
                }
            }

            //Вывод матрицы
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0,3} ", sqmas[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Определение произведение элементов в тех строках, которые не содержат отрицательных элементов.
            long s = 1;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (sqmas[i, k] < 0) flag = true;
                    s *= sqmas[i, k];
                }
                if (flag == false) Console.WriteLine("В строке {0} произведение равно {1}", i, s);
                flag = false;
            }

            //Меняем 1 и 2 столбцы местами
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = sqmas[i, 0];
                sqmas[i, 0] = sqmas[i, 1];
                sqmas[i, 1] = temp[i];
            }

            //Вывод новой матрицы
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0,3} ", sqmas[i, k]);
                }
                Console.WriteLine();
            }
        }
        static void Ex_3()
        {
            int s = 0;
            int[][] m = new int[5][];
            m[0] = new int[5];
            m[1] = new int[3];
            m[2] = new int[8];
            m[3] = new int[4];
            m[4] = new int[6];

            for (int i = 0; i < 5; i++) m[0][i] = rnd.Next(-500, 500);
            for (int i = 0; i < 3; i++) m[1][i] = rnd.Next(-500, 500);
            for (int i = 0; i < 8; i++) m[2][i] = rnd.Next(-500, 500);
            for (int i = 0; i < 4; i++) m[3][i] = rnd.Next(-500, 500);
            for (int i = 0; i < 6; i++) m[4][i] = rnd.Next(-500, 500);

            for (int i = 0; i < 8; i++) Console.Write("{0,5} |", i + 1);
            Console.Write(" Summ");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,5} |", m[0][i]);
                s += m[0][i];
            }
            Console.WriteLine(" {0,25} ", s);
            s = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0,5} |", m[1][i]);
                s += m[1][i];
            }
            Console.WriteLine(" {0,39} ", s);
            s = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0,5} |", m[2][i]);
                s += m[2][i];
            }
            Console.WriteLine(" {0,4} ", s);
            s = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0,5} |", m[3][i]);
                s += m[3][i];
            }
            Console.WriteLine(" {0,32} ", s);
            s = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0,5} |", m[4][i]);
                s += m[4][i];
            }
            Console.WriteLine(" {0,18} ", s);
        }
    }
}
