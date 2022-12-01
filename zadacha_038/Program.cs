//Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.


double[] ArrayNumbers()
{
    Console.WriteLine("Введите длинну массива");
    int lenght = int.Parse(Console.ReadLine()!);   

    double[] array = new double[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.NextDouble();
    }
    return array;
}

void Print(double[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i].ToString("F2"));
        if (i !=input.Length-1)
        Console.Write(", ");
    }
    Console.WriteLine();
}

double CalcRange(double[] input)
{
    double min = input[0];
    double max = input[0];
    for (int i = 1; i < input.Length; i++)
    {
            if (input[i]<min)
                min=input[i];
            else if (input[i]>max)
                max=input[i];
    }
    return max-min;
}

var array = ArrayNumbers();
Print(array);

var diff = CalcRange(array);
Console.WriteLine("Разность минимального и максимального значения = " + diff.ToString("F2"));
