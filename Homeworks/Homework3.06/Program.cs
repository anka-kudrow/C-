// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillRandom2dArray (int [,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
}

void Print2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j], 3} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SortRowsOfArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
            }
        }           
    }

}
 
Console.Clear();
System.Console.WriteLine("Enter a minimum value of the array:");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a maximum value of the array:");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a quantity of rows:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a quantity of columns:");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] myArray = new int [rows,cols];
FillRandom2dArray(myArray, min, max);
Print2dArray (myArray);
SortRowsOfArray(myArray);
Print2dArray (myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// void FillRandom2dArray (int [,] array, int minValue, int maxValue)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
// }

// void Print2dArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j], 3} ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int FindRowWithMaxSum (int [,] array)
// {
//     int [] Sums = new int [array.GetLength(0)];
//     int maxSum = 0;
//     int maxNumberOfRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         if (sum > maxSum)
//         {
//             maxSum = sum;
//             maxNumberOfRow = i + 1;
//         }  
//     }
//     return maxNumberOfRow;
// }

// Console.Clear();
// System.Console.WriteLine("Enter a minimum value of the array:");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a maximum value of the array:");
// int max = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of columns:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = new int [rows,cols];
// FillRandom2dArray(myArray, min, max);
// Print2dArray (myArray);
// System.Console.WriteLine($"The row with max summ is {FindRowWithMaxSum(myArray)} row");





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// void FillRandom2dArray (int [,] array, int minValue, int maxValue)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
// }


// void Print2dArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j], 3} ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int [,] NewMatrix (int [,] matr1, int [,] matr2)
// {
//     int [,] myNewMatrix = new int [matr1.GetLength(0),matr1.GetLength(1)];
//     for (int i = 0; i < matr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr2.GetLength(1); j++)
//         {   
//             for (int k = 0; k < matr1.GetLength(1); k++)
//             {
//                 myNewMatrix [i,j] += matr1[i,k] * matr2[k,j];
//             }
//         }
//     }
//     return myNewMatrix;
// }

// Console.Clear();
// System.Console.WriteLine("Enter a minimum value in the first matrix:");
// int min1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a maximum value in th first matrix:");
// int max1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a minimum value in the second matrix:");
// int min2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a maximum value in th second matrix:");
// int max2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of rows in the first matrix:");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of columns in the first matrix:");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of rows in the second matrix:");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter a quantity of columns in the second matrix:");
// int cols2 = Convert.ToInt32(Console.ReadLine());

// int [,] Matrix1 = new int [rows1, cols1];
// int [,] Matrix2 = new int [rows2, cols2];
// FillRandom2dArray(Matrix1, min1, max1);
// FillRandom2dArray(Matrix2, min2,max2);
// Print2dArray(Matrix1);
// Print2dArray(Matrix2);

// int [,] resultMatrix = NewMatrix(Matrix1,Matrix2);
// Print2dArray(resultMatrix);




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



