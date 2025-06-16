using System;

class Programa
{
    static void Main()
    {
        int[] numeros = new int[30];
        int cantidad = 30;

        
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = i + 1;
        }

        Random aleatorio = new Random();

        Console.WriteLine("Extrayendo 10 números aleatorios únicos:\n");

        for (int i = 0; i < 10; i++)
        {
            
            int indice = aleatorio.Next(0, cantidad);

          
            Console.WriteLine($"Número extraído: {numeros[indice]}");

            
            numeros[indice] = numeros[cantidad - 1];

          
            cantidad--;
        }
    }
}