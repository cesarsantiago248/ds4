using System;

// Laboratorio2
// DesaSoft IV
// Cesar Santiago 8-979-1368
// Prof. Regis Rivera

namespace Laboratorio_2
{
    class Program
    {
        // Variables Locales dentro de un metodo en C#
        public void Sumar(int valor1, int valor2)
        {
            int variableLocal = valor1 + valor2;
            Console.WriteLine(variableLocal);
        }


        static void Main(string[] args)
        {
            // Variables Locales dentro de un metodo en C#
            Console.WriteLine("Laboratorio 2 - Problema 1: Variables Locales en C#");
            Program program = new Program();
            program.Sumar(5, 3);

            // Variables de Instancia
            Console.WriteLine("Laboratorio 2 - Problema 2: Variables de Instancia en C#");
            Client client = new Client();
            client.FirstName = "Su_Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

            // Variables de Instancia
            Console.WriteLine("Laboratorio 2 - Problema 3: Variables Estatica en C#");
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

            // Tipos de datos de variables
            Console.WriteLine("Laboratorio 2 - Problema 4: Tipos de Datos");
            int nombreVariable = 1000;
            int valor1 = 28;
            int valor2 = valor1;
            valor2 = 30;
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine("Laboratorio 2 - Problema 5: Objetos");
            MyClass object1 = new MyClass();
            object1.Nombre = "Fulano";
            object1.Edad = 28;
            MyClass object2 = object1;
            object2.Nombre = "Jose";
            Console.WriteLine(object2.Nombre);
            Console.WriteLine(object1.Nombre);

            char character = 'A';
            string cadena = "Cadena de caracteres";
            bool condicion = true;
        }


        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }

        // Variable estatica
        public class MyClass
        {

            public static int Valor;
            public string Nombre { get; set; }
            public int Edad { get; set; }


        }



    }
}