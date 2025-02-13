using System;

class Program
{
    static void Main()
    {
        // Solicitar el primer valor numérico
        Console.Write("Ingrese el primer valor numérico: ");
        int valor1 = int.Parse(Console.ReadLine());

        // Solicitar el segundo valor numérico
        Console.Write("Ingrese el segundo valor numérico: ");
        int valor2 = int.Parse(Console.ReadLine());

        // Comparaciones
        if (valor1 > valor2)
        {
            Console.WriteLine($"{valor1} es mayor que {valor2}");
        }
        else if (valor1 < valor2)
        {
            Console.WriteLine($"{valor1} es menor que {valor2}");
        }
        else
        {
            Console.WriteLine($"{valor1} es igual a {valor2}");
        }

        // Uso de AND (&&)
        if (valor1 > 0 && valor2 > 0)
        {
            Console.WriteLine("Ambos valores son positivos.");
        }
        else
        {
            Console.WriteLine("Al menos uno de los valores no es positivo.");
        }

        // Uso de OR (||)
        if (valor1 < 0 || valor2 < 0)
        {
            Console.WriteLine("Al menos uno de los valores es negativo.");
        }
        else
        {
            Console.WriteLine("Ninguno de los valores es negativo.");
        }
    }
}