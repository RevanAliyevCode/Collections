
Console.Write("Write input: ");
string? input = Console.ReadLine();

Stack<char> reverse = new();
string reversed = "";

foreach (var item in input)
{
    reverse.Push(item);
}

while (reverse.Count > 0)
{
    reversed += reverse.Pop();
}

Console.WriteLine(reversed);