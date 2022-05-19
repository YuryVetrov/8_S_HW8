// Задача 62: Заполните спирально массив 4 на 4.
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

using System;
using System.Collections.Generic;
 
class GFG {
 
    public static int R = 4, C = 4;
    public static bool isInBounds(int i, int j)
    {
        if (i < 0 || i >= R || j < 0 || j >= C)
            return false;
 
        return true;
    }
 
    // Check if the position is blocked
    public static bool isBlocked(int[, ] matrix, int i,
                                 int j)
    {
        if (!isInBounds(i, j))
            return true;
        if (matrix[i, j] == -1)
            return true;
        return false;
    }
 
    // DFS code to traverse spirally
    public static void spirallyDFSTravserse(int[, ] matrix,
                                            int i, int j,
                                            int dir,
                                            List<int> res)
    {
        if (isBlocked(matrix, i, j))
            return;
 
        bool allBlocked = true;
 
        for (int k = -1; k <= 1; k += 2) {
            allBlocked = allBlocked
                         && isBlocked(matrix, k + i, j)
                         && isBlocked(matrix, i, j + k);
        }
        res.Add(matrix[i, j]);
        matrix[i, j] = -1;
 
        if (allBlocked) {
            return;
        }
 
        // dir: 0 - right, 1 - down, 2 - left, 3 - up
        int nxt_i = i;
        int nxt_j = j;
        int nxt_dir = dir;
        if (dir == 0) {
            if (!isBlocked(matrix, i, j + 1)) {
                nxt_j++;
            }
            else {
                nxt_dir = 1;
                nxt_i++;
            }
        }
        else if (dir == 1) {
            if (!isBlocked(matrix, i + 1, j)) {
                nxt_i++;
            }
            else {
                nxt_dir = 2;
                nxt_j--;
            }
        }
        else if (dir == 2) {
            if (!isBlocked(matrix, i, j - 1)) {
                nxt_j--;
            }
            else {
                nxt_dir = 3;
                nxt_i--;
            }
        }
        else if (dir == 3) {
            if (!isBlocked(matrix, i - 1, j)) {
                nxt_i--;
            }
            else {
                nxt_dir = 0;
                nxt_j++;
            }
        }
        spirallyDFSTravserse(matrix, nxt_i, nxt_j, nxt_dir,
                             res);
    }
 
    // To traverse spirally
    public static List<int> spirallyTraverse(int[, ] matrix)
    {
        List<int> res = new List<int>();
        spirallyDFSTravserse(matrix, 0, 0, 0, res);
        return res;
    }
 
    // Driver code
    static public void Main()
    {
        int[, ] a = { { 1, 2, 3, 4 },
                      { 5, 6, 7, 8 },
                      { 9, 10, 11, 12 },
                      { 13, 14, 15, 16 } };
 
        // Function Call
        List<int> res = spirallyTraverse(a);
        int size = res.Count;
 
        for (int i = 0; i < size; ++i)
            Console.Write(res[i] + " ");
 
        Console.WriteLine();
    }
}