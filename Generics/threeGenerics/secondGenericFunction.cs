using System.Collections.Generic;

public static void FillWithCats(List<Animal> dst)
{
    dst.Clear();
    dst.Add(new Cat("Cat 1"));
    dst.Add(new Cat("Cat 2"));
    dst.Add(new Cat("Cat 3"));
}