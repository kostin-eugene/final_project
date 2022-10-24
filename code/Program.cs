string[] array = UserArray();
string[] FinalArray = LessThan3(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", FinalArray)}]");

string[] LessThan3(string[] input, int n)
{
    string[] output = new string[CountLessThan(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] UserArray()
{
    Console.Write("Введите значения массива используя пробел: ");
    return Console.ReadLine()!.Split(' ');
}