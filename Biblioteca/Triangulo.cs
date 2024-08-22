namespace Biblioteca;

public class Triangulo : Figura
{
	private double Lado1;
	private double Lado2;
	private double Lado3;
	private double AlturaA;
	private double AlturaB;
	private double AlturaC;
	public Triangulo() {}
	public Triangulo(double lado1, double lado2, double lado3)
	{
		Lado1 = Math.Round(lado1, 2);
		Lado2 = Math.Round(lado2, 2);
		this.Lado3 = Math.Round(lado3, 2);
		CalcularArea();
		CalcularAltura();
		CalcularPerimetro();
	}

	public double HallarHipotenusa()
	{
		if (Lado1 >= Lado2 && Lado1 >= Lado3)
		{
			return Lado1;
		}
		else if (Lado2 >= Lado1 && Lado2 >= Lado3)
		{
			return Lado2;
		}
		else
		{
			return Lado3;
		}
	}
	public void CalcularAltura()
	{
		double hipotenusa = HallarHipotenusa();
		
		if (Lado1 == Lado2 && Lado1 == Lado3)
		{
			AlturaA = Math.Round((Math.Sqrt(3)/2) * hipotenusa , 2);
		}
		else if(Lado1 == Lado2 || Lado1 == Lado3)
		{
			AlturaA = Math.Round(Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(Lado1 / 2, 2)), 2);
			AlturaB = Math.Round(Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(Lado2 / 2, 2)), 2);
			AlturaC = Math.Round(Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(Lado3 / 2, 2)), 2);
		}
		else
		{
			AlturaA = Math.Round((2 * Area) / Lado1, 2);
			AlturaB = Math.Round((2 * Area) / Lado2, 2);
			AlturaC = Math.Round((2 * Area) / Lado3, 2);
		}
	}
	public bool Forma()
	{
		if(Lado1 == Lado2 && Lado1 == Lado3)
		{
			Console.WriteLine("-------- Triangulo Equilatero --------");
		}
		else if(Lado1 == Lado2 || Lado1 == Lado3)
		{
			if (Lado1 < Lado2 + Lado3 || Lado2 < Lado1 + Lado3 || Lado3 < Lado2 + Lado1)
			{
				
			}
			Console.WriteLine("-------- Triangulo Isóceles --------");
		}
		else
		{
			if (Lado1 > Lado2 + Lado3 || Lado2 > Lado1 + Lado3 || Lado3 > Lado2 + Lado1)
				return false;
			Console.WriteLine("-------- Triangulo Escaleno --------");
		}
		return true;
	}

	public override void CalcularArea()
	{
		double s = (Lado1 + Lado2 + Lado3) / 2;
		Area = Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
	}

	public override void CalcularPerimetro()
	{
		Perimetro = Math.Round(Lado1 + Lado2 + Lado3, 2);
	}

	public override void Mostrar()
	{
		if (Forma() == true)
		{
			Forma();
			Console.WriteLine($"Lado1: { Lado1 }");
			Console.WriteLine($"Lado2: { Lado2 }");
			Console.WriteLine($"Lado3: { Lado3 }");
			if (AlturaB == 0)
			{
				Console.WriteLine($"Altura: { AlturaA }");
			}
			else
			{
				Console.WriteLine($"Altura (A): { AlturaA }");
				Console.WriteLine($"Altura (B): { AlturaB }");
				Console.WriteLine($"Altura (C): { AlturaC }");
			}
			base.Mostrar();
		}
		else
		{
            Console.WriteLine("No forma triangulo");
		}
	}
}