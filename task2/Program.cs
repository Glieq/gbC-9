// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int M = Promt("Введите число M: ");
int N = Promt("Введите число N: ");
int sum = 0;
if (N < M)
{
    System.Console.WriteLine("Число N должно быть больше M");
    return;
}
void sumFromMtoN(int leftBorder, int rightBorder)
{
    if (leftBorder == rightBorder + 1)
    {
        return;
    }
    sum += leftBorder;
    sumFromMtoN(leftBorder + 1, rightBorder);
}
sumFromMtoN(M, N);
System.Console.WriteLine($"{sum}");