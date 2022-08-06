// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число ");
int numberC = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int max = numberA;
if (numberA == numberB && numberB == numberC) { Console.WriteLine("Эти числа одинаковые и максимальное число " + max); }
if (numberB > max) { max = numberB; }
if (numberC > max) { max = numberC; }
Console.WriteLine("Максимальное число " + (max));