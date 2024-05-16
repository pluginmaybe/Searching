using System.Text;

namespace Searching;

public class LinkList<T> where T : IComparable
{
  private class Node
  {
    public Node? Next;
    //public Node? Previous;
    
    public required T Value;
  }

  private Node? _head;
  public LinkList(T value)
  {
    _head = new() { Value = value };
    Console.WriteLine($"New List : Initial Head value : {value}");
  }

  public bool IsEmpty()
  {
    return _head == null || _head.Value == null;
  }
  public override string ToString()
  {
    if (IsEmpty())
    {
      return "Empty List";
    }
    Node node = _head!;
    StringBuilder sb = new();
    sb.Append("List: HEAD > ");
    
    while (true)
    {
      sb.Append(node.Value.ToString() + " ");
      if (node.Next == null)
      {
        break;
      }
      node = node.Next;
    }
    sb.Append("< TAIL");
    return sb.ToString();
  }
  public void AddToTail(T value)
  {
    Console.WriteLine($"ADD > {value} < TO TAIL");
    Node newNode = new() { Value = value };
    if (IsEmpty()) 
    {
      _head = newNode;
      _head.Next = null;
      return;
    }
    Node node = _head!;
    while (node.Next != null)
    {
      node = node.Next;
    }
    node.Next = newNode;
  }
  public void AddToHead(T value)
  {
    Console.WriteLine($"ADD > {value} < TO HEAD");
    Node newNode = new() { Value = value };
    if (IsEmpty()) 
    {
      _head = newNode;
      _head.Next = null;
      return;
    }
    newNode.Next = _head;
    _head = newNode;
  }
  public T PeakHead()
  {
    if (IsEmpty())
    {
      throw new Exception("List is empty");
    }
    return _head!.Value!;
  }
  public bool Contains(T target)
  {
    Console.WriteLine($"SEARCHING LIST FOR > {target} <");
    if (IsEmpty())
    {
      return false;
    }
    Node node = _head!;
    while (true)
    {
      if (node.Value == null) 
      {
        throw new Exception("node value is null");
      }
      if (node.Value.CompareTo(target) == 0)
      {
        return true;
      }
      if (node.Next == null)
      {
        break;
      }
      node = node.Next;
    }
    return false;
  }
  public T RemoveHead()
  {
    Console.WriteLine("REMOVE HEAD");
    if (IsEmpty())
    {
      throw new Exception("Empty List");
    }
    Node node = _head!;
    _head = node.Next;
    return node.Value;
  }
  public T RemoveTail()
  {
    Console.WriteLine("REMOVE TAIL");
    if (IsEmpty()) 
    { 
      throw new Exception("Empty List"); 
    }
    if (_head!.Next == null)
    {
      T val = _head!.Value!;
      _head = null;
      return val;
    }
    Node node = _head;
    while (true)
    {
      if (node.Next!.Next == null)
      {
        T val = node.Next.Value!;
        node.Next = null;
        return val;
      }
      node = node.Next;
    }
  }
  public bool RemoveValue(T target)
  {
    Console.WriteLine($"REMOVE BY VALUE > {target} <");
    if (IsEmpty())
    {
      return false;
    }
    if (_head!.Value!.CompareTo(target) == 0)
    {
      _head = _head.Next;
      return true;
    }  
    Node prev = _head;
    Node? node = _head.Next;

    while (node != null)
    {
      if (node.Value == null)
      {
        throw new Exception("Null value");
      }
      if (node.Value.CompareTo(target) == 0)
      {
        prev.Next = node.Next;
        return true;
      }
      prev = node;
      node = node.Next;
    }
    return false;
  }
}