// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSt(a, b));

int GetSt(int a, int b)
{
    int x = a;
    while (b > 1)
    {
        b--;
        x *= a;
    }
    return x;
}