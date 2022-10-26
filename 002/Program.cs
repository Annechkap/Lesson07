// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


Console.WriteLine("введите номер строки");
int lenRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int lenColumns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = CreateArray(10, 10);
PrintArray(numbers);

if (lenRows > numbers.GetLength(0) || lenColumns > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {lenRows} строки и {lenColumns} столбца равно {numbers[lenRows - 1, lenColumns - 1]}");
}