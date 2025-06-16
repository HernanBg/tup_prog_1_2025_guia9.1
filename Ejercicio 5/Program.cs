using System;

class Programa
{
    static void Main()
    {
        Random aleatorio = new Random();

        
        int[] numeros = new int[100];
        int cantidad = aleatorio.Next(10, 101);

        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = aleatorio.Next(1, 101);
        }

       
        string[] nombresBase = {
            "Noemí", "Noelía", "Andrés", "Emilio",
            "Norberto", "Estefanía", "Daniela", "Valeria"
        };

        
        string[] nombres = new string[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            int indiceNombre = aleatorio.Next(nombresBase.Length);
            nombres[i] = nombresBase[indiceNombre];
        }

      
        Console.WriteLine("Listado original:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i}: {numeros[i]} - {nombres[i]}");
        }

        
        int[] numerosBurbuja = new int[cantidad];
        string[] nombresBurbuja = new string[cantidad];
        int[] numerosQuick = new int[cantidad];
        string[] nombresQuick = new string[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            numerosBurbuja[i] = numeros[i];
            nombresBurbuja[i] = nombres[i];
            numerosQuick[i] = numeros[i];
            nombresQuick[i] = nombres[i];
        }

       
        BurbujaAscendente(numerosBurbuja, nombresBurbuja);
        Console.WriteLine("\nListado ordenado por Burbuja (número ascendente):");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i}: {numerosBurbuja[i]} - {nombresBurbuja[i]}");
        }

        
        QuickSortAscendente(numerosQuick, nombresQuick, 0, cantidad - 1);
        Console.WriteLine("\nListado ordenado por QuickSort (número ascendente):");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i}: {numerosQuick[i]} - {nombresQuick[i]}");
        }
    }

    static void BurbujaAscendente(int[] numeros, string[] nombres)
    {
        int n = numeros.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                   
                    int tempNum = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = tempNum;

                   
                    string tempNom = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tempNom;
                }
            }
        }
    }

  
    static void QuickSortAscendente(int[] numeros, string[] nombres, int izq, int der)
    {
        int i = izq, j = der;
        int pivote = numeros[(izq + der) / 2];

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

        if (izq < j)
            QuickSortAscendente(numeros, nombres, izq, j);
        if (i < der)
            QuickSortAscendente(numeros, nombres, i, der);
    }
}