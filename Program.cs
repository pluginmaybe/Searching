namespace Searching;

class Program
{
    public delegate bool PerformSearch<T>(List<T> values, T target);
    static void Main(string[] args)
    {

        List<int> ints = [3, 4, 6, 8, 11, 14, 33, 36];
        DisplayHeader("Binary Search");
        SearchTester(BinarySearch.BinSearch, ints, 12);
        SearchTester(BinarySearch.BinSearch, ints, 14);

        DisplayHeader("Linear Search");
        SearchTester(LinearSearch.LinSearch, ints, 12);
        SearchTester(LinearSearch.LinSearch, ints, 14);

        LinkList<int> lst = new(2);
        lst.AddToTail(3);
        lst.AddToTail(4);
        lst.AddToTail(5);
        lst.AddToTail(6);
        lst.AddToTail(7);
        lst.AddToTail(8);
        lst.AddToTail(9);
        DisplayHeader("Linked List");
        Console.WriteLine(lst);
        Console.WriteLine($"List contains 0 : {lst.Contains(0)}");
        Console.WriteLine($"List contains 7 : {lst.Contains(7)}");
        lst.RemoveValue(5);
        Console.WriteLine(lst);

    }
    static void SearchTester<T>(PerformSearch<T> f,List<T> values, T target) where T : IComparable
    {
        Console.WriteLine("Test List : ");
        foreach (T value in values)
        {
            Console.Write(value + " ");
        }
        Console.Write($"\nSearching for {target} : ");
        Console.WriteLine(f(values, target));
    }
    static void DisplayHeader(string s)
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(s);
        Console.ResetColor();
        Console.WriteLine();
    }
}
