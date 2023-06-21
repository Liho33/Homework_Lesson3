// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Quad(int N)
{
    int count = 1;
    while (count <= N)
    {
        System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
        count ++;
    }
}
System.Console.WriteLine("Enter a number N -> ");
int N = Convert.ToInt32(Console.ReadLine());
Quad(N);
