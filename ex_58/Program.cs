// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] arrayA = new int[2,2] { {2, 4}, {3, 2}};
int[,] arrayB = new int[2,2] { {3, 4}, {3, 3}};

int[,] arrayResult = MatrixMultiply(arrayA, arrayB);

PrintArray(arrayA);
PrintArray(arrayB);
PrintArray(arrayResult);



void PrintArray(int[,] inArray)
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiply(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] resultArray = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    int sum;
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                sum += arrayOne[i, k] * arrayTwo[k, j];
            }
            resultArray[i,j] = sum;
        }
    }
    return resultArray;
}