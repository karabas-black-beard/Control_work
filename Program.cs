string[] InputArr(int n)
{
    string[] arrString = new string[n];
    Console.WriteLine("Ввести массив:");
    for (int i = 0; i < arrString.Length; i++)
    {
        Console.Write($"arrString[{i}] = ");
        arrString[i] = Console.ReadLine()!;
    }
    return arrString;
}

void PrintArr(string[] arrString)
{
    for (int i = 0; i < arrString.Length; i++)
    {
        System.Console.Write(arrString[i] + " ");
    }
    System.Console.WriteLine();
}

string[] SortArr(string[] arrString)
{
    string[] NewArrString = new string[arrString.Length];
    int count = 0;
    for (int i = 0; i < arrString.Length; i++)
        if (arrString[i].Length <= 3)
        {
            NewArrString[count] = arrString[i];
            count++;
        }
    return NewArrString;
}

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
if (n <= 0)
{
    Console.WriteLine("маловато будет!");
    return;
}
string[] myArr = InputArr(n);
PrintArr(SortArr(myArr));