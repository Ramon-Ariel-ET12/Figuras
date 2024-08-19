﻿using Biblioteca;
Console.Clear();

Rectangulo rectangulo = new Rectangulo(100, 100);

rectangulo.Mostrar();

Circulo circulo= new Circulo(100);

circulo.Mostrar();

Triangulo equilatero = new (20, 20, 20, 20);
Triangulo isoceles = new (5, 5, 6, 4);
Triangulo escaleno = new (9, 20, 21, 20);

equilatero.Mostrar();
isoceles.Mostrar();
escaleno.Mostrar();