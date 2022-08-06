//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до введенного Вами числа");
for (int a = 2; a <= number; a ++)
{if (a % 2 == 0){Console.WriteLine(a);}}