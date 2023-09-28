using LiskovPrinciple;
using System.Diagnostics;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Si un clase está diseñada para funcionar con los elementos de una clase base");
Console.WriteLine("debería funcionar correctamente si se sobreescribe cualquier elemento por ");
Console.WriteLine("otro en la clase que hereda.");




Console.WriteLine("Creamos una instancia de la clase base llamada rectangulo() con propiedades Ancho = 5 y Altura =10");
Console.WriteLine("Así como un método para calcular el área:    rectangulo.CalcularArea()");

Console.WriteLine("-----------------------------------------------");
Rectangulo rectangulo = new Rectangulo();
rectangulo.Ancho = 5;
rectangulo.Alto = 10;
Console.WriteLine("rectangulo.Ancho=5");
Console.WriteLine("rectangulo.Alto=10");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
Console.WriteLine("-----------------------------------------------");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Luego creamos la clase Cuadrado que hereda de la clase Rectangulo y en esta sobre escribimos");
Console.WriteLine("las propiedades: Ancho y Alto, de tal forma que los metodos get y set de las propiedades vayan a un solo valor");
Console.WriteLine("llamado _lado. Para calcular el valor de un cuadrado solo se requiere el valor de un lado que se utiliza tanto");
Console.WriteLine("para el ancho como para la altura.");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("-----------------------------------------------");
Cuadrado cuadrado = new Cuadrado();
cuadrado.Ancho = 5;
Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
Console.WriteLine("-----------------------------------------------");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("las clases derivadas deben mantener el contrato establecido por la clase base.");
Console.WriteLine("deben implementar todos los métodos y propiedades de la clase base, y deben hacerlo");
Console.WriteLine(" de forma que no se violen las suposiciones hechas por el código que utiliza la clase base.");



Console.WriteLine("-----------------------------------------------");