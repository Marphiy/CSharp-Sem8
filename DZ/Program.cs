void PrintArray(int[] arr)
{
    Console.Write("Массив [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void Fill2DArray(int[,] arr, int StartNum, int FinishNum)
{
    Random rand = new Random();
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rand.Next(StartNum, FinishNum);

        }
    }
}

void Fill2DDoubleArray(double[,] arr, int StartNum, int FinishNum)
{
    Random rand = new Random();
    FinishNum++;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = Math.Round(rand.NextDouble() * 10, 1);

        }
    }
}

void Print2DArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Print2DDoubleArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Array2DMaxToMin(int[,] arr)
{
    for(int k = 0; k < arr.GetLength(0); k ++)
    {
        int temp = 0;
        for(int i = 0; i < arr.GetLength(1); i++)
        {
            int max = arr[k,i];
            int j = i;
            for(j = i; j < arr.GetLength(1); j++)
            {
                if(arr[k,j] > max) 
                {
                    max = arr[k,j];
                    temp = arr[k,i];
                    arr[k,i] = max;
                    arr[k,j] = temp;
                }
            }  
        }
    }
}

void Change2DArrayRows(int[,] arr, int row1, int row2)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int temp = 0;
    for(int i = 0; i < columns; i++)
    {
        temp = arr[row1, i];
        arr[row1, i] = arr[row2, i];
        arr[row2, i] = temp;
    }
}

int[,] Change2DArrayRowsNColumns(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] newArr = new int[columns, rows];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArr[j, i] = arr[i, j];
        }
    }
    return newArr;
}

int[] UniqElmntsCount(int[,] arr, int m, int n)
{
    int[] newArr = new int[n - m + 1];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[arr[i, j] - m]++;
        }
    }
    return newArr;
}

int[] FindMinElmtIn2D(int[,] arr)
{
    int[] ind = new int[2];
    return ind;
}

void Zadacha53()
{
    /*Задайте двумерный массив. Напишите программу,
    которая поменяет местами первую и последнюю строку
    массива.*/

    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, -9, 9);
    Print2DArray(nums);
    Console.WriteLine();
    Console.WriteLine("Введите номера строк, содержимoе которых следует поменять местами!");
    int row1 = Convert.ToInt32(Console.ReadLine()) -1;
    int row2 = Convert.ToInt32(Console.ReadLine()) -1;
    Console.WriteLine();
    if(row1 < nums.GetLength(1) && row2 < nums.GetLength(1))
    {
        Change2DArrayRows(nums, row1, row2);
        Print2DArray(nums);
    }
    else Console.WriteLine("Таких строк не существует!");

}

void Zadacha54()
{
    /*Задайте двумерный массив. Напишите программу, которая упорядочит 
    по убыванию элементы каждой строки двумерного массива.
    Random rand = new Random();*/

    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 0, 9);
    Print2DArray(nums);
    Console.WriteLine();
    Array2DMaxToMin(nums);
    Print2DArray(nums);
}

void Zadacha55()
{
    /*Задайте двумерный массив. Напишите программу,
    которая заменяет строки на столбцы. В случае, если это
    невозможно, программа должна вывести сообщение для
    пользователя.*/

    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, 1, 16);
    Print2DArray(nums);
    Console.WriteLine();
    Print2DArray(Change2DArrayRowsNColumns(nums));
}

void Zadacha56()
{
    //Задайте прямоугольный двумерный массив. Напишите программу, 
    //которая будет находить строку с наименьшей суммой элементов.

    Random rand = new Random();
    int m = 0;
    int n = 10;
    int rows = rand.Next(3, 10);
    int columns = rows;
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, m, n);
    Print2DArray(nums);
    int minSummRowInd = 0;
    int minSumm = n * 1000000;
    for(int i = 0; i < nums.GetLength(0); i ++)
    {
        int summ = 0;
        for(int j = 0; j < nums.GetLength(1); j++)
        {
            summ += nums[i, j];
        }
        if(summ < minSumm) 
        {
            minSumm = summ;
            minSummRowInd = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов {minSumm} находится в {minSummRowInd+1}й строке!");
}

void Zadacha57()
{
    /*Составить частотный словарь элементов
    двумерного массива. Частотный словарь содержит
    информацию о том, сколько раз встречается элемент
    входных данных.*/

    Random rand = new Random();
    int m = 15;
    int n = 21;
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, m, n);
    Print2DArray(nums);
    Console.WriteLine();
    PrintArray(UniqElmntsCount(nums, m, n));
    for(int i = 0; i < n - m; i++)
    {
        if(UniqElmntsCount(nums, m, n)[i] > 0) Console.WriteLine($"{i + m} в массиве встречается {UniqElmntsCount(nums, m, n)[i]} раз.");
    }
}

void Zadacha58()
{
    //Заполните спирально массив 4 на 4 числами
    //от 1 до 16.
    int rows = 4;
    int columns = 4;
    int[,] nums = new int[rows, columns];
    int row = 0;
    int column = 0;
    int changeRow = 0;
    int changeColumn = 1;
    int steps = columns;
    int turn = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        
        nums[row, column] = i + 1;
        steps--; 
        if(steps == 0)
        {
            steps = rows - 1 - turn / 2;
            int temp = changeRow;
            changeRow = changeColumn;
            changeColumn = -temp;
            turn++;
        }

        row += changeRow;
        column += changeColumn; 
    }
    Print2DArray(nums);
    
}

void Zadacha59()
{
    /*Задайтедвумерный массив из целых чисел. 
    Напишите программу, которая удалит строку и столбец, на
    пересечении которых расположен наименьший элемент
    массива.*/

    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rows;
    int[,] nums = new int[rows, columns];
    Fill2DArray(nums, -99, 100);
    Print2DArray(nums);
    Console.WriteLine();
    int min = nums[0, 0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(nums[i, j] < min) 
            {
                min = nums[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент A[{minI}: {minJ}] = {min}");
    Console.WriteLine();
    int bias_i = 0;
    int bias_j = 0;
    int[,] newArr = new int[rows - 1, columns - 1];
    for(int i = 0; i < rows - 1; i++)
    {
        if(i == minI) bias_i++;
        bias_j = 0;
        for(int j = 0; j < columns - 1; j++)
        {
            if(j == minJ) bias_j++;
            newArr[i, j] = nums[i + bias_i, j + bias_j];
        }
    }
    Print2DArray(newArr);
}

void Zadacha61()
{
    //Задайте две матрицы. Напишите
    //программу, которая будет находить произведение
    //двух матриц.
    int rows1 = 5;
    int columns1 = 2;
    int rows2 = 2;
    int columns2 = 3;
    int[,] mtrx1 = new int[rows1, columns1];
    Fill2DArray(mtrx1, 0, 10);
    Print2DArray(mtrx1);
    Console.WriteLine();

    int[,] mtrx2 = new int[rows2, columns2];
    Fill2DArray(mtrx2, 0, 10);
    Print2DArray(mtrx2);
    Console.WriteLine();

    int[,] mtrx = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int  k = 0; k < columns1; k++)
            {
                mtrx[i, j] += mtrx1[i, k] * mtrx2[k, j];
            }
        }
    }
    Print2DArray(mtrx);
}

//Zadacha53();
//Zadacha54();
//Zadacha55();
//Zadacha56();
//Zadacha57();
//Zadacha58();
//Zadacha59();
//Zadacha61();
