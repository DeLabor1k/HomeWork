using System.Collections.Generic;

public static void SafeTransfer<T>(IEnumerable<T> src, ICollection<T> dst)
{
    foreach (T item in src)
    {
        dst.Add(item);
    }
}