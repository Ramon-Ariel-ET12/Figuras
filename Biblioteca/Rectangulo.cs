namespace Biblioteca;

public class Rectangulo : Figura
{
    private double Ancho;
    private double Altura;
    public Rectangulo(){}
    public Rectangulo(double Ancho, double Altura)
    {
        this.Ancho = Ancho;
        this.Altura = Altura;
        CalcularArea();
        CalcularPerimetro();
    }

    public override void CalcularArea()
    {
        Area = Ancho * Altura;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 2 * (Ancho + Altura);
    }
    public override void Mostrar()
    {
        Console.WriteLine("-------- Rectangulo --------");
        Console.WriteLine($"Ancho: {Ancho}");
        Console.WriteLine($"Altura: {Altura}");
        base.Mostrar();
    }
}