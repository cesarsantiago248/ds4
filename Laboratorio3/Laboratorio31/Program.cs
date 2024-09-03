internal class Program
{
    private static void Main(string[] args)
    {
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


    }

    public class CalculosMatematicos
    {
        public int NumA { get; set; }
        public int NumB { get; set; }
        public int Calcular()
        {
            int resultado = (NumA + NumB) * (NumA - NumB);
            return resultado;
        }
    }

}