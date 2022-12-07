// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Квадрат - частный случай прямоугольника.
Console.Clear();

int[,] matrix = GenerateArrayWithNumbers(GetIntNatFromUser("Введите количество строк массива: "), 
                GetIntNatFromUser("Введите количество столбцов массива: "),
                10, 50);

PrintArray(matrix); 

Console.WriteLine($"Строка с наименьшей суммой элементов - #{LeastSumOfArrayLines(matrix) + 1}");



int LeastSumOfArrayLines(int[,] array)
{
    int tempSum;
    int lineId = 0;
    int minSum = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i,j];
        }
        // Console.WriteLine($"{i} -> {tempSum}"); // Вывод суммы элементов строк
        if (tempSum < minSum || minSum == -1)
        {
            minSum = tempSum;
            lineId = i;
        }
    }
    return lineId;
}

int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}

int[,] GenerateArrayWithNumbers(int arrayRows, int arrayColumns, int lowLimit, int highLimitIncluded)
{
    Random rnd = new Random();
    int[,] generatedArray = new int[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
		generatedArray[i,j] = rnd.Next(lowLimit, highLimitIncluded + 1);
    }
    return generatedArray;
}

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
