using System;

class Programa
{
    static void Main()
    {
        Random aleatorio = new Random();
        int[] numeros = new int[30];

        
        for (int i = 0; i < 30; i++)
        {
            numeros[i] = i + 1;
        }

       
        int[] seleccionados = new int[10];
        int cantidadActual = 30;

        for (int i = 0; i < 10; i++)
        {
            int indiceAleatorio = aleatorio.Next(cantidadActual);
            seleccionados[i] = numeros[indiceAleatorio];

           
            numeros[indiceAleatorio] = numeros[cantidadActual - 1];
            cantidadActual--;
        }

        Console.WriteLine("Números seleccionados:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(seleccionados[i] + " ");
        }
        Console.WriteLine();

       
        double suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += seleccionados[i];
        }
        double promedio = suma / 10;

        Console.WriteLine($"\nPromedio: {promedio:F2}");

      
        int[] mayoresAlPromedio = new int[10];
        int contador = 0;
        for (int i = 0; i < 10; i++)
        {
            if (seleccionados[i] > promedio)
            {
                mayoresAlPromedio[contador] = seleccionados[i];
                contador++;
            }
        }

        Console.WriteLine("Números mayores al promedio:");
        for (int i = 0; i < contador; i++)
        {
            Console.Write(mayoresAlPromedio[i] + " ");
        }

        
        Console.WriteLine("\n\nFiltrado por rango:");

        Console.Write("Ingrese el valor mínimo: ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo: ");
        int maximo = int.Parse(Console.ReadLine());

        int[] enRango = new int[10];
        int contadorRango = 0;

        for (int i = 0; i < 10; i++)
        {
            if (seleccionados[i] >= minimo && seleccionados[i] <= maximo)
            {
                enRango[contadorRango] = seleccionados[i];
                contadorRango++;
            }
        }

        Console.WriteLine("Números dentro del rango:");
        for (int i = 0; i < contadorRango; i++)
        {
            Console.Write(enRango[i] + " ");
        }

        Console.WriteLine();
    }
}
