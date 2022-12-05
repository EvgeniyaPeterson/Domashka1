//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] ArrayNumbers()
{
    Console.WriteLine("Введите длинну массива: ");
    int lenght = int.Parse(Console.ReadLine()!);

    int[] array = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);
        if (i != input.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

int CountPositiveNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > 0)
            result++;
    }
    return result;
}

var array = ArrayNumbers();
Print(array);

var positivecount = CountPositiveNumbers(array);
Console.WriteLine("Количество положительных числел = " + positivecount);

