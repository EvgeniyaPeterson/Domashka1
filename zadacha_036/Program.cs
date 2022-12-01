//Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] ArrayNumbers()
{
    Console.WriteLine("Введите длинну массива");
    int lenght = int.Parse(Console.ReadLine()!);   

    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(10,99);
    }
    return array;
}

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);
        if (i !=input.Length-1)
        Console.Write(", ");
    }
    Console.WriteLine();
}

int SumOddNumbers(int[] input)
{
      int result = 0;
    for (int i = 1; i < input.Length; i+=2)
    {
            result+=input[i];
    }
    return result;
}

var array = ArrayNumbers();
Print(array);

var oddsum = SumOddNumbers(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + oddsum);
