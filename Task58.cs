// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int[,] InitMatrix(int firstDemension, int secondDemension)
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(0, 10);
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");

        Console.WriteLine();
    }
}

void GetMultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
        Console.WriteLine("Данные матрицы нельзя перемножить");
    else
    {
        int [,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(1); k++)
                {
                    resultMatrix[i,j] = resultMatrix[i,j] + firstMatrix[i,k] * secondMatrix[k,j];
                   
                }
            }
            
        }
        Console.WriteLine("Переумноженная матрица");
        PrintMatrix(resultMatrix);

    }    

    
}



int firstDemensionMatrix1 = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemensionMatrix1 = GetDemension("Введите длину для второго разряда матрицы:");

int[,] firstMatrix = InitMatrix(firstDemensionMatrix1, secondDemensionMatrix1);

Console.WriteLine("Первая матрица:");
PrintMatrix(matrix: firstMatrix);

int firstDemensionMatrix2 = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemensionMatrix2 = GetDemension("Введите длину для второго разряда матрицы:");

int[,] secondMatrix = InitMatrix(firstDemensionMatrix2, secondDemensionMatrix2);

Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix: secondMatrix);

GetMultiplyMatrix(firstMatrix, secondMatrix);


