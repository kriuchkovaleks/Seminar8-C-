// Заполните спирально массив 4 на 4.

int[,] matrix = new int[4, 4];


int[,] PrintArray(int[,] matr) // метод, который печатает массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}      ");
        }
        Console.WriteLine();
    }
    return matr;
}

/*
int [,] FillMatrixSpiral(int[,] matrix)
{
    int [,] finalMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    int summ = 1;
    
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        
            finalMatrix[i,j] = finalMatrix[i,j] + summ;
            summ = summ + 1;
                      
        }
    }   
    return finalMatrix;
}
*/

int[,] FillMatrixSpiral(int[,] matrix)
{
    int[,] finalMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    int summ = 1;


    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        finalMatrix[0, j] = finalMatrix[0, j] + summ;
        summ = summ + 1;

    }
    
    for (int i = 1; i < matrix.GetLength(1); i++)
    {

        finalMatrix[i, 3] = finalMatrix[i, 3] + summ;
        summ = summ + 1;

    }
    
    for (int j = 2; j != -1; j--)
    {

        finalMatrix[3, j] = finalMatrix[3, j] + summ;
        summ = summ + 1;

    }

    for (int i = 2; i > 0; i--)
    {

        finalMatrix[i, 0] = finalMatrix[i, 0] + summ;
        summ = summ + 1;

    }

     for (int j = 1; j < 3; j++)
    {

        finalMatrix[1, j] = finalMatrix[1, j] + summ;
        summ = summ + 1;

    }

    
    for (int j = 2; j != 0; j--)
    {

        finalMatrix[2, j] = finalMatrix[2, j] + summ;
        summ = summ + 1;

    }
    return finalMatrix;
}


PrintArray(matrix);

int[,] spiralMatrix = FillMatrixSpiral(matrix);

Console.WriteLine(" ");
PrintArray(spiralMatrix);