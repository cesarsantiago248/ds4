﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            string linea;
            Console.Write("Ingrese el valor de n:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1;
            while (x <= n)
            {
                Console.Write(x);
                Console.Write(" , ");
                x = x + 1;
            }
            Console.ReadKey();
        }

    }

}