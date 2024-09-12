namespace Laboratorio5
{
    internal class Calif_estudiantes
    {
        static void Main(string[] args)
        {
            Calif_estudiantes ce = new Calif_estudiantes();
            ce.Notas();
        }

        public void Notas()
        {
            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
            int suma = 0;

            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }

            double promedio = suma / (double)calificaciones.Count;

            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        }
    }
}