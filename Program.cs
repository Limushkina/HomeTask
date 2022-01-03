
int[] CreateArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++) 
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

int[] NewArray(int[] array)
{
    int[] array2 = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array2[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);
    return array2;
}
PrintArray(CreateArray(1));
PrintArray(NewArray(1));

