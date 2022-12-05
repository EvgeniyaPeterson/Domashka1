//Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Koefficients()
{
    Console.Write("Введите к1= ");
    int k1 = int.Parse(Console.ReadLine()!);

    Console.Write("Введите к2= ");
    int k2 = int.Parse(Console.ReadLine()!);

    Console.Write("Введите b1= ");
    int b1 = int.Parse(Console.ReadLine()!);

    Console.Write("Введите b2= ");
    int b2 = int.Parse(Console.ReadLine()!);

    return k1;
    return k2;
    return b1;
    return b2;
}

double CoordinatesOfIntersectionPoint(double x, double y)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return x;
    return y;
}

void Print(int koeffic)
{
    Console.Write(k1);
    Console.Write(k2);
    Console.Write(b1);
    Console.Write(b1);

}
