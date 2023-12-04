# Fibonacci

##### Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci:

```csharp
    List<int> lista1 = new List<int>() { 0, 1 };
    int cont1 = 0;
    Console.Write("Ingrese un número (n): ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= num1; i++)
    {
        cont1 = lista1[i - 1] + lista1[i - 2];
        lista1.Add(cont1);
    }
    Console.WriteLine($"F{num1} = {lista1[num1]}");
    Console.ReadLine();
```

##### Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci:

```csharp
    List<int> lista2 = new List<int>() { 0, 1 };
    int cont = 0;
    Console.Write("Ingrese un número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= num; i++)
    {
        cont = lista2[i - 1] + lista2[i - 2];
        lista2.Add(cont);
    }
    if (lista2.Contains(num))
    {
        Console.Clear();
        Console.WriteLine($"El numero {num} pertenece a la serie fibonacci");
        Console.ReadLine();
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"El numero {num} no pertenece a la serie fibonacci");
        Console.ReadLine();
    }
```

##### Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario:

```csharp
    List<int> lista3 = new List<int>() { 0, 1 };
    int cont3 = 0;
    Console.Write("Ingrese un número (n): ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= num3; i++)
    {
        cont3 = lista3[i - 1] + lista3[i - 2];
        lista3.Add(cont3);
    }
    foreach (var item in lista3)
    {
        Console.Write($"{item},");
    }
```