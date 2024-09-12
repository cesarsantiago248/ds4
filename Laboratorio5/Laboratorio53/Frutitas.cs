namespace Laboratorio5
{
    internal class Frutitas
    {
        static void Main(string[] args)
        {
            Frutitas fr = new Frutitas();
            fr.Frutilla();
        }

        public void Frutilla()
        {
        string[] frutas = { "manzana", "plátano", "naranja" };

        foreach (string fruta in frutas)
            {
            Console.WriteLine(fruta);
            }
        }

    }
}