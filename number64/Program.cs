// Задайте число N. Напишите программу, которая выведёт все натуральные чётные
// числа от N до 1

int number = Prompt("Введите число: ");
Console.WriteLine($"{Range(number)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string Range(int n)
{
    if (n % 2 == 0)       
    {
       if( n == 2)
          {
           return "2";
          }
       return n + ", " + Range(n-2); 
    }
    else 
    {
        if (n == 2)
           {
            return "2";
           }
        return (n - 1) + ", " + Range(n-2);
    }
}

//Почему программа не работает с нечётными числами?