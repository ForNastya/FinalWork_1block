// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
int Size(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    return size;
}

void FillArray(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

Console.WriteLine (" Array: ");
string[] arrayA = { "1234", "Hello world", "+5", "923", ":-)"};
PrintArray(arrayA);
int Array = Size(arrayA);
string[] arrayB = new string[Array];
FillArray(arrayA, arrayB);
Console.WriteLine(" Array by task ");
PrintArray(arrayB);

