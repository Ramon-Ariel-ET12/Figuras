namespace Biblioteca;

public class Triangulo : Figura
{
	private double Lado1;
	private double Lado2;
	private double Base;
	private double Altura;
	public Triangulo() {}
	public Triangulo(double lado1, double lado2, double Base)
	{
		Lado1 = Math.Round(lado1, 2);
		Lado2 = Math.Round(lado2, 2);
		this.Base = Math.Round(Base, 2);
		CalcularAltura();
		CalcularPerimetro();
		CalcularArea();
	}

	public void CalcularAltura()
	{
		double hipotenusa;
			if (Lado1 >= Lado2 && Lado1 >= Base)
            {
                hipotenusa = Lado1;
            }
            else if (Lado2 >= Lado1 && Lado2 >= Base)
            {
                hipotenusa = Lado2;
            }
            else
            {
                hipotenusa = Base;
            }
		Altura = Math.Round(Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(Base / 2, 2)), 2);
	}
	public void Forma()
	{
		if(Lado1 == Lado2 && Lado1 == Base && Lado2 == Base)
		{
			Console.WriteLine("-------- Triangulo Equilatero --------");
		}
		else if(Lado1 == Lado2)
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
		Area = Math.Round(Altura * Base / 2, 2);
	}

	public override void CalcularPerimetro()
	{
		Perimetro = Math.Round(Lado1 + Lado2 + Base, 2);
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