//Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArrayMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)

        {
            matrix[i, j] = new Random().Next(-99, 100);
        }

    }
    return matrix;

}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

        {
            if (matr[i, j] >= 0)
                Console.Write(" "); //Чтоб ровнее отображались отрицательные числа
            if (matr[i, j] > -10 && matr[i, j] < 10) //Если число только из одной цифры
                Console.Write(" "); //Чтоб ровнее отображались короткие числа
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();


    }
}


double ArryRowAvg(int[,] arr, int row)
{
    double avg = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
        avg += arr[row, i];
    avg /= arr.GetLength(1);
    return avg;
}

var matrix = GetArrayMatrix(5, 6);
PrintMatrix(matrix);
Console.WriteLine();

double rowavg;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    rowavg = ArryRowAvg(matrix, i);
    //нужна поаправка на знак минуса
    if (rowavg >= 0)
        Console.Write(" "); //Чтоб ровнее отображались отрицательные числа
    Console.WriteLine(rowavg.ToString("F2"));
}




