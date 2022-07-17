/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем   */
// находим чему равен x и y из формул:
// x=(b1-b2)/(k2-k1)
// y = k1 * x + b1

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k2 != k1)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine("Координата х точки пересечения прямых: " + x);
    Console.WriteLine("Координата y точки пересечения прямых: " + y);
}
else
{
    Console.WriteLine("k2 и k1 не могут быть равны");
}
 

