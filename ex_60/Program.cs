// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] matrix = GenerateArrayWithUniqueNumbers(5, 9, 2); // Произведение не может быть больше 90
PrintArrayWithIndex(matrix);

void PrintArrayWithIndex(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} - id [{i}, {j}, {k}]");
            }
        }
    }
}

int[,,] GenerateArrayWithUniqueNumbers(int x, int y, int z)
{
    bool[] uniqueNumCheck = new bool[90]; // default bool - false.
    int[,,] outPutArray = new int[x, y, z];
    int temp;
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while (true) // Генерирование числа и проверка на уникальность
                {
                    temp = rnd.Next(10,100);
                    if (!uniqueNumCheck[temp-10]) 
                    {
                        outPutArray[i,j,k] = temp;
                        uniqueNumCheck[temp-10] = true;
                        break;
                    }
                }
            }
        }
    }
    return outPutArray;
}

