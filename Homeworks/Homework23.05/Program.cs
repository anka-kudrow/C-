// Урок 5. Функции и одномерные массивы


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] CreateArray(int size)
// {
//     int [] RandomArray = new int [size];
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(99, 1000);
//     }
//     return RandomArray;
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// int HowManyEvenNum (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0 )
//         count++;
//     }
//     return count;
// }

// Console.Clear();
// System.Console.WriteLine("Vvedite razmernost' massiva:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[]NewArray = CreateArray(size);
// System.Console.WriteLine("Sgenerirovan massiv:");
// PrintArray(NewArray);
// System.Console.WriteLine($"Koli4estvo 4etnix 4isel v massive: {HowManyEvenNum(NewArray)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] RandomArray = new int [size];
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return RandomArray;
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// int FindSumOfOddIndex(int [] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i +2)
//     {
//         sum = array[i] + sum;
//     }
//     return sum;
// }

// Console.Clear();
// System.Console.WriteLine("Vvedite razmernost' massiva:");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Ukazhite min i max zna4eniya:");
// int minV = Convert.ToInt32(Console.ReadLine());
// int maxV = Convert.ToInt32(Console.ReadLine());
// int[]myArray = CreateArray(size, minV, maxV);
// System.Console.WriteLine("Sgenerirovan massiv:");
// PrintArray(myArray);
// System.Console.WriteLine($"Summa elementov na ne4etnix poziciyax = {FindSumOfOddIndex(myArray)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// double [] CreateArray(int size)
// {
//     double [] RandomArray = new double [size];
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(-100, 100) +  Math.Round(new Random().NextDouble(), 2);
//     }
//     return RandomArray;
// }

// void PrintArray(double [] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// double FindDifferBtwMinMax(double [] array)
// {
//     double numMin = 100.0;
//     double numMax = 0.0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < numMin)
//             numMin = array[i];
//         else if(array[i] > numMax)
//             numMax = array[i];    
//     }
//     return numMax - numMin;
// }


// Console.Clear();
// System.Console.WriteLine("Vvedite razmernost' massiva:");
// int size = Convert.ToInt32(Console.ReadLine());
// double[]NewArray = CreateArray(size);
// System.Console.WriteLine("Sgenerirovan massiv:");
// PrintArray(NewArray);
// System.Console.WriteLine($"Raznica mezhdu max i min 4islami: {FindDifferBtwMinMax(NewArray)}");






// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

// Задача VERY HARD необязательная Имеется массив случайных целых чисел. 
// Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. 
// Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8
