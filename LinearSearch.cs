namespace Searching;

public static class LinearSearch
{
  public static bool LinSearch<T>(List<T> lst, T target) where T : IComparable
  {
    int idx = 0;
    while (idx < lst.Count)
    {
      if (lst[idx].Equals(target))
      {
        return true;
      }
      idx++;
    }
    return false;
  }
}