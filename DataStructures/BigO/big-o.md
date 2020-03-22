## Big O

Big O é uma notação usada dentro da Ciência da Computação para descrever o comportamento de uma função quando o argumento tende para um valor em particular ou para o infinito _(Wikipedia)_. Usamos Big O para descrever a performance de um algoritmo. Desta forma saberemos se este algoritmo irá escalar se o input de dados aumentar consideravelmente.

### Constante

Dizemos que um algoritmo tem complexidade constante quando ele usará a mesma quantidade de processamento independente da quantidade de inputs.

```csharp
public void PrintFirst(string[] names)
{
    Console.WriteLine(names[0]);
}
```

Neste exemplo, independente do tamanho do Array _names_, a função sempre irá exibir na tela o primeiro item. Sendo assim, sua complexidade é de **o(1)**

### Linear

Um algoritmo de complexidade linear se refere quando a quantidade de processamento deste será igual á quantidade de inputs.

```csharp
public void PrintAll(string[] names)
{
    foreach(var name in names)
        Console.WriteLine(name);
}
```

Vemos que na função _PrintAll_ irá exibir na tela todos os nomes passados para ela. Se a quantidade de items for 5, ela será o(5), se for 1000000, será o(1000000). Sendo assim sua complexidade é de o(n).

### Quadrático: o(n²)

Quando um algoritmo de complexidade quadrática se da quando o processamento depende de dados relacionados

```csharp
public void PrintAllWithAge(string[] names, int[] ages)
{
    foreach(var name in names)
        foreach(var age in ages)
            Console.WriteLine($"{name}: {age}");
}
```

Neste exemplo, para todo name percorremos o array _ages_ por completo. Sendo assim sua complexidade é _names * ages_, _n * n_ ou simplesmente __o(n²)__

### Logarítmico

Algoritmo de complexidade logarítmica tende a usar fatores de grandeza menos processamento do que a quantidade de que esteja operado

```csharp
public void BinarySearch(int[] numbers)
{
    for()
}
```
 
### Exponencial: o(2n)
