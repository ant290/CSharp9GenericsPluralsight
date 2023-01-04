public class SimpleStack
{
    private readonly double[] _items;
    private int _currentIndex =  -1;

    public SimpleStack() => _items = new double[10];

    public int Count => _currentIndex +1;

    public void Push(double item) =>
        // using ++ before the variable will cause it to be incremented before the rest of the line is run
        // this way it will have the value incremented before trying to find that location in the array
        _items[++_currentIndex] = item;

    public double Pop() => 
        // using -- after the variable will decrement it after the rest of the line is run
        // this way it will get the item and after reduce the size of _currentIndex
        _items[_currentIndex--];
}