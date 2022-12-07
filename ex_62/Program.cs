// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

PrintArray(
    ConvertArrayToFourByFour(
    ArrayFillNumbersInOrder(10, 16)
    ));


int[] ArrayFillNumbersInOrder(int startNum, int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = startNum + i;
    }
    return array;
}

int[,] ConvertArrayToFourByFour(int[] array)
{
    int[,] outArray = new int[4, 4];
    outArray[0, 0] = array [0];
    outArray[0, 1] = array [1];
    outArray[0, 2] = array [2];
    outArray[0, 3] = array [3];
    outArray[1, 3] = array [4];
    outArray[2, 3] = array [5];
    outArray[3, 3] = array [6];
    outArray[3, 2] = array [7];
    outArray[3, 1] = array [8];
    outArray[3, 0] = array [9];
    outArray[2, 0] = array [10];
    outArray[1, 0] = array [11];
    outArray[1, 1] = array [12];
    outArray[1, 2] = array [13];
    outArray[2, 2] = array [14];
    outArray[2, 1] = array [15];
    return outArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
    }
}