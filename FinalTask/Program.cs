string[] array = { "hello", "my", "world", "404", ":)", "GeekBrains" };


string[] FillArrayIf(string[] array)
{
    int length = array.Length;
    string[] newArray = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

void PrintArray(string[] array)
{
    string s = string.Join(", ", array);
    Console.WriteLine("[" + s + "]");

}

Console.Write($"Исходный массив: ");
PrintArray(array);
string[] sortArray = FillArrayIf(array);
Console.Write($"Новый массив: ");
PrintArray(sortArray);
