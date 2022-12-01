// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int[] ArrayNumbers()
{
    Console.WriteLine("Введите длинну массива");
    int lenght = int.Parse(Console.ReadLine()!);   

    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(100, 1000);
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

int CountEvenNumbers(int[] input)
{
     int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i]%2==0)
            result ++;
    }
    return result;
}

var array = ArrayNumbers();
Print(array);

var evencount = CountEvenNumbers(array);
Console.WriteLine("Количество четных числел = " + evencount);




