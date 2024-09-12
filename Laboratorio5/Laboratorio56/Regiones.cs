namespace Laboratorio5
{
    internal class Regiones
    {
        static void Main(string[] args)
        {
            Regiones reg = new Regiones();
            reg.showRegiones();
        }

        public void showRegiones()
        {
            Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>
            {
                {"Francia", "Paris" },
                {"España", "Madrid" },
                {"Italia", "Roma" }
            };

            foreach (KeyValuePair<string, string> par in paisesYCapitales)
                {
                Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
            }
        }
    }
}