//Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double[,] GetArrayMatrix()
{
    Console.WriteLine("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);

    var random=new Random();
    double[,]matrix = new double[m, n];
   

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)

        {
            matrix[i,j]= new Random().NextDouble();//from 0 to 1
            matrix[i,j]=(matrix[i,j]-0.5);//from -0,5 to 0,5
            matrix[i,j]=matrix[i,j]*100;//from -50 to 50
        }
        
    }
    return matrix;

}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

        {
            if(matr[i, j]>=0)
                Console.Write(" ");    
            Console.Write($"{matr[i, j].ToString("00.00")}  ");
        }
        Console.WriteLine();
    }
}

var matrix = GetArrayMatrix();
PrintMatrix(matrix);