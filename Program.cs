void PrintArray(string[] text)
{
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{text[i]} ");
    }
    Console.WriteLine();
}

void ThreeSignStrings(string[] array)
{
    foreach (string element in array)
    {
        if (element.Length <= 3)
            Console.Write(element + " ");
    }
}

string[] textone = { "hello", "2", "world", ":-)" };
string[] texttwo = { "1234", "1567", "-2", "computer science" };
string[] textthree = { "Russia", "Denmark", "Kazan" };

PrintArray(textone);
Console.WriteLine();
ThreeSignStrings(textone);
Console.ReadLine();
PrintArray(texttwo);
Console.WriteLine();
ThreeSignStrings(texttwo);
Console.ReadLine();
PrintArray(textthree);
Console.WriteLine();
ThreeSignStrings(textthree);
