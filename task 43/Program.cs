//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    double result = Convert.ToDouble(value);
    return result;
}

Console.WriteLine("Введите данные прямых (y=kx+b)");
double k1 = Prompt("Введите угол наклона первой прямой ");
double k2 = Prompt("Введите угол наклона второй прямой ");
double b1 = Prompt("Введите значение y-пересечения первой прямой ");
double b2 = Prompt("Введите значение y-пересечения второй прямой ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);
}