// Задача 8
Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a < n)
 {
double b = a;
if (b / 2 - a /2 == 0)
Console.WriteLine(a);
a = a + 1;
}




