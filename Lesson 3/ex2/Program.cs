
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
}
System.Console.WriteLine("Input X coordinate point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input Y coordinate point A: ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input Z coordinate point A: ");
double za = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input X coordinate point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input Y coordinate point B: ");
double yb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input Z coordinate point B: ");
double zb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, za, xb, yb, zb)}");







