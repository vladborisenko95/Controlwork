string[] a = CreateArray();
Console.WriteLine();
Console.WriteLine(string.Join(", ", a));
string[] b = SortedArray(a);
Console.WriteLine(string.Join(", ", b));

string[] CreateArray()
{
    Console.WriteLine("Введите длину масива строк");
    string[] newArray = new string[IntPositiveValue()];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива");
        newArray[i] = (Console.ReadLine());
        Console.WriteLine();
    }
    return newArray;
}

string[] SortedArray(string[] incomingArray)
{
    int cul = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i].Length < 4) cul++;
    }
    string[] newArray = new string[cul];
    cul = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i].Length < 4)
        {
            newArray[cul] = incomingArray[i];
            cul++;
        }
    }
    return newArray;
}

int IntPositiveValue()
{
    int intLengthArray;
    bool check = int.TryParse(Console.ReadLine(), out intLengthArray);
    if (check && intLengthArray > 0) return intLengthArray;
    else
    {
        Console.WriteLine("Ошибка! Введите положительное чило больше 0");
        return IntPositiveValue();
    }
}