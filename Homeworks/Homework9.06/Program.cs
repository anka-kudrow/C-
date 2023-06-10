// Всё выполнять через рекурсию.
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumbers(int num)
{
    if(num == 1) return "1";
    return $"{num}, " + $"{GetNumbers(num -1)}";
}

Console.Clear();
System.Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumbers(number));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSummOfElements(int num1, int num2)
// {
//     if (num2 == num1)
//         return num1;
// return num2 + FindSummOfElements(num1, num2 - 1);  
// }

// Console.Clear();
// System.Console.WriteLine("Input the first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindSummOfElements(number1, number2));





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int FindAkkerman(int num1, int num2)
// {
//     if (num1 == 0)
//         return num2 + 1;
//     if (num1 > 0 && num2 == 0)
//         return FindAkkerman(num1 - 1, 1);
//     if (num1 > 0 && num2 > 0)
//         return FindAkkerman(num1 - 1, FindAkkerman(num1, num2 - 1));    
//     return FindAkkerman(num1, num2);    
// }

// System.Console.WriteLine(FindAkkerman(2,3));


