// Задача 19. Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int number)
{
    if (number >= 10000 && number < 100000)
    {
        int num1 = number % 10;
        int num2 = (number / 10000) % 10;
        if (num1 == num2)
        {
            int num3 = (number / 10) % 10;
            int num4 = (number / 1000) % 10;
            if (num3 == num4)
            {
                System.Console.WriteLine($"число {number} являеться Палидромом");
            }
            else
            {
                System.Console.WriteLine($"число {number} не является Палидромом");
            }
        }
        else
        {
            System.Console.WriteLine($"число {number} не является Палидромом!!!");
        }
    }
    else
    {
        System.Console.WriteLine($"ошибка!!! число {number} не является пятизначным!!!");
    }
}

System.Console.Write("Введите пятизначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);









