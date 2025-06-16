using System;

class Programa
{
    static void Main()
    {
        string[] nombres = new string[100];
        int[] libretas = new int[100];
        double[] notas = new double[100];

        int cantidad = 0;
        int libreta = 0;

        Console.WriteLine("Ingrese los datos de los alumnos (escriba -1 en número de libreta para terminar):");

        while (libreta != -1)
        {
            Console.Write("Nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Número de libreta: ");
            libreta = int.Parse(Console.ReadLine());

            if (libreta != -1)
            {
                Console.Write("Nota: ");
                double nota = double.Parse(Console.ReadLine());

                nombres[cantidad] = nombre;
                libretas[cantidad] = libreta;
                notas[cantidad] = nota;

                cantidad++;
                Console.WriteLine();
            }
        }

        if (cantidad == 0)
        {
            Console.WriteLine("No se ingresaron datos.");
        }
        else
        {
           
            double suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                suma += notas[i];
            }

            double promedio = suma / cantidad;
            Console.WriteLine($"\nPromedio de notas: {promedio:F2}");

            string[] nombresSuperan = new string[cantidad];
            int[] libretasSuperan = new int[cantidad];
            double[] notasSuperan = new double[cantidad];
            int contador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                if (notas[i] > promedio)
                {
                    nombresSuperan[contador] = nombres[i];
                    libretasSuperan[contador] = libretas[i];
                    notasSuperan[contador] = notas[i];
                    contador++;
                }
            }

            Console.WriteLine("\nAlumnos con nota mayor al promedio:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Libreta: {libretasSuperan[i]}, Nombre: {nombresSuperan[i]}, Nota: {notasSuperan[i]}");
            }
        }
    }
}