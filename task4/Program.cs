//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
//bool a = number1 > number2;
//bool b = number2 > number3;
//Console.WriteLine("самое большое число из 3х цифр это: " + b);
Console.WriteLine("большее число: " + Math.Max(Math.Max(a, b), c));
//if (number1 > number2)
//{
//Console.WriteLine("большее число " + number1);
//Console.WriteLine("меньшее число " + number2);
//}

//else if (number2 > number3)
//{
//Console.WriteLine("меньшее число " + number3);
//}

//if (number1 > number2 > number3)
//{
//Console.WriteLine("большее число " + number1);
//Console.WriteLine("меньшее число " + number2);
//Console.WriteLine("меньшее число " + number3);
//}