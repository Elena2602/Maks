/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a < n)
 {
double b = a;
if (b / 2 - a /2 == 0)
Console.WriteLine(a);
a = a + 1;
}





