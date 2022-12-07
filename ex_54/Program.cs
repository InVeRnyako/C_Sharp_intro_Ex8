// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] matrix = GenerateArrayWithNumbers(GetIntNatFromUser("Введите количество строк массива: "), 
                GetIntNatFromUser("Введите количество столбцов массива: "),
                10, 50);
PrintArray(matrix); 


SortLinesInArray(matrix);
PrintArray(matrix);




void SortLinesInArray(int[,] array) // Пузырьковый метод сортировки
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k + 1] > array[i, k])
                {
                    temp = array [i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }                
            }
        }
    }
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
