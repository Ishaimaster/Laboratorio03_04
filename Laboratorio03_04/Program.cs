// See https://aka.ms/new-console-template for more information
//n -> sumatoria = 1 + 2....n

using System.Reflection;

Console.WriteLine("a. Sumatoria");
Console.WriteLine("b. Tablas de multiplicar");

char opcion = Convert.ToChar(Console.ReadLine());

switch (opcion)
{
    case 'a':
        Console.Write("Ingrese un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());


        int resultado = 0;

        do
        {
            resultado = resultado + n;
            n--;

        } while (n > 0);
        Console.WriteLine("Sumatoria=" + resultado);


        break;
    case 'b':
        for (int i = 1; i < 11; i++)
        {
            Console.Write(i + ": ");
            for (int j = 1; j < 11; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.Write('\n');
        }


        break;
}





