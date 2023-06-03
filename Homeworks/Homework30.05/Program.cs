// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// void CreateRandomArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = Convert.ToDouble(new Random().Next(1,11)/10.0);
//         }         
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j]}  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Console.Clear();
// double [,] myArray = new double[3,4];
// CreateRandomArray(myArray);
// PrintArray(myArray);




// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


void CreateRandomArray (int[,] array)
{  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

string FindNumberInArray(int[,] array, int num)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num) 
            {
                res = ($"Position of your element: [{i},{j}]");
                break;
            }    
        }
        
    }
    if (res.Length == 0) res = "There is no such number in the array.";

            return res;
}

int [,] myArray = new int[3,3];
CreateRandomArray(myArray);
PrintArray(myArray);
System.Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumberInArray(myArray, num));





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// void CreateRandomArray (int[,] array)
// {  
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,11);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i,j]}  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void AverageOfCols (int [,] array, int rows)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double avarage = 0;
//         int n = rows;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             avarage = (avarage + array[i, j]);
//         }
//         avarage = Math.Round((avarage / n),1);
//         Console.Write(avarage + "; ");
//     }
// }

// Console.Clear();
// Console.WriteLine("Enter a number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a number of columns:");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];

// CreateRandomArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// AverageOfCols(array, rows);



// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2* 3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0,0 и 1,2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1,2 не трогаем, так как это уже перемещенные ячейки, выбираем случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0,2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1,0 и 1,1, меняем их местами
// 4 5 3
// 9 1 2


