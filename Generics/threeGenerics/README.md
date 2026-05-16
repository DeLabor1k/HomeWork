# CopyAnimals

## Описание
Статический метод, который копирует всех собак из исходного списка в целевой список животных.

## Сигнатура
`public static void CopyAnimals(List<Dog> src, List<Animal> dst)`

## Параметры
- **src** - исходный список собак (источник)
- **dst** - целевой список животных (приёмник)

## Реализация
```csharp
using System.Collections.Generic;

public static void CopyAnimals(List<Dog> src, List<Animal> dst)
{
    foreach (Dog dog in src)
    {
        dst.Add(dog);
    }
}
```
---
# FillWithCats

## Описание
Статический метод, который очищает список и заполняет его тремя новыми объектами `Cat`.

## Сигнатура
`public static void FillWithCats(List<Animal> dst)`

## Параметры
- **dst** - список для заполнения котами

## Реализация
```csharp
using System.Collections.Generic;

public static void FillWithCats(List<Animal> dst)
{
    dst.Clear();
    dst.Add(new Cat("Cat 1"));
    dst.Add(new Cat("Cat 2"));
    dst.Add(new Cat("Cat 3"));
}
```
---
# SafeTransfer

## Описание
Обобщённый статический метод, который переносит все элементы из исходной коллекции в целевую коллекцию.

## Сигнатура
`public static void SafeTransfer<T>(IEnumerable<T> src, ICollection<T> dst)`

## Параметры
- **src** - исходная коллекция (только для чтения)
- **dst** - целевая коллекция (поддерживает добавление)
- **T** - параметр типа элементов коллекций

## Реализация
```csharp
using System.Collections.Generic;

public static void SafeTransfer<T>(IEnumerable<T> src, ICollection<T> dst)
{
    foreach (T item in src)
    {
        dst.Add(item);
    }
}
```
