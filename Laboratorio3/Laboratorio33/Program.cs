using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // LABORATORIO 3-1 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---");
        Console.WriteLine("Laboratorio # 3-1 Cesar Santiago DSIV");
        Console.WriteLine("");
        CalculosMatematicos calc = new CalculosMatematicos();
        Console.WriteLine("* Realizaremos la operacion (a+b)*(a-b) con 2 numeros que usted ingresara.");
        Console.WriteLine("----> Ingrese el primer numero: ");
        int a = Convert.ToInt32(Console.ReadLine());
        calc.NumA = a;
        Console.WriteLine("----> Ingrese el segundo numero: ");
        int b = Convert.ToInt32(Console.ReadLine());
        calc.NumB = b;

        int result1 = calc.Calcular();
        Console.WriteLine("El resultado de la operacion ("+a+"+"+b+")*("+a+"-"+b+") es igual a: " + result1);
        Console.WriteLine("");
        Console.WriteLine("");

        // LABORATORIO 3-2 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---");
        Console.WriteLine("Laboratorio # 3-2 Cesar Santiago DSIV");
        Console.WriteLine("");
        Console.WriteLine("* Calularemos el area de un circulo con el valor del radio que usted ingresara.");
        Console.WriteLine("----> Ingrese el valor del radio del circulo: ");
        double inputradio = Convert.ToDouble(Console.ReadLine());
        calc.radio = inputradio;

        double result2 = calc.calculoArea();
        Console.WriteLine("El area del circulo con radio de ("+inputradio+") es igual a: " + result2);
        Console.WriteLine("");
        Console.WriteLine("");

        // LABORATORIO 3-3 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---");
        Console.WriteLine("Laboratorio # 3-3 Cesar Santiago DSIV");
        Console.WriteLine("");
        Console.WriteLine("* Calularemos el perimetro de un rectangulo con los valores del largo y ancho que usted ingresara.");
        Console.WriteLine("----> Ingrese el valor del largo del rectangulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());
        calc.numlargo = largo;

        Console.WriteLine("----> Ingrese el valor del ancho del rectangulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());
        calc.numancho = ancho;

        double result3 = calc.calculoPerim();
        Console.WriteLine("El perimetro del rectangulo con largo de ("+largo+") y ancho de ("+ancho+") es igual a: " + result3);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---");

    }

    public class CalculosMatematicos
    {
        public int NumA { get; set; }
        public int NumB { get; set; }

        public double radio { get; set; }

        public double numlargo { get; set; }

        public double numancho { get; set; }
        public int Calcular()
        {
            int resultado = (NumA + NumB) * (NumA - NumB);
            return resultado;
        }

        public double calculoArea()
        {
            double area = Math.PI * (radio * radio);

            return area;
        }

        public double calculoPerim()
        {
            double perimetro = 2 * (numlargo + numancho);

            return perimetro;
        }
    }



}