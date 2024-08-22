using Biblioteca;

Console.Clear();

while (true)
{
    Console.Write("Ingrese Lado1: ");
    var lado1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese Lado2: ");
    var lado2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese Lado3: ");
    var Lado3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\n");

    Triangulo triangulo = new (lado1, lado2, Lado3);
    triangulo.Mostrar();

    Console.WriteLine("\nTerminar programa?\nsi=1  no=0\n");
    Console.Write("Respuesta: ");
    var ciclo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n");
    if (ciclo == 1)
        break;
}
