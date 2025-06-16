using System;

class Programa
{
    static void Main()
    {
        Random aleatorio = new Random();

       
        int cantidad = aleatorio.Next(10, 101);
        int[] arreglo = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = aleatorio.Next(0, 201); 
        }

     
        Console.WriteLine("Arreglo generado:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"{i}:{arreglo[i]}  ");
        }

        
        int indiceAleatorio = aleatorio.Next(0, cantidad);
        int valorBuscado = arreglo[indiceAleatorio];
        Console.WriteLine($"\n\nValor seleccionado al azar del arreglo: {valorBuscado}");

        int posicionSecuencial = BusquedaSecuencial(arreglo, valorBuscado);

        if (posicionSecuencial != -1)
        {
            Console.WriteLine($"[Búsqueda secuencial] El valor {valorBuscado} fue encontrado en la posición {posicionSecuencial}.");
        }
        else
        {
            Console.WriteLine("[Búsqueda secuencial] No se ha encontrado el valor buscado.");
        }

        
        int[] arregloOrdenado = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arregloOrdenado[i] = arreglo[i];
        }

        QuickSort(arregloOrdenado, 0, cantidad - 1);

        Console.WriteLine("\nArreglo ordenado (para búsqueda binaria):");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"{i}:{arregloOrdenado[i]}  ");
        }

       
        int posicionBinaria = BusquedaBinaria(arregloOrdenado, valorBuscado);

        if (posicionBinaria != -1)
        {
            Console.WriteLine($"\n[Búsqueda binaria] El valor {valorBuscado} fue encontrado en la posición {posicionBinaria}.");
        }
        else
        {
            Console.WriteLine("\n[Búsqueda binaria] No se ha encontrado el valor buscado.");
        }
    }

   
    static int BusquedaSecuencial(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
                return i;
        }
        return -1;
    }

    static int BusquedaBinaria(int[] arreglo, int valor)
    {
        int izquierda = 0;
        int derecha = arreglo.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arreglo[medio] == valor)
                return medio;
            else if (arreglo[medio] < valor)
                izquierda = medio + 1;
            else
                derecha = medio - 1;
        }

        return -1;
    }

    
    static void QuickSort(int[] arreglo, int izq, int der)
    {
        int i = izq, j = der;
        int pivote = arreglo[(izq + der) / 2];

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

        if (izq < j) QuickSort(arreglo, izq, j);
        if (i < der) QuickSort(arreglo, i, der);
    }
}