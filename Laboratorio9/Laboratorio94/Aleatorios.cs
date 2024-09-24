namespace Laboratorio9
{
    public class Aleatorios
    {
        private Random random1;

        public Aleatorios()
        {
            random1 = new Random();
        }

        // i. Generar un número entre 2 números
        public int GenerarNumero(int min, int max)
        {
            return random1.Next(min, max + 1);
        }

        // ii. Generar un arreglo de números entre dos números aleatorios
        public int[] GenerarArreglo(int min, int max, int cantidad)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
}