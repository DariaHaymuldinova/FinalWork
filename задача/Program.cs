Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Console.ReadLine();
}

printArray(array);

Console.WriteLine($"\nОтсортированный массив: ");

shortWorldsArray(array);

void shortWorldsArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length < 4)
        {
            Console.Write(array[i] + " ");
        }
    }
}

void printArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}
