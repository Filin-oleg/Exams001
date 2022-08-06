// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB) { Console.WriteLine("Эти числа одинаковые"); }
else if (numberA > numberB) { Console.Write("Первое число " + (numberA)); Console.WriteLine(" больше, чем второе число " + (numberB)); }
else { Console.Write("Второе число " + (numberB)); Console.WriteLine(" больше, чем первое число " + (numberA)); }