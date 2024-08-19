namespace Biblioteca;

public class Circulo : Figura
{
    private float Radio;
    public Circulo(){}
    public Circulo(float radio)
    {
        Radio = radio;
        CalcularArea();
        CalcularPerimetro();
    }
    public override void CalcularArea()
    {
        Area = MathF.PI * MathF.Pow(Radio, 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 2 * MathF.PI * Radio;
    }
    public override void Mostrar()
    {
        Console.WriteLine("-------- Circulo --------");
        System.Console.WriteLine($"Radio: {Radio}");
        base.Mostrar();
    }
}