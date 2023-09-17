// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int symbolLimit = 3;

string[] CreateManualStringArray(int size)
{
    string[] newArray = new string[size];
    Console.WriteLine("Input your strings:");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

int GetSizeModArr(string[] array, int symbolLimit)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbolLimit) size += 1;
    }
    return size;
}

string[] CutArray(string[] sourceArray, int symbolLimit)
{
    string[] newArray = new string[GetSizeModArr(sourceArray, symbolLimit)];
    int startItem = 0;
    for (int j = 0; j < newArray.Length; j++)
    {
        for (int i = startItem; i < sourceArray.Length; i++)
        {
            if (sourceArray[i].Length <= symbolLimit)
            {
                newArray[j] = sourceArray[i];
                startItem = i + 1;
                break;
            }
        }
    }
    return newArray;
}

Console.WriteLine("Specify the number of strings:");
int size = Convert.ToInt32(Console.ReadLine());
string[] sourceArray = CreateManualStringArray(size);
PrintArray(sourceArray);
Console.WriteLine();
PrintArray(CutArray(sourceArray,symbolLimit));