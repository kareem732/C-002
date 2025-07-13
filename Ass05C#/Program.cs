using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _132
{
    internal class Program
    {
        static void Main(string[] args)
        {










            //#region 1- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = { 5, 10, 15, 20, 25 }; 
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("The sum of all elements in the array is: " + sum);
            //#endregion


            //#region 2- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 4, 5, 6, 7, 8, 9, 10 };
            //int[] merged = new int[numbers1.Length + numbers2.Length];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    merged[i] = numbers1[i];
            //}
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    merged[numbers1.Length + i] = numbers2[i];
            //}
            //Array.Sort(merged);
            //Console.WriteLine("Merged and sorted array:");
            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");
            //}
            //#endregion

            //#region 3- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] Numbers = { 10, 20, 20, 30, 30, 4, 0, 10, 40, 50, 60, 80, 70 };
            //bool[] visited = new bool[Numbers.Length];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (visited[i]) continue;
            //    int count = 1;
            //    for (int j = i + 1; j < Numbers.Length; j++)
            //    {
            //        if (Numbers[i] == Numbers[j])
            //        {
            //            count++;
            //            visited[j] = true;  
            //        }
            //    }
            //    Console.WriteLine($"{Numbers[i]}  {count} repeated");
            //}
            //#endregion


            //#region 12- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Numebrs = { 1, 2, 3, 4, 5, 30, 10, 20 ,100 ,70, 70 ,120 };
            //int max = Numebrs[0];
            //int min = Numebrs[0];
            //for (int i = 1; i < Numebrs.Length; i++)
            //{
            //    if (Numebrs[i] > max)
            //        max = Numebrs[i];

            //    if (Numebrs[i] < min)
            //        min = Numebrs[i];
            //}
            //Console.WriteLine("Maximum element = " + max);
            //Console.WriteLine("Minimum element = " + min);
            //#endregion



            //#region 4- Write a program in C# Sharp to find the second largest element in an array.

            //#endregion


            //#region 5-. Consider an Array of Integer values with size N, having values as in this Example
            //int[] Numbers = new int[] {7, 0, 0, 0, 5, 6, 7,5, 0,7,5,3 };


            //#endregion



            //#region 6- Given a list of space separated words, reverse the order of the words.
            //string input = Console.ReadLine();
            //Console.WriteLine(string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));
            //#endregion




            //#region 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("enter number of rows: ");
            //bool isValidRows = int.TryParse(Console.ReadLine(), out int rows);
            //Console.Write("enter number of columns: ");
            //bool isValidCols = int.TryParse(Console.ReadLine(), out int cols);
            //if (!isValidRows || !isValidCols || rows <= 0 || cols <= 0)
            //{
            //    Console.WriteLine("Invalid input for rows or columns.");
            //    return;
            //}
            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];
            //Console.WriteLine("\nEnter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"[{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}
            //Console.WriteLine("\nSecond array after copying:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //#endregion

            //#region 8- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] array = { 10, 20, 30, 40, 50 };
            //Array.Reverse(array);
            //Console.WriteLine(string.Join(" ", array));
            //#endregion










        }
    }
}
