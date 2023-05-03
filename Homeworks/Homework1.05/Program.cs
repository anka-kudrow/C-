// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Boolean palindrom(int num)
// {
//     return (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10);  
        
// }

// Console.WriteLine("Vvedite 5-zna4noye 4islo");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 9999 && n < 100000 && palindrom(n))  
//         Console.WriteLine("dannoe 4islo - palindrom"); 
// else if (n < 10000 || n > 99999)
//     {Console.WriteLine("4islo ne 5-zna4noe. Vvedite 5-zna4noe 4islo");}
// else    
//     Console.WriteLine("dannoe 4islo - ne palindrom");




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double Rasst(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));

// }

// Console.WriteLine("Vvedite koordinati pervoy tochki");
// Console.WriteLine("x:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("y:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("z:");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Vvedite koordinati vtoroy tochki");
// Console.WriteLine("x:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("y:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("z:");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($" Rasstoyaniye mezhdu tochkami: {Math.Round(Rasst(x1, y1, z1, x2, y2, z2), 2)}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void CubesTable(int N)
// {
//     int count = 1;
//     int cube = 0;
//     while (count <= N)
//     {
//         cube = count * count * count;
//         Console.WriteLine(count + " - " + cube);
//         count ++;
//     }
// }


// Console.WriteLine("Vvedite naturalnoe 4islo");
// int N = Convert.ToInt32(Console.ReadLine());
// CubesTable(N);




// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности 
// и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу для. проверки истинности 
// утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) . 
// Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, 
// сами значения предикатов случайные, проверяем это утверждение 100 раз, с помощью модуля time выводим на экран , 
// сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.