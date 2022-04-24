//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Array();

void Array()
{
    Random rand = new Random();
    int[] a = new int[8];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rand.Next();
    }
    Console.WriteLine(String.Join(", ", a));
}