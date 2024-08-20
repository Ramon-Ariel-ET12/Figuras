namespace Biblioteca;

public class Rectangulo : Figura
{
    private double Ancho;
    private double Altura;
    public Rectangulo(){}
    public Rectangulo(double Ancho, double Altura)
    {
        this.Ancho = Math.Round(Ancho, 2);
        this.Altura = Math.Round(Altura, 2);
        CalcularArea();
        CalcularPerimetro();
    }

    public override void CalcularArea()
    {
        Area = Math.Round(Ancho * Altura, 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = Math.Round(2 * (Ancho + Altura), 2);
    }
    public override void Mostrar()
    {
        Console.WriteLine("-------- Rectangulo --------");
        Console.WriteLine($"Ancho: {Ancho}");
        Console.WriteLine($"Altura: {Altura}");
        base.Mostrar();
    }
}