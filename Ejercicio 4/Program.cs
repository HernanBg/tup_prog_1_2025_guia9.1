using System;

class Programa
{
    static void Main()
    {
        Random aleatorio = new Random();

        // a) Generar una cantidad entre 10 y 100
        int cantidad = aleatorio.Next(10, 101);

        // Crear el arreglo original y llenarlo con números aleatorios entre 0 y 200
        int[] original = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            original[i] = aleatorio.Next(0, 201);
        }

        // b) Mostrar el arreglo original
        Console.WriteLine("Arreglo original:");
        MostrarArreglo(original);

        // c) Ordenar con burbuja de mayor a menor (hacemos una copia)
        int[] arregloBurbuja = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arregloBurbuja[i] = original[i];
        }

        BurbujaMayorAMenor(arregloBurbuja);
        Console.WriteLine("\nArreglo ordenado con burbuja (mayor a menor):");
        MostrarArreglo(arregloBurbuja);

        // d) Ordenar con quicksort de menor a mayor (hacemos otra copia)
        int[] arregloQuick = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arregloQuick[i] = original[i];
        }

        QuickSortMenorAMayor(arregloQuick, 0, cantidad - 1);
        Console.WriteLine("\nArreglo ordenado con quicksort (menor a mayor):");
        MostrarArreglo(arregloQuick);

        // e) Buscar un número aleatorio
        int numeroBuscado = aleatorio.Next(0, 201);
        Console.WriteLine($"\nNúmero a buscar: {numeroBuscado}");

        int posicion = BuscarNumero(arregloQuick, numeroBuscado);

        if (posicion != -1)
        {
            Console.WriteLine($"El número {numeroBuscado} se encontró en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine("Número no encontrado.");
        }
    }

    static void MostrarArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write($"{i}:{arreglo[i]}  ");
        }
        Console.WriteLine();
    }

    static void BurbujaMayorAMenor(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - 1 - i; j++)
            {
                if (arreglo[j] < arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSortMenorAMayor(int[] arreglo, int izquierda, int derecha)
    {
        int i = izquierda;
        int j = derecha;
        int pivote = arreglo[(izquierda + derecha) / 2];

        while (i <= j)
        {
            while (arreglo[i] < pivote) i++;
            while (arreglo[j] > pivote) j--;

            if (i <= j)
            {
                int temp = arreglo[i];
                arreglo[i] = arreglo[j];
                arreglo[j] = temp;
                i++;
                j--;
            }
        }

        if (izquierda < j) QuickSortMenorAMayor(arreglo, izquierda, j);
        if (i < derecha) QuickSortMenorAMayor(arreglo, i, derecha);
    }

    static int BuscarNumero(int[] arreglo, int numero)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
} 