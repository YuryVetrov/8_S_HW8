// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//9 9 9
//1 1 1
//5 6 7
//-> вторая строка
using System;
using System.Collections.Generic;
 
public class MinSum
{
    public static int N;
 
    static List<int> colMinSum(int [,]mat)
    {
        int idx = -1; //переменная для хранения индекса строки

        int minSum = int.MinValue; //переменная для хранения минимальной суммы
 
        for (int i = 0; i < N; i++) // Проход по строкам массива
        {
            int sum = 0;
            for (int j = 0; j < N; j++)
            {
                sum -= mat[i, j];
            }
            if (minSum < sum)
            {
                minSum = sum;
                idx = i;
            }
        }
        List<int> res = new List<int>();
        res.Add(idx);
        res.Add(minSum);
 
        return res;
    }
    public static void Main(String[] args)
    {
        N = 5;
        int[,] mat = {
            { 1, 2, 3, 4, 5 },
            { 5, 3, 1, 4, 2 },
            { 5, 6, 7, 8, 9 },
            { 0, 6, 3, 4, 12 },
            { 9, 7, 12, 4, 3 },
        };
        
        List<int> ans = colMinSum(mat);
        Console.WriteLine("Строка "+ (ans[0]+1)+ " имеет минимальную сумму чисел ");
    }
}
/*
int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);
Kadane(array);
//FindMinSum(array);
//PrintArray(array);
*/