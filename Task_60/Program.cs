// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
//Вывод:
//a[0, 0, 0] = 2
//a[0, 0, 1] = 4

void FillArray(int[, ,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            
            array[i, j, k] = count++; //new Random().Next(10, 99);
        }
    }
}
void PrintArray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            System.Console.Write($"{array[i, j, k], 4}"); 
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintIndex(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            System.Console.Write($"Число массива {array[i, j, k], 4}  имеет индексы: [{i}, {j}, {k}]. \n"); // {array[i, j, k], 4}"); 
        }
    }
}

/*
int NonRepeating(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0;  j < array.GetLength(1);  j++) 
        {
            for (int k = 0;  k < array.GetLength(2);  k++)
            {
                if (max <= min || count < 0 || (count > max - min && max - min > 0)) 
                {
                    throw new ArgumentOutRangeException("Range " + min + " to " + max + " (" + ((Int64)max - (Int64)min) + "values), or count " + count + " is illegal");
                }
                HashSet<int> candidates = new HashSet<int>();
                for (int top = max - count; top < max; top++)
                {
                    if (!candidates.Add(random.Next(min, top +1)))
                    {
                        candidates.Add(top);
                    }
                }
                List<int> result = candidates. ToList();
                for (int i = result.Count -1; i > 0; i--)
                int k = random.Next(i + 1);
                int temp = result[k];
                result[k] = result[i];
                result[i] = temp;
            }
            return result;
        }
    }
}
*/
int[, ,] array = new int[3, 3, 3];
FillArray(array);
PrintArray(array);
PrintIndex(array);
//GenerateRandom(array, count, min, max);
//PrintArray(array);
