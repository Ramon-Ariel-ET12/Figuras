namespace Biblioteca;

public class Circulo : Figura
{
    private double Radio;
    public Circulo(){}
    public Circulo(double radio)
    {
        Radio = Math.Round(radio, 2);
        CalcularArea();
        CalcularPerimetro();
    }
    public override void CalcularArea()
    {
        Area = Math.Round(MathF.PI * MathF.Pow((float)Radio, 2), 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = Math.Round(2 * MathF.PI * Radio, 2);
    }
    public override void Mostrar()
    {
        Console.WriteLine("-------- Circulo --------");
        System.Console.WriteLine($"Radio: {Radio}");
        base.Mostrar();
    }
}