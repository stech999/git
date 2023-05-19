//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2)
{
Console.WriteLine("большее число" + number1);
Console.WriteLine("меньшее число из " + number2);
}

else if (number1 < number2)
{
Console.WriteLine("меньшее число " + number1);
Console.WriteLine("большее число " + number2);
}