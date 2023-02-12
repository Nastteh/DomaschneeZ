//8: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");

int numberN = Convert.ToInt32(Console.ReadLine());
int numberI = 2;

if (numberN > 1)
{
    while (numberI <= numberN)
    {
        Console.Write(numberI + " ");
        numberI = numberI + 2;
    }
}
