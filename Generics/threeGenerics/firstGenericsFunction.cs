using System.Collections.Generic;

public static void CopyAnimals(List<Dog> src, List<Animal> dst)
{
    foreach (Dog dog in src)
    {
        dst.Add(dog);
    }
}