namespace Biblioteca;

public class Triangulo : Figura
{
	private double Lado1;
	private double Lado2;
	private double Base;
	private double Altura;
	public Triangulo() {}
	public Triangulo(double lado1, double lado2, double Base, double altura)
	{
		Lado1 = lado1;
		Lado2 = lado2;
		this.Base = Base;
		Altura = altura;
		CalcularArea();
		CalcularPerimetro();
	}

	public void Forma()
	{
		double alturaTeorica = Math.Sqrt(Math.Pow(Lado1, 2) - Math.Pow(Base / 2, 2));
		if(Lado1 == Lado2 && Lado1 == Base && Lado2 == Base)
		{
			Console.WriteLine("-------- Triangulo Equilatero --------");
		}
		else if(Lado1 == Lado2 && Math.Abs(Altura - alturaTeorica) <= 0)
		{
			Console.WriteLine("-------- Triangulo Isóceles --------");
		}
		else
		{
			Console.WriteLine("-------- Triangulo Escaleno --------");
		}
	
	}

	public override void CalcularArea()
	{
		Area =  Altura * Base / 2;
	}

	public override void CalcularPerimetro()
	{
		Perimetro = Lado1 + Lado2 + Base;
	}

	public override void Mostrar()
	{
		Forma();
		Console.WriteLine($"Lado1: { Lado1 }");
		Console.WriteLine($"Lado2: { Lado2 }");
		Console.WriteLine($"Base: { Base }");
		Console.WriteLine($"Altura: { Altura }");
		base.Mostrar();
	}
}