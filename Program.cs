internal class Program
{
    private static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("============Fibonacci=============\n");
            Console.WriteLine("1. Entregar como salida el n-ésimo número de Fibonacci:");
            Console.WriteLine("2. Indique si es o no un número de Fibonacci:");
            Console.WriteLine("3. muestres los m primeros números de Fibonacci:");
            Console.WriteLine("4. Salir\n");
            Console.Write("Elige una de las opciones:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:

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
                    break;

                case 2:
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
                    break;

                case 3:
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
                    break;
                case 4:
                    Console.WriteLine("Bye 👋");
                    salir = true;  
                break;  
            }
        }
    }
}
