// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[8,7];
FillArrayClockwise(ArrayFillNumbersInOrder(10,array.GetLength(0)*array.GetLength(1)), array);
PrintArray(array);




void FillArrayClockwise(int[] inputArray, int[,] outputArray)
{
    int x = 0;
    int y = 0;
    
    int[,] directionMultiplier = new int[4,2]{{0,1}, {1,0}, {0, -1}, {-1, 0}};
    int currentDirection = 0;
    int lengthToGo;
    
    int toStepX = outputArray.GetLength(1) - 1;
    int toStepY = outputArray.GetLength(0) - 1;
    int stepNum = 0; // Общий счетчик 
    while (true)
    {
        if (currentDirection == 0 || currentDirection == 2)
            lengthToGo = toStepX;
        else
            lengthToGo = toStepY;
        for (int i = 0; i < lengthToGo; i++)
        {
            outputArray[y,x] = inputArray[stepNum];
            x += directionMultiplier[currentDirection,1];
            y += directionMultiplier[currentDirection,0];
            stepNum++;  
        }
        if (currentDirection == 0 || currentDirection == 2)
            toStepY = --toStepY;
        else 
            if (currentDirection == 1 || currentDirection == 3)
                toStepX = --toStepX;
        currentDirection++;
        if (currentDirection == 4) currentDirection = 0;
        if (outputArray[y,x] == 0)
        {
            outputArray[y,x] = inputArray[stepNum];
            x += directionMultiplier[currentDirection,1];
            y += directionMultiplier[currentDirection,0];
            stepNum++;
        }
        else
            return;
    }             
}


int[] ArrayFillNumbersInOrder(int startNum, int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = startNum + i;
    }
    return array;
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
    Console.WriteLine();
}