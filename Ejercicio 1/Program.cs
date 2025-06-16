using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[100];
        int cantidad = 0;

        Console.WriteLine("Ingrese numeros enteros (ingrese -1 para termianr)");

        int numeroingresado = 0;

        while (cantidad < 100 && numeroingresado != -1)
        {
            Console.WriteLine($"Numero {cantidad + 1 }: ");
            numeroingresado = int.Parse( Console.ReadLine() );

            if ( numeroingresado != -1 )
            {
                numeros[cantidad] = numeroingresado;
                cantidad++;
            }
        }

        if (cantidad == 0)
        {
            Console.WriteLine("No se ingresaron numeros");
            return;
        }

        Console.WriteLine("/nNumeros Ingresados ");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Indice {i} : {numeros[i]}");

        }

        int suma = 0;
        int maximo = numeros[0];
        int minimo = numeros[1];
        int indiceMax = 0;
        int  indiceMin = 0;

        for (int i = 0;i < cantidad ;i++)
        {
            suma += numeros[i];

            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
                indiceMax = i;
            }
            if ( numeros[i] < minimo)
            {
                minimo = numeros[i];
                indiceMin = i;
            }
        }
        double promedio = (double)suma / cantidad;

        Console.WriteLine($"/nPromedio: {promedio:F2}");
        Console.WriteLine($"Maximo:{maximo} en indice {indiceMax}");
        Console.WriteLine($"Minimo:{minimo} en indice {indiceMin}");

    }

}