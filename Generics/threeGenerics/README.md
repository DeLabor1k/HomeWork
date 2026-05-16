# CopyAnimals - копирование списка собак

## Описание

Статический метод, который копирует всех собак из исходного списка в целевой список животных.

## Сигнатура

```csharp
public static void CopyAnimals(List<Dog> src, List<Animal> dst)
```
----


---

```markdown
# FillWithCats - заполнение списка котами

## Описание

Статический метод, который очищает список и заполняет его тремя новыми объектами `Cat`.

## Сигнатура

```csharp
public static void FillWithCats(List<Animal> dst)

----


---

```markdown
# SafeTransfer - безопасный перенос элементов

## Описание

Обобщённый статический метод, который переносит все элементы из исходной коллекции в целевую коллекцию.

## Сигнатура

```csharp
public static void SafeTransfer<T>(IEnumerable<T> src, ICollection<T> dst)
