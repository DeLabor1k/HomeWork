using System.Collections.Generic;

public static void FillWithCats<T>(List<T> dst) where T : Animal
{
    dst.Clear();
    dst.Add((T)(object)new Cat("Cat 1"));
    dst.Add((T)(object)new Cat("Cat 2"));
    dst.Add((T)(object)new Cat("Cat 3"));
}
