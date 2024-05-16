namespace Searching;

public static class BinarySearch
{
  public static bool BinSearch<T>(List<T> lst, T target) where T : IComparable
  {
    int low = 0;
    int high = lst.Count - 1;

    while (low <= high)
    {
      int mid = (low + high) / 2;
      if (lst[mid].CompareTo(target) == 0)
      {
        return true;
      }

      if (lst[mid].CompareTo(target) < 0)
      {
        low = mid + 1;
      } else 
      {
        high = mid - 1;
      }
    }
    return false;
  }
}