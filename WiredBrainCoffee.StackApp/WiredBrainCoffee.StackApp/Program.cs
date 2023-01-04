// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var stack = new SimpleStack();
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
Console.ReadLine();