namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usuario ingresa lados del triangulo
            Console.Write("Ingrese el lado 1: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 2: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 3: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            // Valida congruencia de los lados para ver si es un triangualo
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                // Determinar el tipo de triángulo
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("El triángulo es equilátero.");
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.WriteLine("El triángulo es isósceles.");
                }
                else
                {
                    Console.WriteLine("El triángulo es escaleno.");
                }
            }
            else
            {
                Console.WriteLine("No se puede formar un triángulo con estos lados.");
            }

            Console.ReadLine();
        }
    }
}