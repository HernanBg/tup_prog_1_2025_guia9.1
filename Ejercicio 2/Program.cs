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

            
            int indiceMayor = 0;
            int indiceMenor = 0;

            for (int i = 1; i < cantidad; i++)
            {
                if (notas[i] > notas[indiceMayor])
                    indiceMayor = i;

                if (notas[i] < notas[indiceMenor])
                    indiceMenor = i;
            }

            Console.WriteLine($"\nAlumno con mayor nota:");
            Console.WriteLine($"Nombre: {nombres[indiceMayor]}");
            Console.WriteLine($"Libreta: {libretas[indiceMayor]}");
            Console.WriteLine($"Nota: {notas[indiceMayor]}");

            Console.WriteLine($"\nAlumno con menor nota:");
            Console.WriteLine($"Nombre: {nombres[indiceMenor]}");
            Console.WriteLine($"Libreta: {libretas[indiceMenor]}");
            Console.WriteLine($"Nota: {notas[indiceMenor]}");
        }
    }
}
