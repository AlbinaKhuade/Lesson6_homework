// Задача 43: Напишите программу, которая
// найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double CrossPointX(int numB1, int numK1, int numB2, int numK2)
{
    double x = 0;
    x = ((double)numB2 - (double)numB1) / ((double)numK1 - (double)numK2);
    return x;
}

double CrossPointY(double x, int numK1, int numB1)
{
    double y = 0;
    y = (double)numK1 * x + (double)numB1;
    return y;
}

double crossPointX = Math.Round(CrossPointX(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
double crossPointY = Math.Round(CrossPointY(crossPointX, k1, b1), 2, MidpointRounding.ToZero);

Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({crossPointX}, {crossPointY})");