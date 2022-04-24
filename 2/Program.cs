// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(x));


int Sum(int a)
{
    int b = 0;
    while (a > 0)
    {
        b += a % 10;
        a /= 10;
    }
    return b;
}
