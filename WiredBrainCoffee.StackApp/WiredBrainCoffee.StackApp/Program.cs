// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

StackDoubles();
StackStrings();
Console.ReadLine();

void StackDoubles()
{
    var stack = new SimpleStack<double>();
    stack.Push(1.2);
    stack.Push(2.8);
    stack.Push(3.0);

    double sum = 0.0;

    while (stack.Count > 0)
    {
        var item = stack.Pop();
        Console.WriteLine($"Item: {item}");
        sum += item;
    }

    Console.WriteLine($"Sum: {sum}");
}

void StackStrings()
{
    var stack = new SimpleStack<string>();
    stack.Push("Wired Brain Coffee");
    stack.Push("Pluralsight");
}