
string[,] CreateSourceArray(int rows = 3, int columns = 4)
{
    string[,] array = new string[3, 4]
    {
            { "Hello", "2", "world", ":-)" },
            { "1234", "1567", "-2", "computer science" },
            { "Russia", "Denmark", "Kazan", "" }
    };
    return array;
}

string[,] CreateArrayForCompare(int rows = 3, int columns = 3)
{
    string[,] array = new string[3, 3]
    {
        {"2", ":-)", ""},
        {"", "-2", ""},
        {"", "", ""}

    };
    return array;
}

string[,] CreateResultArray(string[,] sourceArray, string[,] arrayForCompare)
{
    int rows = sourceArray.GetLength(0);
    int cols = arrayForCompare.GetLength(1);
    string[,] resultArray = new string[rows, cols];

    for (int i = 0; i < arrayForCompare.GetLength(0); i++)
    {
        int matchIndex = 0; // индекс для добавления совпадающих элементов в resultArray

        for (int j = 0; j < sourceArray.GetLength(1); j++)
        {
            for (int k = 0; k < arrayForCompare.GetLength(1); k++)
            {
                if (sourceArray[i, j] == arrayForCompare[i, k])
                {
                    if (matchIndex < cols) // проверка в конце массива
                    {
                        resultArray[i, matchIndex] = sourceArray[i, j];
                        matchIndex++;
                    }
                    break;
                }
            }
        }

        // Заполнение оставшихся ячеек пустыми строками, если совпадений меньше, чем столбцов
        while (matchIndex < cols)
        {
            resultArray[i, matchIndex] = "";
            matchIndex++;
        }
    }

    return resultArray;
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Создание исходного массива
string[,] source = CreateSourceArray();

// Создание массива для сравнения
string[,] compare = CreateArrayForCompare();

// Создание результирующего массива
string[,] resultArray = CreateResultArray(source, compare);

// Вывод массивов
Console.WriteLine("Исходный массив:");
PrintArray(source);
Console.WriteLine("Массив для сравнения:");
PrintArray(compare);
Console.WriteLine("Результирующий массив:");
PrintArray(resultArray);