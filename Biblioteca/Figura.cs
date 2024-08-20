namespace Biblioteca;

public abstract class Figura
{
	protected double Area;
	protected double Perimetro;
	public Figura(){}

	public abstract void CalcularArea();
	public abstract void CalcularPerimetro();
	public virtual void Mostrar()
	{
		Console.WriteLine($"Area: { Area }");
		Console.WriteLine($"Perimetro: { Perimetro }\n");
	}
}
