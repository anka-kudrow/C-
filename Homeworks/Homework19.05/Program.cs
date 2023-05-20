// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// double inPower(double x, double y )
// {
//     double result = Math.Pow(x,y);
//     return result;
// }


// System.Console.WriteLine("Vvedite 2 4isla");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{A} v stepeni {B} = {inPower(A,B)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumOfDigit(int n)
// {    
//     int summ = 0;
//     int length = 0;
//     while (length < n)
//         {summ = summ + n % 10;
//         n = n / 10;
//         length++;}
    
//     return summ;
// } 


// System.Console.WriteLine("Vvedite 4islo");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Summa tsifr etogo 4isla = {SumOfDigit(num)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] CreateArr()
{
    Random random = new Random();
    int[] nums = new int[8];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = random.Next(1,100);
    }
    return nums;
}

void PrintArr(int [] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.Write($"{nums[i]} ");
    }
    System.Console.WriteLine();
}

int [] newArray = CreateArr();
PrintArr(newArray);



// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

