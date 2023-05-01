


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double Rasst(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));

}

Console.WriteLine("Vvedite koordinati pervoy tochki");
Console.WriteLine("x:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vvedite koordinati vtoroy tochki");
Console.WriteLine("x:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" Rasstoyaniye mezhdu tochkami: {Math.Round(Rasst(x1, y1, z1, x2, y2, z2), 2)}");






