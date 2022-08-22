/*------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
------------------------------------------------------------------------------------------------------------*/

bool CheckNumbers(int a, int b)
{
    if(a<b)
    {
        if(a*a==b)
            return true;
    }
    else
    {
        if(b*b==a)
            return true;
    }
    return false;
}

Console.WriteLine("Прорамма проверки отношения квадрата между числами");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool res = CheckNumbers(a,b);

if(res)
    Console.WriteLine($"Числа {a} и {b} удовлетворяют условиям задачи");
else
    Console.WriteLine($"Числа {a} и {b} не удовлетворяют условиям задачи");
   
