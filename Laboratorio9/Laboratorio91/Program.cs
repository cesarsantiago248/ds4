namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Usuario, ingrese el precio del producto (se admiten decimales): ");
            decimal prodprecio = Convert.ToDecimal(Console.ReadLine());

            // Validar que sea positivo ////////////////////////////////////////////
            if (prodprecio <= 0)
            {
                Console.WriteLine("El precio no puede ser un valor negativo.");
                return;
            }

            Console.Write("Ingrese la forma de pago (efectivo (1) o tarjeta (2)): ");
            int formaPago = Convert.ToInt16(Console.ReadLine());

            if (formaPago == 2)
            {
                // Pedir número de cuenta
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                string numeroCuenta = Console.ReadLine();

                // Verificar que el número de cuenta tenga 16 dígitos
                if (numeroCuenta.Length != 16)
                {
                    Console.WriteLine("El número de cuenta debe tener 16 dígitos.");
                    return;
                }

                // Mostrar datos ingresados
                Console.WriteLine($"Precio del producto: {prodprecio}");
                Console.WriteLine($"Forma de pago: {formaPago}");
                Console.WriteLine($"Número de cuenta: {numeroCuenta}");
            }
            else if (formaPago == 1)
            {
                // Mostrar datos ingresados
                Console.WriteLine($"Precio del producto: {prodprecio}");
                Console.WriteLine($"Forma de pago: {formaPago}");
            }
            else
            {
                Console.WriteLine("Forma de pago no válida.");
            }

            Console.ReadLine();
        }
    }
}