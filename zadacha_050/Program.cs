//Задача 50. Напишите программу, которая на вход принимает
//позиции элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//3 1 2 6
//17 -> такого элемента в массиве нет

int[,] GetArrayMatrix()
{
    Console.WriteLine("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    var random = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)

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

        { if (matr[i, j]>-10 && matr[i, j]<10) //Если число только из одной цифры
                Console.Write(" "); //Чтоб ровнее отображались короткие числа
            Console.Write(matr[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

int[] ReadArrayElementPosition() //Функция считывает с консоли позиции элемента. Возвращает массив из двух элементов
{
    int[] arrpos = new int[2]; //позиция из двух чисел для двумерного массива
    Console.WriteLine("Введите первую позицию (строку): "); //Не знаю как правильно, может позицию в первом ранге массива? Или, если это таблица - введите строку и слобец
    arrpos[0] = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую позицию (столбец): ");
    arrpos[1] = int.Parse(Console.ReadLine());
    return arrpos;
}


void GetArrayElement(int[,] array, int[] pos) //Функция получает два массива. В первом исходные данные, во-втором позиции элемента
{
    //Проверяем существует ли такой элемент
    if (pos[0]>array.GetLength(0)-1 || pos[1]>array.GetLength(1)-1) //Тут было бы изящнее циклом проверять - работало бы для любых размерностей массива
    {    Console.WriteLine("Такого элемента не существует");
        return; //Закончили выполнение функции    
    }
    Console.WriteLine("Значение: "+array[pos[0],pos[1]]);
}

var matrix = GetArrayMatrix();
PrintMatrix(matrix);
var pos = ReadArrayElementPosition();
GetArrayElement(matrix, pos);
