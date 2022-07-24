using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home8
{
    class Program
    {
        static void Main(string[] args)
        {
            void SortAndPrintArray(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)//вывод массива не отсортированного
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine("отсортированный массив :");
                int val = 0;
                for (int i = 0; i < arr.GetLength(0); i++)//сортировка массива
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr.GetLength(1); k++)
                        {
                            if (arr[i, j] < arr[i, k])
                            {
                                val = arr[i, j];
                                arr[i, j] = arr[i, k];
                                arr[i, k] = val;
                            }
                        }
                    }

                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }
            }
            int[,] CreateArray(int st,int col,Random r)
            {
                int[,] MultArray = new int[st, col];
                for(int i=0;i<MultArray.GetLength(0);i++)
                {
                    for (int j = 0; j < MultArray.GetLength(1); j++)
                        MultArray[i, j] = r.Next(0, 20);
                }
                return MultArray ;
            }
            void FindMinSum(int[,] arr,Random ra)
            {
                
                int min = 0, min2 = 0, str = 0;
                for (int i=0;i<arr.GetLength(0);i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = ra.Next(0, 100);
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.GetLength(1); i++)
                    min += arr[0, i];
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    min2 = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                        min2 += arr[i, j];
                    if(min>min2)
                    {
                        min = min2;
                        str = i;
                    }
                }
                Console.WriteLine("\n минимальная сумма элементов в строке номер " + str);
                for (int i = 0; i < arr.GetLength(1); i++)
                    Console.Write(arr[str, i]+"\t");
                Console.WriteLine();
            }
            void PrintArray(int[,] arr)
            {
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }
                
            }
            void FindMultArray(int[,] arr,int[,] arr2,Random ran)
            {
                
                arr = CreateArray(arr.GetLength(0), arr.GetLength(1),ran);
                arr2 = CreateArray(arr2.GetLength(0), arr2.GetLength(1),ran);
                PrintArray(arr);
                Console.WriteLine();
                PrintArray(arr2);
                Console.WriteLine();
                int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
                for(int i=0;i<result.GetLength(0);i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                        result[i, j] = arr[i, j] * arr2[j, i];
                }
                Console.WriteLine();
                PrintArray(result);
            }
           bool FindNum(int[,,]arr,int random)
            {
                bool x=false;
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for(int j=0;j<arr.GetLength(1);j++)
                    {
                        
                        for(int k=0;k<arr.GetLength(2);k++)
                        {
                            if(arr[i,j,k]==random)
                            {
                                x = true;
                                break;
                            }

                        }    
                    }
                }
                return x;
            }
            void PrintUniqArr(Random unik)
            {
                int[,,] unikarr = new int[4, 4, 4];
                
                for(int i=0;i<unikarr.GetLength(0);i++)
                {
                    for(int j=0;j<unikarr.GetLength(1);j++)
                    { 
                        for(int k=0;k<unikarr.GetLength(2);)
                        {
                            int num = unik.Next(0, 65);
                            if (FindNum(unikarr, num)) continue;
                            else
                            {
                                unikarr[i, j, k] = num;
                                k++;
                            }
                        }
                    }
                }
                for(int i=0;i<unikarr.GetLength(0);i++)
                {
                    for(int j=0;j<unikarr.GetLength(1);j++)
                    {
                        for (int k = 0; k < unikarr.GetLength(2); k++)
                            Console.Write(unikarr[i, j, k] + "\t");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                
            
            }
            void СircleArray()
            {
                int m = 5, n = 5, s = 1;
                int[,] Cirarray = new int[m, n];

                for (int y = 0; y < n; y++)
                {
                    Cirarray[0, y] = s;
                    s++;
                }
                for (int x = 1; x < m; x++)
                {
                    Cirarray[x, n - 1] = s;
                    s++;
                }
                for (int y = n - 2; y >= 0; y--)
                {
                    Cirarray[m - 1, y] = s;
                    s++;
                }
                for (int x = m - 2; x > 0; x--)
                {
                    Cirarray[x, 0] = s;
                    s++;
                }

                int c = 1;
                int d = 1;

                while (s < m * n)
                {
                    while (Cirarray[c, d + 1] == 0)
                    {
                        Cirarray[c, d] = s;
                        s++;
                        d++;
                    }
                    while (Cirarray[c + 1, d] == 0)
                    {
                        Cirarray[c, d] = s;
                        s++;
                        c++;
                    }
                    while (Cirarray[c, d - 1] == 0)
                    {
                        Cirarray[c, d] = s;
                        s++;
                        d--;
                    }
                    while (Cirarray[c - 1, d] == 0)
                    {
                        Cirarray[c, d] = s;
                        s++;
                        c--;
                    }
                }
                for (int x = 0; x < m; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        if (Cirarray[x, y] == 0)
                        {
                            Cirarray[x, y] = s;
                        }
                    }
                }
                for (int x = 0; x < m; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        if (Cirarray[x, y] < 10)
                        {
                            Console.Write(Cirarray[x, y] + ",  ");
                        }
                        else
                        {
                            Console.Write(Cirarray[x, y] + ", ");
                        }
                    }
                    Console.WriteLine("");
                }

            }


            /*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
          по убыванию элементы каждой строки двумерного массива.
          Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            В итоге получается вот такой массив:

            1 2 4 7
            2 3 5 9
            2 4 4 8*/
            int[,] array = new int[5, 5];
            string[] col_and_rou;
            Console.WriteLine("создать двумерный массив и отсортировать по строчкам");
            Random rand = new Random();
            for(int i=0;i<array.GetLength(0);i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(0, 100);
            }
            SortAndPrintArray(array);
            /*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
            которая будет находить строку с наименьшей суммой элементов.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            5 2 6 7
            Программа считает сумму элементов в каждой строке и выдаёт номер строки с
            наименьшей суммой элементов: 1 строка*/
            Console.WriteLine("найти строку с наименьшей суммой элементов");
            Console.Write("введите размер массива, разделяя пробелом :");
            col_and_rou = Console.ReadLine().Split(' ');
            int[,] vs = new int[int.Parse(col_and_rou[0]), int.Parse(col_and_rou[1])];
            FindMinSum(vs,rand);
            /*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
            произведение двух матриц.
            Например, заданы 2 массива:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            5 2 6 7
            и
            1 5 8 5
            4 9 4 2
            7 2 2 6
            2 3 4 7
            Их произведение будет равно следующему массиву:
            1 20 56 10
            20 81 8 6
            56 8 4 24
            10 6 24 49
            */
            Console.WriteLine("найти произведение двух матриц");
            Console.Write("введите размер стобца и строки массива, разделяя пробелом,\n второй будет такого же размера :");
            col_and_rou = Console.ReadLine().Split(' ');
            int[,] vs1 = new int[int.Parse(col_and_rou[0]), int.Parse(col_and_rou[1])];
            int[,] vs2 = vs1;
            if (col_and_rou[0] == col_and_rou[1])
                FindMultArray(vs1, vs2, rand);
            else Console.WriteLine("невозможно найти произведение матриц, размер по вертикали не соответствует размеру по горизонтали");
            /*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
            Напишите программу, которая будет построчно выводить массив, добавляя индексы 
            каждого элемента.
            массив размером 2 x 2 x 2
            12(0,0,0) 22(0,0,1)
            45(1,0,0) 53(1,0,1)*/
            Console.WriteLine("трехмерный массив уникальных чисел");
            
            PrintUniqArr(rand);
            /*Задача 62. Заполните спирально массив 4 на 4.
            Например, на выходе получается вот такой массив:
            1 2 3 4
            12 13 14 5
            11 16 15 6
            10 9 8 7
            */
            Console.WriteLine("заполнить массив спиралью");
            СircleArray();
            Console.ReadKey();
        }
    }
}