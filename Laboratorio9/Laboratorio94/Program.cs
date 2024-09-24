using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Aleatorios aleatorios = new Aleatorios();
            int min = 1;
            int max = 10;
            int cantidad = 5;

            int[] arreglo = new int[cantidad];
            bool[] usado = new bool[max - min + 1];

            for (int i = 0; i < cantidad; i++)
            {
                int numero;
                do
                {
                    numero = aleatorios.GenerarNumero(min, max);
                } while (usado[numero - min]);

                arreglo[i] = numero;
                usado[numero - min] = true;
            }

            Console.WriteLine("Arreglo de números no repetidos:");
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}