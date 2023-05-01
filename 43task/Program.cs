/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1 = ReadInt("коэф b1 введите");
double k1 = ReadInt("коэф k1 введите");
double b2 = ReadInt("коэф b2 введите");
double k2 = ReadInt("коэф k2 введите");

/* int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
} */

if (k1==k2)
{
    System.Console.WriteLine("Линии пересекаются");
}
double x = (b2-b1) / (k1-k2);
double y = k1* x + b1;

System.Console.WriteLine($"b1 = {b1}, k1 = {k1},b2 = {b2}, k2 = {k2} ->({x}; {y})");

double ReadInt(string message)
{
    System.Console.Write($"Введите {message}: ");
    return double.Parse(System.Console.ReadLine());
}
