using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // LABORATORIO 3-1 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Laboratorio # 3-1 Cesar Santiago DSIV");
        CalculosMatematicos calc = new CalculosMatematicos();
        Console.WriteLine("Realizaremos la operacion (a+b)*(a-b) con 2 numeros que usted ingresara.");
        Console.WriteLine("Ingrese el primer numero: ");
        int a = Convert.ToInt32(Console.ReadLine());
        calc.NumA = a;
        Console.WriteLine("Ingrese el segundo numero: ");
        int b = Convert.ToInt32(Console.ReadLine());
        calc.NumB = b;

        int result1 = calc.Calcular();
        Console.WriteLine("El resultado de la operacion (a+b)*(a-b) es igual a: " + result1);


        // LABORATORIO 3-2 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Laboratorio # 3-2 Cesar Santiago DSIV");
        Console.WriteLine("Calularemos el area de un circulo con el valor del radio que usted ingresara.");
        Console.WriteLine("Ingrese el valor del radio del circulo: ");
        double inputradio = Convert.ToDouble(Console.ReadLine());
        calc.radio = inputradio;

        double result2 = calc.calculoArea();
        Console.WriteLine("El area del circulo es igual a: " + result2);

    }

    public class CalculosMatematicos
    {
        public int NumA { get; set; }
        public int NumB { get; set; }

        public double radio {  get; set; }
        public int Calcular()
        {
            int resultado = (NumA + NumB) * (NumA - NumB);
            return resultado;
        }

        public double calculoArea()
        {
            double area = Math.PI * (radio*radio);

            return area;
        }
    }



}