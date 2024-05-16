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

        DisplayHeader("Linked List");
        LinkedListTester();
    }
    
    static void LinkedListTester()
    {
        LinkList<int> lst = new(1);
        lst.AddToTail(5);
        lst.AddToTail(7);
        lst.AddToHead(8);
        lst.AddToTail(9);
       
        Console.WriteLine(lst);
        Console.WriteLine(lst.Contains(0));
        Console.WriteLine(lst.Contains(7));
        lst.RemoveValue(5);
        Console.WriteLine(lst);
        lst.RemoveTail();
        Console.WriteLine(lst);
        lst.RemoveHead();
        Console.WriteLine(lst);
        lst.RemoveHead();
        Console.WriteLine(lst);
        lst.RemoveHead();
        Console.WriteLine(lst);
        lst.AddToTail(99);
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
