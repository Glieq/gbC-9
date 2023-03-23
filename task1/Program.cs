// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int N = Promt("Введите число N: ");
int border = 1;
void fromNtoZero(int border, int N)
{
    if (border == N + 1)
    {
        return;
    }
    fromNtoZero(border + 1, N);
    System.Console.WriteLine($"{border}");
}

fromNtoZero(border, N);

