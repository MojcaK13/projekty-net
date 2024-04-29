namespace Linuxoteka
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tekst = "C:\\Users\\mojca\\Desktop\\projekty-net\\Linuxoteka\\UbuntuLista.txt";
            if (File.Exists(tekst))
            {
                string zawartosc = File.ReadAllText(tekst);
                Console.WriteLine("Zawartosc pliku: ");
                Console.WriteLine(zawartosc);
            }
            else
            {
                Console.WriteLine("brak pliku!");
            }
        }
    }
}
