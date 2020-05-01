## Big O

Big O é uma notação usada dentro da Ciência da Computação para descrever o comportamento de uma função quando o argumento tende para um valor em particular ou para o infinito _(Wikipedia)_. Usamos Big O para descrever a performance de um algoritmo. Desta forma saberemos se este algoritmo irá escalar se o input de dados aumentar consideravelmente.

### Constante

```csharp
public void PrintFirst(string[] names)
{
    Console.WriteLine(names[0]);
}
```

### Linear

```csharp
public void PrintAll(string[] names)
{
    foreach(var name in names)
        Console.WriteLine(name);
}
```

### Quadrático: o(n²)

```csharp
public void PrintAllWithAge(string[] names, int[] ages)
{
    foreach(var name in names)
        foreach(var age in ages)
            Console.WriteLine($"{name}: {age}");
}
```

### Logarítmico

```csharp
public void BinarySearch(int[] numbers)
{
    // ...
}
```
