using System;

class Programa
{
    static void Main()
    {
        Random aleatorio = new Random();

   
        string[] nombresDisponibles = { "Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria" };

    
        int cantidad = aleatorio.Next(10, 101);

        int[] numeros = new int[cantidad];
        string[] nombres = new string[cantidad];

     
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = aleatorio.Next(1, 101);
            nombres[i] = nombresDisponibles[aleatorio.Next(nombresDisponibles.Length)];
        }

        Console.WriteLine("Listado original:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i}: {numeros[i]} - {nombres[i]}");
        }

 
        int indiceAleatorio = aleatorio.Next(cantidad);
        int valorBuscado = numeros[indiceAleatorio];
        Console.WriteLine($"\nNúmero seleccionado al azar: {valorBuscado}");

        
        int posicionSecuencial = BusquedaSecuencial(numeros, valorBuscado);
        if (posicionSecuencial != -1)
        {
            Console.WriteLine($"[Búsqueda secuencial] Número {valorBuscado} encontrado en posición {posicionSecuencial} (Nombre: {nombres[posicionSecuencial]})");
        }
        else
        {
            Console.WriteLine("[Búsqueda secuencial] No se ha encontrado el número buscado.");
        }

       
        int[] numerosOrdenados = new int[cantidad];
        string[] nombresOrdenados = new string[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            numerosOrdenados[i] = numeros[i];
            nombresOrdenados[i] = nombres[i];
        }

        QuickSort(numerosOrdenados, nombresOrdenados, 0, cantidad - 1);

        Console.WriteLine("\nListado ordenado por número (QuickSort):");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i}: {numerosOrdenados[i]} - {nombresOrdenados[i]}");
        }

       
        int posicionBinaria = BusquedaBinaria(numerosOrdenados, valorBuscado);
        if (posicionBinaria != -1)
        {
            Console.WriteLine($"\n[Búsqueda binaria] Número {valorBuscado} encontrado en posición {posicionBinaria} (Nombre: {nombresOrdenados[posicionBinaria]})");
        }
        else
        {
            Console.WriteLine("\n[Búsqueda binaria] No se ha encontrado el número buscado.");
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
        int izquierda = 0, derecha = arreglo.Length - 1;

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

    
    static void QuickSort(int[] numeros, string[] nombres, int izquierda, int derecha)
    {
        int i = izquierda, j = derecha;
        int pivote = numeros[(izquierda + derecha) / 2];

        while (i <= j)
        {
            while (numeros[i] < pivote) i++;
            while (numeros[j] > pivote) j--;

            if (i <= j)
            {
               
                int tempNum = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = tempNum;

               
                string tempNom = nombres[i];
                nombres[i] = nombres[j];
                nombres[j] = tempNom;

                i++;
                j--;
            }
        }

        if (izquierda < j) QuickSort(numeros, nombres, izquierda, j);
        if (i < derecha) QuickSort(numeros, nombres, i, derecha);
    }
}