// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов от M до N
// M = 4, N = 8 -> 30

int n = Prompt("Введите большее число: ");
int m = Prompt("Введите меньшее число: ");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
Console.Write(SumMN(m-1, n));